using MySqlConnector;
using PetShop_App.Modelos;

namespace PetShop_App.Dados;

public sealed class RepositorioPetShop
{
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

    public async Task<bool> CaixaEstaAbertoAsync()
    {
        await using var conexao = ConexaoBanco.Criar(); await conexao.OpenAsync();
        await using var comando = conexao.CreateCommand();
        comando.CommandText = "SELECT EXISTS(SELECT 1 FROM caixas WHERE status='Aberto' AND fechado_em IS NULL)";
        return Convert.ToInt32(await comando.ExecuteScalarAsync()) == 1;
    }

    public async Task AbrirCaixaAsync(decimal saldoInicial)
    {
        if (await CaixaEstaAbertoAsync()) throw new InvalidOperationException("Já existe um caixa aberto.");
        await ExecutarAsync("INSERT INTO caixas(aberto_em,saldo_inicial,status) VALUES(NOW(),@saldo,'Aberto')", ("@saldo", saldoInicial));
    }

    public async Task FecharCaixaAsync(decimal saldoFinal)
    {
        if (!await CaixaEstaAbertoAsync()) throw new InvalidOperationException("O caixa já está fechado.");
        await ExecutarAsync("UPDATE caixas SET fechado_em=NOW(),saldo_final=@saldo,status='Fechado' WHERE status='Aberto' AND fechado_em IS NULL", ("@saldo", saldoFinal));
    }

    public async Task<List<Cliente>> ListarClientesAsync(string pesquisa = "")
    {
        var itens = new List<Cliente>();
        await using var conexao = ConexaoBanco.Criar(); await conexao.OpenAsync();
        await using var comando = conexao.CreateCommand();
        comando.CommandText = "SELECT id,nome,COALESCE(cpf,''),COALESCE(telefone,''),COALESCE(email,'') FROM clientes WHERE nome LIKE @busca OR telefone LIKE @busca ORDER BY nome";
        comando.Parameters.AddWithValue("@busca", $"%{pesquisa}%");
        await using var leitor = await comando.ExecuteReaderAsync();
        while (await leitor.ReadAsync()) itens.Add(new Cliente { Id=leitor.GetInt32(0), Nome=leitor.GetString(1), Cpf=leitor.GetString(2), Telefone=leitor.GetString(3), Email=leitor.GetString(4) });
        return itens;
    }

    public async Task SalvarClienteAsync(Cliente cliente)
    {
        await using var conexao = ConexaoBanco.Criar(); await conexao.OpenAsync();
        await using var comando = conexao.CreateCommand();
        comando.CommandText = "INSERT INTO clientes(nome,cpf,telefone,email) VALUES(@nome,@cpf,@telefone,@email)";
        comando.Parameters.AddWithValue("@nome", cliente.Nome); comando.Parameters.AddWithValue("@cpf", cliente.Cpf);
        comando.Parameters.AddWithValue("@telefone", cliente.Telefone); comando.Parameters.AddWithValue("@email", cliente.Email);
        await comando.ExecuteNonQueryAsync();
    }

    public async Task<List<Pet>> ListarPetsAsync(string pesquisa = "")
    {
        var itens = new List<Pet>();
        await using var conexao = ConexaoBanco.Criar(); await conexao.OpenAsync();
        await using var comando = conexao.CreateCommand();
        comando.CommandText = "SELECT p.id,p.cliente_id,c.nome,p.nome,p.especie,COALESCE(p.raca,''),COALESCE(p.porte,''),p.nascimento,COALESCE(p.peso,0) FROM pets p JOIN clientes c ON c.id=p.cliente_id WHERE p.nome LIKE @busca OR c.nome LIKE @busca ORDER BY p.nome";
        comando.Parameters.AddWithValue("@busca", $"%{pesquisa}%");
        await using var leitor = await comando.ExecuteReaderAsync();
        while (await leitor.ReadAsync()) itens.Add(new Pet { Id=leitor.GetInt32(0), ClienteId=leitor.GetInt32(1), Tutor=leitor.GetString(2), Nome=leitor.GetString(3), Especie=leitor.GetString(4), Raca=leitor.GetString(5), Porte=leitor.GetString(6), Nascimento=leitor.IsDBNull(7)?null:leitor.GetDateTime(7), Peso=leitor.GetDecimal(8) });
        return itens;
    }

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
    public async Task AtualizarPetAsync(Pet p){await ExecutarAsync("UPDATE pets SET cliente_id=@cliente,nome=@nome,especie=@especie,raca=@raca,porte=@porte,peso=@peso WHERE id=@id",("@cliente",p.ClienteId),("@nome",p.Nome),("@especie",p.Especie),("@raca",p.Raca),("@porte",p.Porte),("@peso",p.Peso),("@id",p.Id));}
    public async Task ExcluirPetAsync(int id)=>await ExecutarAsync("DELETE FROM pets WHERE id=@id",("@id",id));

