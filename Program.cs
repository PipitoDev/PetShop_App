using PetShop_App.Componentes;

namespace PetShop_App
{
    /// <summary>
    /// Ponto de entrada do aplicativo. Inicializa a infraestrutura do WinForms
    /// e mantém o ciclo de mensagens aberto a partir da tela de login.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Aplica configurações padrão do .NET para DPI, fontes e renderização visual.
            ApplicationConfiguration.Initialize();
            // Login é a janela raiz; ao ser fechada, a aplicação é encerrada.
            Application.Run(new Login());
        }
    }
}
