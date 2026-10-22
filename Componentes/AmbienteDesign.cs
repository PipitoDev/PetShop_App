using System.ComponentModel;

namespace PetShop_App.Componentes;

/// <summary>
/// Detecta se um controle está aberto no Designer. Evita consultas ao banco e
/// outras ações de execução enquanto o Visual Studio apenas renderiza a tela.
/// </summary>
internal static class AmbienteDesign
{
    /// <summary>Verifica o modo de design no controle e em toda a cadeia de pais.</summary>
    public static bool EstaAtivo(Control controle)
    {
        if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return true;
        for (Control? atual = controle; atual != null; atual = atual.Parent)
            if (atual.Site?.DesignMode == true) return true;
        return false;
    }
}