    public async Task<List<Servico>> ListarServicosAsync()
    {
        var itens = new List<Servico>();
        await using var conexao = ConexaoBanco.Criar(); await conexao.OpenAsync();
        await using var comando = conexao.CreateCommand(); comando.CommandText = "SELECT id,nome,COALESCE(descricao,''),valor,duracao_minutos,ativo FROM servicos ORDER BY nome";
        await using var leitor = await comando.ExecuteReaderAsync();
        while (await leitor.ReadAsync()) itens.Add(new Servico { Id=leitor.GetInt32(0), Nome=leitor.GetString(1), Descricao=leitor.GetString(2), Valor=leitor.GetDecimal(3), DuracaoMinutos=leitor.GetInt32(4), Ativo=leitor.GetBoolean(5) });
        return itens;
    }

    public async Task SalvarServicoAsync(Servico servico)
    {
        await using var conexao = ConexaoBanco.Criar(); await conexao.OpenAsync();
        await using var comando = conexao.CreateCommand(); comando.CommandText = "INSERT INTO servicos(nome,descricao,valor,duracao_minutos,ativo) VALUES(@nome,@descricao,@valor,@duracao,@ativo)";
        comando.Parameters.AddWithValue("@nome", servico.Nome); comando.Parameters.AddWithValue("@descricao", servico.Descricao); comando.Parameters.AddWithValue("@valor", servico.Valor); comando.Parameters.AddWithValue("@duracao", servico.DuracaoMinutos); comando.Parameters.AddWithValue("@ativo", servico.Ativo);
        await comando.ExecuteNonQueryAsync();
    }
    public async Task AtualizarServicoAsync(Servico s){await ExecutarAsync("UPDATE servicos SET nome=@nome,descricao=@descricao,valor=@valor,duracao_minutos=@duracao,ativo=@ativo WHERE id=@id",("@nome",s.Nome),("@descricao",s.Descricao),("@valor",s.Valor),("@duracao",s.DuracaoMinutos),("@ativo",s.Ativo),("@id",s.Id));}
    public async Task ExcluirServicoAsync(int id)=>await ExecutarAsync("DELETE FROM servicos WHERE id=@id",("@id",id));

    public async Task<List<Atendimento>> ListarAtendimentosAsync()
    {
        var itens = new List<Atendimento>();
        await using var conexao = ConexaoBanco.Criar(); await conexao.OpenAsync();
        await using var comando = conexao.CreateCommand();
        comando.CommandText = "SELECT a.id,a.pet_id,a.servico_id,p.nome,c.nome,s.nome,a.data_hora,a.valor,a.status,COALESCE(a.observacoes,'') FROM atendimentos a JOIN pets p ON p.id=a.pet_id JOIN clientes c ON c.id=p.cliente_id JOIN servicos s ON s.id=a.servico_id ORDER BY a.data_hora DESC";
        await using var leitor = await comando.ExecuteReaderAsync();
        while (await leitor.ReadAsync()) itens.Add(new Atendimento { Id=leitor.GetInt32(0), PetId=leitor.GetInt32(1), ServicoId=leitor.GetInt32(2), Pet=leitor.GetString(3), Tutor=leitor.GetString(4), Servico=leitor.GetString(5), DataHora=leitor.GetDateTime(6), Valor=leitor.GetDecimal(7), Status=leitor.GetString(8), Observacoes=leitor.GetString(9) });
        return itens;
    }

