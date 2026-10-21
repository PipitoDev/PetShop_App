using PetShop_App.Componentes;using PetShop_App.Dados;using PetShop_App.Modelos;
namespace PetShop_App.Telas.Clientes;
public partial class PaginaClientes:UserControl
{
    public PaginaClientes(){InitializeComponent();Load+=async(_,_)=>await CarregarAsync();txtPesquisa.TextChanged+=async(_,_)=>await CarregarAsync();btnNovo.Click+=async(_,_)=>await NovoAsync();}
    private async Task CarregarAsync(){try{gradeClientes.DataSource=(await new RepositorioPetShop().ListarClientesAsync(txtPesquisa.Text)).Select(x=>new{x.Id,x.Nome,x.Cpf,x.Telefone,x.Email}).ToList();if(gradeClientes.Columns["Id"] is not null)gradeClientes.Columns["Id"].Visible=false;}catch(Exception ex){MessageBox.Show("Não foi possível acessar os clientes.\n\n"+ex.Message,"PetShop Central");}}
    private async Task NovoAsync(){using var f=new FormularioCadastro("Cadastrar cliente",480);var nome=f.Texto("Nome completo *");var cpf=f.Texto("CPF");var tel=f.Texto("Telefone");var email=f.Texto("E-mail");if(f.ShowDialog(this)!=DialogResult.OK)return;if(string.IsNullOrWhiteSpace(nome.Text)){MessageBox.Show("Informe o nome do cliente.");return;}await new RepositorioPetShop().SalvarClienteAsync(new Cliente{Nome=nome.Text.Trim(),Cpf=cpf.Text.Trim(),Telefone=tel.Text.Trim(),Email=email.Text.Trim()});await CarregarAsync();}
}
