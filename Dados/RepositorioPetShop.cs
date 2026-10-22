using MySqlConnector;
using PetShop_App.Modelos;

namespace PetShop_App.Dados;

/// <summary>
/// Camada de acesso a dados do sistema. As telas entregam e recebem modelos;
/// somente esta classe conhece SQL, parâmetros e o formato das tabelas MySQL.
/// Cada operação abre e descarta sua própria conexão.
/// </summary>
public sealed class RepositorioPetShop
{
    /// <summary>Valida um funcionário ativo e retorna os dados usados na sessão.</summary>
    public async Task<(bool Valido, string Nome, string Perfil)> AutenticarAsync(string usuario, string senha)
    {
        await using var conexao = ConexaoBanco.Criar();
        await conexao.OpenAsync();
        await using var comando = conexao.CreateCommand();
        comando.CommandText = "SELECT nome,perfil FROM funcionarios WHERE usuario=@usuario AND senha=@senha AND ativo=1 LIMIT 1";
        comando.Parameters.AddWithValue("@usuario", usuario);
        comando.Parameters.AddWithValue("@senha", senha);
        await using var leitor = await comando.ExecuteReaderAsync();
        if (!await leitor.ReadAsync()) return (false, "", "");
        return (true, leitor.GetString(0), leitor.GetString(1));
    }

    /// <summary>Informa se existe um caixa ainda não fechado.</summary>
    public async Task<bool> CaixaEstaAbertoAsync()
    {
        await using var conexao = ConexaoBanco.Criar(); await conexao.OpenAsync();
        await using var comando = conexao.CreateCommand();
        comando.CommandText = "SELECT EXISTS(SELECT 1 FROM caixas WHERE status='Aberto' AND fechado_em IS NULL)";
        return Convert.ToInt32(await comando.ExecuteScalarAsync()) == 1;
    }

    /// <summary>Inicia um turno, impedindo dois caixas abertos simultaneamente.</summary>
    public async Task AbrirCaixaAsync(decimal saldoInicial)
    {
        if (await CaixaEstaAbertoAsync()) throw new InvalidOperationException("Já existe um caixa aberto.");
        await ExecutarAsync("INSERT INTO caixas(aberto_em,saldo_inicial,status) VALUES(NOW(),@saldo,'Aberto')", ("@saldo", saldoInicial));
    }

    /// <summary>Fecha o caixa ativo e registra o saldo contado ao final do turno.</summary>
    public async Task FecharCaixaAsync(decimal saldoFinal)
    {
        if (!await CaixaEstaAbertoAsync()) throw new InvalidOperationException("O caixa já está fechado.");
        await ExecutarAsync("UPDATE caixas SET fechado_em=NOW(),saldo_final=@saldo,status='Fechado' WHERE status='Aberto' AND fechado_em IS NULL", ("@saldo", saldoFinal));
    }

    /// <summary>Lista clientes por nome ou telefone para grades e seletores.</summary>
    public async Task<List<Cliente>> ListarClientesAsync(string pesquisa = "")
    {
        var itens = new List<Cliente>();
        await using var conexao = ConexaoBanco.Criar(); await conexao.OpenAsync();
        await using var comando = conexao.CreateCommand();
        comando.CommandText = "SELECT id,nome,COALESCE(cpf,''),COALESCE(telefone,''),COALESCE(email,'') FROM clientes WHERE nome LIKE @busca OR telefone LIKE @busca ORDER BY nome";
        comando.Parameters.AddWithValue("@busca", $"%{pesquisa}%");
        await using var leitor = await comando.ExecuteReaderAsync();
        while (await leitor.ReadAsync()) itens.Add(new Cliente { Id = leitor.GetInt32(0), Nome = leitor.GetString(1), Cpf = leitor.GetString(2), Telefone = leitor.GetString(3), Email = leitor.GetString(4) });
        return itens;
    }

    /// <summary>Insere um cliente usando os dados validados pelo formulário.</summary>
    public async Task SalvarClienteAsync(Cliente cliente)
    {
        await using var conexao = ConexaoBanco.Criar(); await conexao.OpenAsync();
        await using var comando = conexao.CreateCommand();
        comando.CommandText = "INSERT INTO clientes(nome,cpf,telefone,email) VALUES(@nome,@cpf,@telefone,@email)";
        comando.Parameters.AddWithValue("@nome", cliente.Nome); comando.Parameters.AddWithValue("@cpf", cliente.Cpf);
        comando.Parameters.AddWithValue("@telefone", cliente.Telefone); comando.Parameters.AddWithValue("@email", cliente.Email);
        await comando.ExecuteNonQueryAsync();
    }

