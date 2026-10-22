using MySqlConnector;

namespace PetShop_App.Dados;

/// <summary>
/// Fábrica de conexões MySQL usada pela camada de dados. A conexão é devolvida
/// fechada para que cada operação controle seu ciclo de vida com await using.
/// </summary>
public static class ConexaoBanco
{
    /// <summary>
    /// Cria uma conexão configurada. A opção sem banco é usada somente durante
    /// a criação inicial do schema em <see cref="InicializadorBanco"/>.
    /// </summary>
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