    public async Task SalvarAtendimentoAsync(Atendimento atendimento)
    {
        await using var conexao = ConexaoBanco.Criar(); await conexao.OpenAsync();
        await using var comando = conexao.CreateCommand(); comando.CommandText = "INSERT INTO atendimentos(pet_id,servico_id,data_hora,valor,status,observacoes) VALUES(@pet,@servico,@data,@valor,@status,@observacoes)";
        comando.Parameters.AddWithValue("@pet", atendimento.PetId); comando.Parameters.AddWithValue("@servico", atendimento.ServicoId); comando.Parameters.AddWithValue("@data", atendimento.DataHora); comando.Parameters.AddWithValue("@valor", atendimento.Valor); comando.Parameters.AddWithValue("@status", atendimento.Status); comando.Parameters.AddWithValue("@observacoes", atendimento.Observacoes);
        await comando.ExecuteNonQueryAsync();
    }
    public async Task AtualizarAtendimentoAsync(Atendimento a){await ExecutarAsync("UPDATE atendimentos SET data_hora=@data,status=@status,observacoes=@obs WHERE id=@id",("@data",a.DataHora),("@status",a.Status),("@obs",a.Observacoes),("@id",a.Id));}
    public async Task ExcluirAtendimentoAsync(int id)=>await ExecutarAsync("DELETE FROM atendimentos WHERE id=@id",("@id",id));

    public async Task<List<Produto>> ListarProdutosAsync(string pesquisa = "")
    {
        var itens = new List<Produto>(); await using var conexao=ConexaoBanco.Criar(); await conexao.OpenAsync(); await using var comando=conexao.CreateCommand();
        comando.CommandText="SELECT id,codigo,nome,COALESCE(categoria,''),preco,estoque,estoque_minimo FROM produtos WHERE ativo=1 AND (nome LIKE @busca OR codigo LIKE @busca) ORDER BY nome"; comando.Parameters.AddWithValue("@busca",$"%{pesquisa}%");
        await using var leitor=await comando.ExecuteReaderAsync(); while(await leitor.ReadAsync()) itens.Add(new Produto{Id=leitor.GetInt32(0),Codigo=leitor.GetString(1),Nome=leitor.GetString(2),Categoria=leitor.GetString(3),Preco=leitor.GetDecimal(4),Estoque=leitor.GetInt32(5),EstoqueMinimo=leitor.GetInt32(6)}); return itens;
    }

    public async Task SalvarProdutoAsync(Produto produto)
    {
        await using var conexao=ConexaoBanco.Criar(); await conexao.OpenAsync(); await using var comando=conexao.CreateCommand();
        comando.CommandText="INSERT INTO produtos(codigo,nome,categoria,preco,estoque,estoque_minimo,ativo) VALUES(@codigo,@nome,@categoria,@preco,@estoque,@minimo,1)";
        comando.Parameters.AddWithValue("@codigo",produto.Codigo); comando.Parameters.AddWithValue("@nome",produto.Nome); comando.Parameters.AddWithValue("@categoria",produto.Categoria); comando.Parameters.AddWithValue("@preco",produto.Preco); comando.Parameters.AddWithValue("@estoque",produto.Estoque); comando.Parameters.AddWithValue("@minimo",produto.EstoqueMinimo);
        await comando.ExecuteNonQueryAsync();
    }
    public async Task AtualizarProdutoAsync(Produto p){await ExecutarAsync("UPDATE produtos SET codigo=@codigo,nome=@nome,categoria=@categoria,preco=@preco,estoque=@estoque,estoque_minimo=@minimo WHERE id=@id",("@codigo",p.Codigo),("@nome",p.Nome),("@categoria",p.Categoria),("@preco",p.Preco),("@estoque",p.Estoque),("@minimo",p.EstoqueMinimo),("@id",p.Id));}
    public async Task ExcluirProdutoAsync(int id)=>await ExecutarAsync("DELETE FROM produtos WHERE id=@id",("@id",id));

