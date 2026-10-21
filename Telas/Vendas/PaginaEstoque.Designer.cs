namespace PetShop_App.Telas.Vendas;
partial class PaginaEstoque
{
 private void InitializeComponent(){lblTitulo=new Label();lblResumo=new Label();txtPesquisa=new TextBox();btnNovoProduto=new Button();gradeEstoque=new DataGridView();((System.ComponentModel.ISupportInitialize)gradeEstoque).BeginInit();SuspendLayout();
 lblTitulo.AutoSize=true;lblTitulo.Font=new Font("Segoe UI",22F,FontStyle.Bold);lblTitulo.Location=new Point(0,4);lblTitulo.Text="Estoque";
 lblResumo.AutoSize=true;lblResumo.ForeColor=Color.FromArgb(100,116,139);lblResumo.Location=new Point(0,48);lblResumo.Text="Produtos e alertas de reposição";
 txtPesquisa.Location=new Point(0,82);txtPesquisa.PlaceholderText="Código ou nome do produto";txtPesquisa.Size=new Size(420,23);
 btnNovoProduto.Anchor=AnchorStyles.Top|AnchorStyles.Right;btnNovoProduto.BackColor=Color.FromArgb(255,128,0);btnNovoProduto.Cursor=Cursors.Hand;btnNovoProduto.FlatAppearance.BorderSize=0;btnNovoProduto.FlatStyle=FlatStyle.Flat;btnNovoProduto.Font=new Font("Segoe UI",10F,FontStyle.Bold);btnNovoProduto.ForeColor=Color.White;btnNovoProduto.Location=new Point(810,8);btnNovoProduto.Name="btnNovoProduto";btnNovoProduto.Size=new Size(170,40);btnNovoProduto.Text="+ Cadastrar produto";btnNovoProduto.UseVisualStyleBackColor=false;
 gradeEstoque.AllowUserToAddRows=false;gradeEstoque.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;gradeEstoque.BackgroundColor=Color.White;gradeEstoque.BorderStyle=BorderStyle.None;gradeEstoque.Location=new Point(0,125);gradeEstoque.Anchor=AnchorStyles.Top|AnchorStyles.Bottom|AnchorStyles.Left|AnchorStyles.Right;gradeEstoque.Size=new Size(1000,575);gradeEstoque.ReadOnly=true;gradeEstoque.RowHeadersVisible=false;
 BackColor=Color.FromArgb(241,245,249);Controls.AddRange([lblTitulo,lblResumo,txtPesquisa,btnNovoProduto,gradeEstoque]);Name="PaginaEstoque";Size=new Size(1000,700);((System.ComponentModel.ISupportInitialize)gradeEstoque).EndInit();ResumeLayout(false);PerformLayout();}
 private Label lblTitulo=null!,lblResumo=null!;private TextBox txtPesquisa=null!;private Button btnNovoProduto=null!;private DataGridView gradeEstoque=null!;
}
