using System.ComponentModel;

namespace PetShop_App.Componentes;

internal static class AmbienteDesign
{
    public static bool EstaAtivo(Control controle)
    {
        if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return true;
        for (Control? atual = controle; atual != null; atual = atual.Parent)
            if (atual.Site?.DesignMode == true) return true;
        return false;
    }
}
