using MySqlConnector;

namespace PetShop_App.Dados;

public static class ConexaoBanco
{
    public static MySqlConnection Criar(bool incluirBanco = true)
    {
        var construtor = new MySqlConnectionStringBuilder
        {
            Server = ConfiguracaoBanco.Servidor,
            Port = ConfiguracaoBanco.Porta,
            UserID = ConfiguracaoBanco.Usuario,
            Password = ConfiguracaoBanco.Senha,
            Database = incluirBanco ? ConfiguracaoBanco.Banco : "",
            CharacterSet = "utf8mb4",
            ConnectionTimeout = 3,
            DefaultCommandTimeout = 10
        };
        return new MySqlConnection(construtor.ConnectionString);
    }
}
