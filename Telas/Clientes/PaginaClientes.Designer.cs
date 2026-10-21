namespace PetShop_App.Telas.Clientes;
partial class PaginaClientes
{
    private System.ComponentModel.IContainer? components;protected override void Dispose(bool disposing){if(disposing)components?.Dispose();base.Dispose(disposing);}
    private void InitializeComponent(){pnlCabecalho=new Panel();lblTitulo=new Label();lblSubtitulo=new Label();txtPesquisa=new TextBox();btnNovo=new Button();gradeClientes=new DataGridView();pnlCabecalho.SuspendLayout();((System.ComponentModel.ISupportInitialize)gradeClientes).BeginInit();SuspendLayout();
        pnlCabecalho.Controls.Add(btnNovo);pnlCabecalho.Controls.Add(txtPesquisa);pnlCabecalho.Controls.Add(lblSubtitulo);pnlCabecalho.Controls.Add(lblTitulo);pnlCabecalho.Dock=DockStyle.Top;pnlCabecalho.Height=125;
        lblTitulo.AutoSize=true;lblTitulo.Font=new Font("Segoe UI",22F,FontStyle.Bold);lblTitulo.ForeColor=Color.FromArgb(15,23,42);lblTitulo.Location=new Point(0,4);lblTitulo.Text="Clientes";
        lblSubtitulo.AutoSize=true;lblSubtitulo.ForeColor=Color.FromArgb(100,116,139);lblSubtitulo.Location=new Point(0,46);lblSubtitulo.Text="Cadastre tutores e mantenha os dados de contato organizados.";
        txtPesquisa.Location=new Point(0,82);txtPesquisa.Name="txtPesquisa";txtPesquisa.PlaceholderText="Nome ou telefone do cliente";txtPesquisa.Size=new Size(420,23);
        btnNovo.Anchor=AnchorStyles.Top|AnchorStyles.Right;btnNovo.BackColor=Color.FromArgb(255,128,0);btnNovo.FlatStyle=FlatStyle.Flat;btnNovo.ForeColor=Color.White;btnNovo.Font=new Font("Segoe UI",10F,FontStyle.Bold);btnNovo.Location=new Point(810,8);btnNovo.Size=new Size(170,40);btnNovo.Text="+ Cadastrar cliente";btnNovo.UseVisualStyleBackColor=false;
        gradeClientes.AllowUserToAddRows=false;gradeClientes.AllowUserToDeleteRows=false;gradeClientes.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;gradeClientes.BackgroundColor=Color.White;gradeClientes.BorderStyle=BorderStyle.None;gradeClientes.Dock=DockStyle.Fill;gradeClientes.Location=new Point(0,125);gradeClientes.ReadOnly=true;gradeClientes.RowHeadersVisible=false;gradeClientes.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
        AutoScaleDimensions=new SizeF(7F,15F);AutoScaleMode=AutoScaleMode.Font;BackColor=Color.FromArgb(241,245,249);Controls.Add(gradeClientes);Controls.Add(pnlCabecalho);Name="PaginaClientes";Size=new Size(1000,700);pnlCabecalho.ResumeLayout(false);pnlCabecalho.PerformLayout();((System.ComponentModel.ISupportInitialize)gradeClientes).EndInit();ResumeLayout(false);}
    private Panel pnlCabecalho=null!;private Label lblTitulo=null!;private Label lblSubtitulo=null!;private TextBox txtPesquisa=null!;private Button btnNovo=null!;private DataGridView gradeClientes=null!;
}