    /// <summary>Atualiza o cliente identificado por seu ID.</summary>
    public Task AtualizarClienteAsync(Cliente cliente) => ExecutarAsync(
        "UPDATE clientes SET nome=@nome,cpf=@cpf,telefone=@telefone,email=@email WHERE id=@id",
        ("@nome", cliente.Nome), ("@cpf", cliente.Cpf), ("@telefone", cliente.Telefone),
        ("@email", cliente.Email), ("@id", cliente.Id));

    /// <summary>Remove um cliente; vínculos são protegidos por chaves estrangeiras.</summary>
    public Task ExcluirClienteAsync(int id) => ExecutarAsync(
        "DELETE FROM clientes WHERE id=@id", ("@id", id));

    /// <summary>Lista pets e inclui o nome do tutor através da relação com clientes.</summary>
    public async Task<List<Pet>> ListarPetsAsync(string pesquisa = "")
    {
        var itens = new List<Pet>();
        await using var conexao = ConexaoBanco.Criar(); await conexao.OpenAsync();
        await using var comando = conexao.CreateCommand();
        comando.CommandText = "SELECT p.id,p.cliente_id,c.nome,p.nome,p.especie,COALESCE(p.raca,''),COALESCE(p.porte,''),p.nascimento,COALESCE(p.peso,0) FROM pets p JOIN clientes c ON c.id=p.cliente_id WHERE p.nome LIKE @busca OR c.nome LIKE @busca ORDER BY p.nome";
        comando.Parameters.AddWithValue("@busca", $"%{pesquisa}%");
        await using var leitor = await comando.ExecuteReaderAsync();
        while (await leitor.ReadAsync()) itens.Add(new Pet { Id = leitor.GetInt32(0), ClienteId = leitor.GetInt32(1), Tutor = leitor.GetString(2), Nome = leitor.GetString(3), Especie = leitor.GetString(4), Raca = leitor.GetString(5), Porte = leitor.GetString(6), Nascimento = leitor.IsDBNull(7) ? null : leitor.GetDateTime(7), Peso = leitor.GetDecimal(8) });
        return itens;
    }

    /// <summary>Insere um pet vinculado obrigatoriamente a um cliente.</summary>
    public async Task SalvarPetAsync(Pet pet)
    {
        await using var conexao = ConexaoBanco.Criar(); await conexao.OpenAsync();
        await using var comando = conexao.CreateCommand();
        comando.CommandText = "INSERT INTO pets(cliente_id,nome,especie,raca,porte,nascimento,peso) VALUES(@cliente,@nome,@especie,@raca,@porte,@nascimento,@peso)";
        comando.Parameters.AddWithValue("@cliente", pet.ClienteId); comando.Parameters.AddWithValue("@nome", pet.Nome);
        comando.Parameters.AddWithValue("@especie", pet.Especie); comando.Parameters.AddWithValue("@raca", pet.Raca); comando.Parameters.AddWithValue("@porte", pet.Porte);
        comando.Parameters.AddWithValue("@nascimento", pet.Nascimento); comando.Parameters.AddWithValue("@peso", pet.Peso);
        await comando.ExecuteNonQueryAsync();
    }
    /// <summary>Persiste os campos editáveis de um pet existente.</summary>
    public Task AtualizarPetAsync(Pet pet) => ExecutarAsync(
        "UPDATE pets SET cliente_id=@cliente,nome=@nome,especie=@especie,raca=@raca,porte=@porte,nascimento=@nascimento,peso=@peso WHERE id=@id",
        ("@cliente", pet.ClienteId), ("@nome", pet.Nome), ("@especie", pet.Especie),
        ("@raca", pet.Raca), ("@porte", pet.Porte), ("@nascimento", pet.Nascimento),
        ("@peso", pet.Peso), ("@id", pet.Id));

    /// <summary>Remove um pet; atendimentos relacionados são protegidos pelo banco.</summary>
    public Task ExcluirPetAsync(int id) =>
        ExecutarAsync("DELETE FROM pets WHERE id=@id", ("@id", id));

