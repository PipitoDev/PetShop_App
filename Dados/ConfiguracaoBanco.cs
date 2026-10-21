namespace PetShop_App.Dados;

public static class ConfiguracaoBanco
{
    // Padrões do Laragon: MySQL local, porta 3306, usuário root e senha vazia.
    public static string Servidor => Environment.GetEnvironmentVariable("PETSHOP_DB_SERVIDOR") ?? "127.0.0.1";
    public static uint Porta => uint.TryParse(Environment.GetEnvironmentVariable("PETSHOP_DB_PORTA"), out var porta) ? porta : 3306;
    public static string Banco => Environment.GetEnvironmentVariable("PETSHOP_DB_NOME") ?? "petshop_central";
    public static string Usuario => Environment.GetEnvironmentVariable("PETSHOP_DB_USUARIO") ?? "root";
    public static string Senha => Environment.GetEnvironmentVariable("PETSHOP_DB_SENHA") ?? "root";
}