    private static async Task ExecutarAsync(string sql,params (string Nome,object? Valor)[] parametros){await using var conexao=ConexaoBanco.Criar();await conexao.OpenAsync();await using var comando=conexao.CreateCommand();comando.CommandText=sql;foreach(var p in parametros)comando.Parameters.AddWithValue(p.Nome,p.Valor);await comando.ExecuteNonQueryAsync();}

    public async Task<List<PedidoResumo>> ListarPedidosAsync()
    {
        var itens=new List<PedidoResumo>(); await using var conexao=ConexaoBanco.Criar(); await conexao.OpenAsync(); await using var comando=conexao.CreateCommand();
        comando.CommandText="SELECT p.id,p.numero,COALESCE(c.nome,'Consumidor final'),p.data_hora,p.total,p.status,COALESCE(p.forma_pagamento,'') FROM pedidos p LEFT JOIN clientes c ON c.id=p.cliente_id ORDER BY p.data_hora DESC";
        await using var leitor=await comando.ExecuteReaderAsync(); while(await leitor.ReadAsync()) itens.Add(new PedidoResumo{Id=leitor.GetInt32(0),Numero=leitor.GetString(1),Cliente=leitor.GetString(2),Data=leitor.GetDateTime(3),Total=leitor.GetDecimal(4),Status=leitor.GetString(5),Pagamento=leitor.GetString(6)}); return itens;
    }

    public async Task RegistrarVendaAsync(int? clienteId, IReadOnlyCollection<(Produto Produto,int Quantidade)> itens, string pagamento, decimal descontoPercentual = 0)
    {
        await using var conexao=ConexaoBanco.Criar(); await conexao.OpenAsync(); await using var transacao=await conexao.BeginTransactionAsync();
        await using(var verificar=conexao.CreateCommand()){verificar.Transaction=transacao;verificar.CommandText="SELECT EXISTS(SELECT 1 FROM caixas WHERE status='Aberto' AND fechado_em IS NULL)";if(Convert.ToInt32(await verificar.ExecuteScalarAsync())!=1)throw new InvalidOperationException("Abra o caixa antes de finalizar uma venda.");}
        var subtotal=itens.Sum(x=>x.Produto.Preco*x.Quantidade); var total=subtotal-(subtotal*Math.Clamp(descontoPercentual,0,100)/100); var numero=$"PDV-{DateTime.Now:yyyyMMddHHmmss}";
        await using var pedido=conexao.CreateCommand(); pedido.Transaction=transacao; pedido.CommandText="INSERT INTO pedidos(numero,cliente_id,total,status,forma_pagamento) VALUES(@numero,@cliente,@total,'Concluído',@pagamento); SELECT LAST_INSERT_ID();"; pedido.Parameters.AddWithValue("@numero",numero); pedido.Parameters.AddWithValue("@cliente",clienteId); pedido.Parameters.AddWithValue("@total",total); pedido.Parameters.AddWithValue("@pagamento",pagamento); var pedidoId=Convert.ToInt32(await pedido.ExecuteScalarAsync());
        foreach(var item in itens){await using var cmd=conexao.CreateCommand();cmd.Transaction=transacao;cmd.CommandText="INSERT INTO pedido_itens(pedido_id,produto_id,quantidade,valor_unitario) VALUES(@pedido,@produto,@qtd,@valor); UPDATE produtos SET estoque=estoque-@qtd WHERE id=@produto AND estoque>=@qtd";cmd.Parameters.AddWithValue("@pedido",pedidoId);cmd.Parameters.AddWithValue("@produto",item.Produto.Id);cmd.Parameters.AddWithValue("@qtd",item.Quantidade);cmd.Parameters.AddWithValue("@valor",item.Produto.Preco);if(await cmd.ExecuteNonQueryAsync()<2)throw new InvalidOperationException($"Estoque insuficiente para {item.Produto.Nome}.");}
        await transacao.CommitAsync();
    }
}
