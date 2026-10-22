from pathlib import Path
p=Path('Componentes/FormularioCadastro.cs');s=p.read_text(encoding='utf-8-sig');start=s.index('    private readonly');end=s.index('    public TextBox Texto')
s=s[:start]+'''    public FormularioCadastro()
    {
        InitializeComponent();
    }

    public FormularioCadastro(string titulo, int altura = 590) : this()
    {
        Text = titulo;
        Height = altura;
    }

'''+s[end:]
s=s.replace('public sealed class FormularioCadastro','public sealed partial class FormularioCadastro').replace('namespace PetShop_App.Componentes;','namespace PetShop_App.Componentes\n{')+'\n}\n';p.write_text(s,encoding='utf-8')
