using MySqlConnector;

namespace PetShop_App.Dados;

/// <summary>
/// Provisiona o banco, as tabelas e os dados mínimos de demonstração.
/// Os comandos são idempotentes e podem ser executados em toda inicialização.
/// </summary>
public static class InicializadorBanco
{
    /// <summary>Garante que o banco e sua estrutura existam antes da autenticação.</summary>
    public static async Task InicializarAsync()
    {
        // A primeira conexão não informa Database porque ele pode ainda não existir.
        await using (var conexaoServidor = ConexaoBanco.Criar(false))
        {
            await conexaoServidor.OpenAsync();
            await using var criarBanco = conexaoServidor.CreateCommand();
            criarBanco.CommandText = $"CREATE DATABASE IF NOT EXISTS `{ConfiguracaoBanco.Banco}` CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci";
            await criarBanco.ExecuteNonQueryAsync();
        }

        // A partir daqui, todos os comandos são executados dentro do banco criado.
        await using var conexao = ConexaoBanco.Criar();
        await conexao.OpenAsync();
        await using var comando = conexao.CreateCommand();
        // CREATE IF NOT EXISTS e INSERT IGNORE permitem repetir a inicialização
        // sem apagar ou duplicar dados cadastrados pelo usuário.
        comando.CommandText = """
            CREATE TABLE IF NOT EXISTS funcionarios (
                id INT AUTO_INCREMENT PRIMARY KEY,
                nome VARCHAR(120) NOT NULL,
                usuario VARCHAR(80) NOT NULL UNIQUE,
                senha VARCHAR(255) NOT NULL,
                perfil VARCHAR(40) NOT NULL DEFAULT 'Atendente',
                ativo BOOLEAN NOT NULL DEFAULT TRUE
            );
            CREATE TABLE IF NOT EXISTS clientes (
                id INT AUTO_INCREMENT PRIMARY KEY,
                nome VARCHAR(150) NOT NULL,
                cpf VARCHAR(14), telefone VARCHAR(20), email VARCHAR(150),
                criado_em DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
            );
            CREATE TABLE IF NOT EXISTS pets (
                id INT AUTO_INCREMENT PRIMARY KEY,
                cliente_id INT NOT NULL,
                nome VARCHAR(100) NOT NULL,
                especie VARCHAR(50) NOT NULL,
                raca VARCHAR(80), porte VARCHAR(20), nascimento DATE, peso DECIMAL(7,2),
                CONSTRAINT fk_pet_cliente FOREIGN KEY (cliente_id) REFERENCES clientes(id) ON DELETE RESTRICT
            );
            CREATE TABLE IF NOT EXISTS servicos (
                id INT AUTO_INCREMENT PRIMARY KEY,
                nome VARCHAR(120) NOT NULL,
                descricao VARCHAR(500), valor DECIMAL(10,2) NOT NULL,
                duracao_minutos INT NOT NULL, ativo BOOLEAN NOT NULL DEFAULT TRUE
            );
            CREATE TABLE IF NOT EXISTS atendimentos (
                id INT AUTO_INCREMENT PRIMARY KEY,
                pet_id INT NOT NULL, servico_id INT NOT NULL,
                data_hora DATETIME NOT NULL, valor DECIMAL(10,2) NOT NULL,
                status VARCHAR(30) NOT NULL DEFAULT 'Agendado', observacoes VARCHAR(500),
                CONSTRAINT fk_atendimento_pet FOREIGN KEY (pet_id) REFERENCES pets(id) ON DELETE RESTRICT,
                CONSTRAINT fk_atendimento_servico FOREIGN KEY (servico_id) REFERENCES servicos(id) ON DELETE RESTRICT
            );
            CREATE TABLE IF NOT EXISTS produtos (
                id INT AUTO_INCREMENT PRIMARY KEY, codigo VARCHAR(30) NOT NULL UNIQUE,
                nome VARCHAR(150) NOT NULL, categoria VARCHAR(80), preco DECIMAL(10,2) NOT NULL,
                estoque INT NOT NULL DEFAULT 0, estoque_minimo INT NOT NULL DEFAULT 5, ativo BOOLEAN NOT NULL DEFAULT TRUE
            );
            CREATE TABLE IF NOT EXISTS pedidos (
                id INT AUTO_INCREMENT PRIMARY KEY, numero VARCHAR(30) NOT NULL UNIQUE,
                cliente_id INT NULL, data_hora DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
                total DECIMAL(10,2) NOT NULL, status VARCHAR(30) NOT NULL,
                forma_pagamento VARCHAR(30), CONSTRAINT fk_pedido_cliente FOREIGN KEY(cliente_id) REFERENCES clientes(id)
            );
            CREATE TABLE IF NOT EXISTS pedido_itens (
                id INT AUTO_INCREMENT PRIMARY KEY, pedido_id INT NOT NULL, produto_id INT NOT NULL,
                quantidade INT NOT NULL, valor_unitario DECIMAL(10,2) NOT NULL,
                CONSTRAINT fk_item_pedido FOREIGN KEY(pedido_id) REFERENCES pedidos(id) ON DELETE CASCADE,
                CONSTRAINT fk_item_produto FOREIGN KEY(produto_id) REFERENCES produtos(id)
            );
            CREATE TABLE IF NOT EXISTS caixas (
                id INT AUTO_INCREMENT PRIMARY KEY,
                funcionario_id INT NULL,
                aberto_em DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
                fechado_em DATETIME NULL,
                saldo_inicial DECIMAL(10,2) NOT NULL DEFAULT 0,
                saldo_final DECIMAL(10,2) NULL,
                status VARCHAR(20) NOT NULL DEFAULT 'Aberto',
                CONSTRAINT fk_caixa_funcionario FOREIGN KEY(funcionario_id) REFERENCES funcionarios(id)
            );
            INSERT IGNORE INTO funcionarios (nome, usuario, senha, perfil) VALUES ('Administrador', 'admin', 'admin', 'Gerente');
            INSERT INTO servicos (nome, descricao, valor, duracao_minutos)
            SELECT 'Banho pequeno', 'Banho completo para pets de pequeno porte', 55.00, 60
            WHERE NOT EXISTS (SELECT 1 FROM servicos);
            INSERT INTO clientes(nome,cpf,telefone,email) SELECT 'Carlos Eduardo Silva','123.456.789-10','(11) 99876-1201','carlos@email.com' WHERE NOT EXISTS(SELECT 1 FROM clientes WHERE email='carlos@email.com');
            INSERT INTO clientes(nome,cpf,telefone,email) SELECT 'Ana Souza','987.654.321-00','(11) 98822-4300','ana@email.com' WHERE NOT EXISTS(SELECT 1 FROM clientes WHERE email='ana@email.com');
            INSERT INTO clientes(nome,cpf,telefone,email) SELECT 'Marcos Lima','456.789.123-55','(11) 97731-8800','marcos@email.com' WHERE NOT EXISTS(SELECT 1 FROM clientes WHERE email='marcos@email.com');
            INSERT INTO clientes(nome,cpf,telefone,email) SELECT 'Fernanda Rocha','741.852.963-20','(11) 96654-2210','fernanda@email.com' WHERE NOT EXISTS(SELECT 1 FROM clientes WHERE email='fernanda@email.com');
            INSERT INTO pets(cliente_id,nome,especie,raca,porte,nascimento,peso) SELECT id,'Thor','Cão','Labrador','Grande','2022-03-10',32 FROM clientes WHERE email='carlos@email.com' AND NOT EXISTS(SELECT 1 FROM pets WHERE nome='Thor');
            INSERT INTO pets(cliente_id,nome,especie,raca,porte,nascimento,peso) SELECT id,'Mel','Gato','SRD','Pequeno','2024-01-20',4 FROM clientes WHERE email='ana@email.com' AND NOT EXISTS(SELECT 1 FROM pets WHERE nome='Mel');
            INSERT INTO pets(cliente_id,nome,especie,raca,porte,nascimento,peso) SELECT id,'Luna','Cão','Poodle','Pequeno','2020-07-08',6 FROM clientes WHERE email='marcos@email.com' AND NOT EXISTS(SELECT 1 FROM pets WHERE nome='Luna');
            INSERT INTO pets(cliente_id,nome,especie,raca,porte,nascimento,peso) SELECT id,'Bob','Cão','Shih-tzu','Pequeno','2017-11-15',7 FROM clientes WHERE email='carlos@email.com' AND NOT EXISTS(SELECT 1 FROM pets WHERE nome='Bob');
            INSERT INTO servicos(nome,descricao,valor,duracao_minutos) SELECT 'Tosa completa','Tosa, acabamento e higiene',95,90 WHERE NOT EXISTS(SELECT 1 FROM servicos WHERE nome='Tosa completa');
            INSERT INTO servicos(nome,descricao,valor,duracao_minutos) SELECT 'Banho grande','Banho completo para pets grandes',85,80 WHERE NOT EXISTS(SELECT 1 FROM servicos WHERE nome='Banho grande');
            INSERT INTO servicos(nome,descricao,valor,duracao_minutos) SELECT 'Corte de unhas','Corte e acabamento das unhas',25,20 WHERE NOT EXISTS(SELECT 1 FROM servicos WHERE nome='Corte de unhas');
            INSERT IGNORE INTO produtos(codigo,nome,categoria,preco,estoque,estoque_minimo) VALUES
              ('RAC-001','Ração Premium Cães 15 kg','Rações',189.90,4,5),('PET-002','Petisco dental','Petiscos',18.50,2,10),
              ('HIG-003','Shampoo neutro 500 ml','Higiene',32.90,18,6),('BRQ-004','Bola resistente','Brinquedos',24.90,12,5),
              ('ACE-005','Coleira ajustável M','Acessórios',39.90,9,4),('ARE-006','Areia higiênica 4 kg','Higiene',29.90,14,5);
            INSERT IGNORE INTO pedidos(numero,cliente_id,data_hora,total,status,forma_pagamento) SELECT 'PED-1001',id,NOW()-INTERVAL 1 DAY,214.80,'Concluído','PIX' FROM clientes WHERE email='carlos@email.com';
            INSERT IGNORE INTO pedidos(numero,cliente_id,data_hora,total,status,forma_pagamento) SELECT 'PED-1002',id,NOW(),69.80,'Em separação','Cartão' FROM clientes WHERE email='ana@email.com';
            INSERT IGNORE INTO pedidos(numero,cliente_id,data_hora,total,status,forma_pagamento) SELECT 'PED-1003',id,NOW(),189.90,'Novo','Dinheiro' FROM clientes WHERE email='fernanda@email.com';
            INSERT INTO pedido_itens(pedido_id,produto_id,quantidade,valor_unitario) SELECT pe.id,pr.id,1,pr.preco FROM pedidos pe,produtos pr WHERE pe.numero='PED-1001' AND pr.codigo='RAC-001' AND NOT EXISTS(SELECT 1 FROM pedido_itens WHERE pedido_id=pe.id);
            INSERT INTO pedido_itens(pedido_id,produto_id,quantidade,valor_unitario) SELECT pe.id,pr.id,2,pr.preco FROM pedidos pe,produtos pr WHERE pe.numero='PED-1002' AND pr.codigo='BRQ-004' AND NOT EXISTS(SELECT 1 FROM pedido_itens WHERE pedido_id=pe.id);
            INSERT INTO pedido_itens(pedido_id,produto_id,quantidade,valor_unitario) SELECT pe.id,pr.id,1,pr.preco FROM pedidos pe,produtos pr WHERE pe.numero='PED-1003' AND pr.codigo='RAC-001' AND NOT EXISTS(SELECT 1 FROM pedido_itens WHERE pedido_id=pe.id);
            INSERT INTO atendimentos(pet_id,servico_id,data_hora,valor,status,observacoes)
              SELECT p.id,s.id,CURDATE()+INTERVAL 9 HOUR,s.valor,'Agendado','Cliente confirmou por telefone' FROM pets p,servicos s WHERE p.nome='Thor' AND s.nome='Banho grande' AND NOT EXISTS(SELECT 1 FROM atendimentos WHERE DATE(data_hora)=CURDATE() AND pet_id=p.id);
            INSERT INTO atendimentos(pet_id,servico_id,data_hora,valor,status,observacoes)
              SELECT p.id,s.id,CURDATE()+INTERVAL 11 HOUR,s.valor,'Em atendimento','Pet sensível ao secador' FROM pets p,servicos s WHERE p.nome='Luna' AND s.nome='Tosa completa' AND NOT EXISTS(SELECT 1 FROM atendimentos WHERE DATE(data_hora)=CURDATE() AND pet_id=p.id);
            """;
        await comando.ExecuteNonQueryAsync();
    }
}