    /// <summary>Lista serviços ativos e inativos para manutenção.</summary>
    public async Task<List<Servico>> ListarServicosAsync()
    {
        var itens = new List<Servico>();
        await using var conexao = ConexaoBanco.Criar(); await conexao.OpenAsync();
        await using var comando = conexao.CreateCommand(); comando.CommandText = "SELECT id,nome,COALESCE(descricao,''),valor,duracao_minutos,ativo FROM servicos ORDER BY nome";
        await using var leitor = await comando.ExecuteReaderAsync();
        while (await leitor.ReadAsync()) itens.Add(new Servico { Id = leitor.GetInt32(0), Nome = leitor.GetString(1), Descricao = leitor.GetString(2), Valor = leitor.GetDecimal(3), DuracaoMinutos = leitor.GetInt32(4), Ativo = leitor.GetBoolean(5) });
        return itens;
    }

    /// <summary>Insere um serviço e sua configuração comercial.</summary>
    public async Task SalvarServicoAsync(Servico servico)
    {
        await using var conexao = ConexaoBanco.Criar(); await conexao.OpenAsync();
        await using var comando = conexao.CreateCommand(); comando.CommandText = "INSERT INTO servicos(nome,descricao,valor,duracao_minutos,ativo) VALUES(@nome,@descricao,@valor,@duracao,@ativo)";
        comando.Parameters.AddWithValue("@nome", servico.Nome); comando.Parameters.AddWithValue("@descricao", servico.Descricao); comando.Parameters.AddWithValue("@valor", servico.Valor); comando.Parameters.AddWithValue("@duracao", servico.DuracaoMinutos); comando.Parameters.AddWithValue("@ativo", servico.Ativo);
        await comando.ExecuteNonQueryAsync();
    }
    /// <summary>Atualiza os dados comerciais e a disponibilidade de um serviço.</summary>
    public Task AtualizarServicoAsync(Servico servico) => ExecutarAsync(
        "UPDATE servicos SET nome=@nome,descricao=@descricao,valor=@valor,duracao_minutos=@duracao,ativo=@ativo WHERE id=@id",
        ("@nome", servico.Nome), ("@descricao", servico.Descricao), ("@valor", servico.Valor),
        ("@duracao", servico.DuracaoMinutos), ("@ativo", servico.Ativo), ("@id", servico.Id));

    /// <summary>Remove um serviço quando ele não possui atendimentos vinculados.</summary>
    public Task ExcluirServicoAsync(int id) =>
        ExecutarAsync("DELETE FROM servicos WHERE id=@id", ("@id", id));

    /// <summary>Lista atendimentos juntando pet, tutor e serviço.</summary>
    public async Task<List<Atendimento>> ListarAtendimentosAsync()
    {
        var itens = new List<Atendimento>();
        await using var conexao = ConexaoBanco.Criar(); await conexao.OpenAsync();
        await using var comando = conexao.CreateCommand();
        comando.CommandText = "SELECT a.id,a.pet_id,a.servico_id,p.nome,c.nome,s.nome,a.data_hora,a.valor,a.status,COALESCE(a.observacoes,'') FROM atendimentos a JOIN pets p ON p.id=a.pet_id JOIN clientes c ON c.id=p.cliente_id JOIN servicos s ON s.id=a.servico_id ORDER BY a.data_hora DESC";
        await using var leitor = await comando.ExecuteReaderAsync();
        while (await leitor.ReadAsync()) itens.Add(new Atendimento { Id = leitor.GetInt32(0), PetId = leitor.GetInt32(1), ServicoId = leitor.GetInt32(2), Pet = leitor.GetString(3), Tutor = leitor.GetString(4), Servico = leitor.GetString(5), DataHora = leitor.GetDateTime(6), Valor = leitor.GetDecimal(7), Status = leitor.GetString(8), Observacoes = leitor.GetString(9) });
        return itens;
    }

    /// <summary>Cria um agendamento com o valor vigente do serviço selecionado.</summary>
    public async Task SalvarAtendimentoAsync(Atendimento atendimento)
    {
        await using var conexao = ConexaoBanco.Criar(); await conexao.OpenAsync();
        await using var comando = conexao.CreateCommand(); comando.CommandText = "INSERT INTO atendimentos(pet_id,servico_id,data_hora,valor,status,observacoes) VALUES(@pet,@servico,@data,@valor,@status,@observacoes)";
        comando.Parameters.AddWithValue("@pet", atendimento.PetId); comando.Parameters.AddWithValue("@servico", atendimento.ServicoId); comando.Parameters.AddWithValue("@data", atendimento.DataHora); comando.Parameters.AddWithValue("@valor", atendimento.Valor); comando.Parameters.AddWithValue("@status", atendimento.Status); comando.Parameters.AddWithValue("@observacoes", atendimento.Observacoes);
        await comando.ExecuteNonQueryAsync();
    }
    /// <summary>Atualiza os campos operacionais de um atendimento existente.</summary>
    public Task AtualizarAtendimentoAsync(Atendimento atendimento) => ExecutarAsync(
        "UPDATE atendimentos SET data_hora=@data,status=@status,observacoes=@obs WHERE id=@id",
        ("@data", atendimento.DataHora), ("@status", atendimento.Status),
        ("@obs", atendimento.Observacoes), ("@id", atendimento.Id));

    /// <summary>Remove o atendimento identificado por seu ID.</summary>
    public Task ExcluirAtendimentoAsync(int id) =>
        ExecutarAsync("DELETE FROM atendimentos WHERE id=@id", ("@id", id));

    /// <summary>Lista produtos ativos e permite pesquisa por nome ou código.</summary>
    public async Task<List<Produto>> ListarProdutosAsync(string pesquisa = "")
    {
        var itens = new List<Produto>();
        await using var conexao = ConexaoBanco.Criar();
        await conexao.OpenAsync();
        await using var comando = conexao.CreateCommand();
        comando.CommandText = "SELECT id,codigo,nome,COALESCE(categoria,''),preco,estoque,estoque_minimo FROM produtos WHERE ativo=1 AND (nome LIKE @busca OR codigo LIKE @busca) ORDER BY nome";
        comando.Parameters.AddWithValue("@busca", $"%{pesquisa}%");
        await using var leitor = await comando.ExecuteReaderAsync();
        while (await leitor.ReadAsync())
        {
            itens.Add(new Produto
            {
                Id = leitor.GetInt32(0),
                Codigo = leitor.GetString(1),
                Nome = leitor.GetString(2),
                Categoria = leitor.GetString(3),
                Preco = leitor.GetDecimal(4),
                Estoque = leitor.GetInt32(5),
                EstoqueMinimo = leitor.GetInt32(6)
            });
        }
        return itens;
    }

    /// <summary>Insere um produto disponível para estoque e vendas.</summary>
    public async Task SalvarProdutoAsync(Produto produto)
    {
        await using var conexao = ConexaoBanco.Criar(); await conexao.OpenAsync(); await using var comando = conexao.CreateCommand();
        comando.CommandText = "INSERT INTO produtos(codigo,nome,categoria,preco,estoque,estoque_minimo,ativo) VALUES(@codigo,@nome,@categoria,@preco,@estoque,@minimo,1)";
        comando.Parameters.AddWithValue("@codigo", produto.Codigo); comando.Parameters.AddWithValue("@nome", produto.Nome); comando.Parameters.AddWithValue("@categoria", produto.Categoria); comando.Parameters.AddWithValue("@preco", produto.Preco); comando.Parameters.AddWithValue("@estoque", produto.Estoque); comando.Parameters.AddWithValue("@minimo", produto.EstoqueMinimo);
        await comando.ExecuteNonQueryAsync();
    }
    /// <summary>Atualiza cadastro, preço e parâmetros de estoque de um produto.</summary>
    public Task AtualizarProdutoAsync(Produto produto) => ExecutarAsync(
        "UPDATE produtos SET codigo=@codigo,nome=@nome,categoria=@categoria,preco=@preco,estoque=@estoque,estoque_minimo=@minimo WHERE id=@id",
        ("@codigo", produto.Codigo), ("@nome", produto.Nome), ("@categoria", produto.Categoria),
        ("@preco", produto.Preco), ("@estoque", produto.Estoque),
        ("@minimo", produto.EstoqueMinimo), ("@id", produto.Id));

    /// <summary>Remove um produto quando não existem itens de pedido vinculados.</summary>
    public Task ExcluirProdutoAsync(int id) =>
        ExecutarAsync("DELETE FROM produtos WHERE id=@id", ("@id", id));

    /// <summary>Executa comandos simples de escrita com parâmetros uniformes.</summary>
    private static async Task ExecutarAsync(
        string sql,
        params (string Nome, object? Valor)[] parametros)
    {
        await using var conexao = ConexaoBanco.Criar();
        await conexao.OpenAsync();
        await using var comando = conexao.CreateCommand();
        comando.CommandText = sql;
        foreach (var parametro in parametros)
            comando.Parameters.AddWithValue(parametro.Nome, parametro.Valor);
        await comando.ExecuteNonQueryAsync();
    }

    /// <summary>Retorna o resumo usado pela tela de histórico de pedidos.</summary>
    public async Task<List<PedidoResumo>> ListarPedidosAsync()
    {
        var itens = new List<PedidoResumo>();
        await using var conexao = ConexaoBanco.Criar();
        await conexao.OpenAsync();
        await using var comando = conexao.CreateCommand();
        comando.CommandText = "SELECT p.id,p.numero,COALESCE(c.nome,'Consumidor final'),p.data_hora,p.total,p.status,COALESCE(p.forma_pagamento,'') FROM pedidos p LEFT JOIN clientes c ON c.id=p.cliente_id ORDER BY p.data_hora DESC";
        await using var leitor = await comando.ExecuteReaderAsync();
        while (await leitor.ReadAsync())
        {
            itens.Add(new PedidoResumo
            {
                Id = leitor.GetInt32(0),
                Numero = leitor.GetString(1),
                Cliente = leitor.GetString(2),
                Data = leitor.GetDateTime(3),
                Total = leitor.GetDecimal(4),
                Status = leitor.GetString(5),
                Pagamento = leitor.GetString(6)
            });
        }
        return itens;
    }

    /// <summary>
    /// Registra pedido, itens e baixa de estoque em uma transação. Qualquer
    /// falha desfaz a operação inteira para manter venda e estoque consistentes.
    /// </summary>
    public async Task RegistrarVendaAsync(int? clienteId, IReadOnlyCollection<(Produto Produto, int Quantidade)> itens, string pagamento, decimal descontoPercentual = 0)
    {
        if (itens.Count == 0)
            throw new InvalidOperationException("A venda precisa possuir ao menos um item.");

        await using var conexao = ConexaoBanco.Criar();
        await conexao.OpenAsync();
        await using var transacao = await conexao.BeginTransactionAsync();

        // A verificação e a baixa do estoque participam da mesma transação da venda.
        await using (var verificarCaixa = conexao.CreateCommand())
        {
            verificarCaixa.Transaction = transacao;
            verificarCaixa.CommandText = "SELECT EXISTS(SELECT 1 FROM caixas WHERE status='Aberto' AND fechado_em IS NULL)";
            if (Convert.ToInt32(await verificarCaixa.ExecuteScalarAsync()) != 1)
                throw new InvalidOperationException("Abra o caixa antes de finalizar uma venda.");
        }

        var subtotal = itens.Sum(item => item.Produto.Preco * item.Quantidade);
        var desconto = Math.Clamp(descontoPercentual, 0, 100);
        var total = subtotal - subtotal * desconto / 100;
        var numero = $"PDV-{DateTime.Now:yyyyMMddHHmmssfff}";

        await using var inserirPedido = conexao.CreateCommand();
        inserirPedido.Transaction = transacao;
        inserirPedido.CommandText = "INSERT INTO pedidos(numero,cliente_id,total,status,forma_pagamento) VALUES(@numero,@cliente,@total,'Concluído',@pagamento); SELECT LAST_INSERT_ID();";
        inserirPedido.Parameters.AddWithValue("@numero", numero);
        inserirPedido.Parameters.AddWithValue("@cliente", clienteId);
        inserirPedido.Parameters.AddWithValue("@total", total);
        inserirPedido.Parameters.AddWithValue("@pagamento", pagamento);
        var pedidoId = Convert.ToInt32(await inserirPedido.ExecuteScalarAsync());

        foreach (var item in itens)
        {
            if (item.Quantidade <= 0)
                throw new InvalidOperationException($"A quantidade de {item.Produto.Nome} deve ser maior que zero.");

            await using var inserirItem = conexao.CreateCommand();
            inserirItem.Transaction = transacao;
            inserirItem.CommandText = "INSERT INTO pedido_itens(pedido_id,produto_id,quantidade,valor_unitario) VALUES(@pedido,@produto,@qtd,@valor); UPDATE produtos SET estoque=estoque-@qtd WHERE id=@produto AND estoque>=@qtd";
            inserirItem.Parameters.AddWithValue("@pedido", pedidoId);
            inserirItem.Parameters.AddWithValue("@produto", item.Produto.Id);
            inserirItem.Parameters.AddWithValue("@qtd", item.Quantidade);
            inserirItem.Parameters.AddWithValue("@valor", item.Produto.Preco);
            if (await inserirItem.ExecuteNonQueryAsync() < 2)
                throw new InvalidOperationException($"Estoque insuficiente para {item.Produto.Nome}.");
        }

        await transacao.CommitAsync();
    }
}
