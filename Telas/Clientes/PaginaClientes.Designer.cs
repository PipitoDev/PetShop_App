#nullable disable
namespace PetShop_App.Telas.Clientes
{
    partial class PaginaClientes
    {
        private System.ComponentModel.IContainer components;

        protected override void Dispose(bool disposing)
        {
            if (disposing) components?.Dispose();

            base.Dispose(disposing);

        }
        private Button btnEditarRegistro;

        private Button btnExcluirRegistro;

        private DataGridViewTextBoxColumn gradeClientesColId;

private DataGridViewTextBoxColumn gradeClientesColNome;

private DataGridViewTextBoxColumn gradeClientesColCpf;

private DataGridViewTextBoxColumn gradeClientesColTelefone;

private DataGridViewTextBoxColumn gradeClientesColEmail;

private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            pnlCabecalho = new Panel();
pnlCabecalho.Size = new Size(1000, 125);

pnlCabecalho.Name = "pnlCabecalho";

            lblTitulo = new Label();

lblTitulo.Name = "lblTitulo";

            lblSubtitulo = new Label();

lblSubtitulo.Name = "lblSubtitulo";

            txtPesquisa = new TextBox();

            btnNovo = new Button();

btnNovo.Name = "btnNovo";

            gradeClientes = new DataGridView();

gradeClientes.Name = "gradeClientes";

gradeClientesColId = new DataGridViewTextBoxColumn();

gradeClientesColId.Name = "Id";

gradeClientesColId.DataPropertyName = "Id";

gradeClientesColId.HeaderText = "Id";

gradeClientesColId.Visible = false;

gradeClientesColNome = new DataGridViewTextBoxColumn();

gradeClientesColNome.Name = "Nome";

gradeClientesColNome.DataPropertyName = "Nome";

gradeClientesColNome.HeaderText = "Nome";

gradeClientesColCpf = new DataGridViewTextBoxColumn();

gradeClientesColCpf.Name = "Cpf";

gradeClientesColCpf.DataPropertyName = "Cpf";

gradeClientesColCpf.HeaderText = "Cpf";

gradeClientesColTelefone = new DataGridViewTextBoxColumn();

gradeClientesColTelefone.Name = "Telefone";

gradeClientesColTelefone.DataPropertyName = "Telefone";

gradeClientesColTelefone.HeaderText = "Telefone";

gradeClientesColEmail = new DataGridViewTextBoxColumn();

gradeClientesColEmail.Name = "Email";

gradeClientesColEmail.DataPropertyName = "Email";

gradeClientesColEmail.HeaderText = "Email";

gradeClientes.AutoGenerateColumns = false;

gradeClientes.Columns.AddRange(new DataGridViewColumn[] { gradeClientesColId, gradeClientesColNome, gradeClientesColCpf, gradeClientesColTelefone, gradeClientesColEmail });

            btnEditarRegistro = new Button();
 btnEditarRegistro.Name = "btnEditarRegistro";
 btnEditarRegistro.Text = "Editar";
 btnEditarRegistro.Size = new Size(90, 40);
 btnEditarRegistro.Location = new Point(599, 8);
 btnEditarRegistro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
 btnEditarRegistro.BackColor = Color.White;
 btnEditarRegistro.ForeColor = Color.FromArgb(255, 128, 0);
 btnEditarRegistro.FlatStyle = FlatStyle.Flat;
 pnlCabecalho.Controls.Add(btnEditarRegistro);

            btnExcluirRegistro = new Button();
 btnExcluirRegistro.Name = "btnExcluirRegistro";
 btnExcluirRegistro.Text = "Remover";
 btnExcluirRegistro.Size = new Size(105, 40);
 btnExcluirRegistro.Location = new Point(697, 8);
 btnExcluirRegistro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
 btnExcluirRegistro.BackColor = Color.White;
 btnExcluirRegistro.ForeColor = Color.FromArgb(255, 128, 0);
 btnExcluirRegistro.FlatStyle = FlatStyle.Flat;
 pnlCabecalho.Controls.Add(btnExcluirRegistro);

            pnlCabecalho.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)gradeClientes).BeginInit();

            SuspendLayout();


            pnlCabecalho.Controls.Add(btnNovo);

            pnlCabecalho.Controls.Add(txtPesquisa);

            pnlCabecalho.Controls.Add(lblSubtitulo);

            pnlCabecalho.Controls.Add(lblTitulo);

            pnlCabecalho.Dock = DockStyle.Top;

            pnlCabecalho.Height = 125;


            lblTitulo.AutoSize = true;

            lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);

            lblTitulo.ForeColor = Color.FromArgb(15, 23, 42);

            lblTitulo.Location = new Point(0, 4);

            lblTitulo.Text = "Clientes";


            lblSubtitulo.AutoSize = true;

            lblSubtitulo.ForeColor = Color.FromArgb(100, 116, 139);

            lblSubtitulo.Location = new Point(0, 46);

            lblSubtitulo.Text = "Cadastre tutores e mantenha os dados de contato organizados.";


            txtPesquisa.Location = new Point(0, 82);

            txtPesquisa.Name = "txtPesquisa";

            txtPesquisa.PlaceholderText = "Nome ou telefone do cliente";

            txtPesquisa.Size = new Size(420, 23);


            btnNovo.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            btnNovo.BackColor = Color.FromArgb(255, 128, 0);

            btnNovo.FlatStyle = FlatStyle.Flat;

            btnNovo.ForeColor = Color.White;

            btnNovo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            btnNovo.Location = new Point(810, 8);

            btnNovo.Size = new Size(170, 40);

            btnNovo.Text = "+ Cadastrar cliente";

            btnNovo.UseVisualStyleBackColor = false;


            gradeClientes.AllowUserToAddRows = false;

            gradeClientes.AllowUserToDeleteRows = false;

            gradeClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            gradeClientes.BackgroundColor = Color.White;

            gradeClientes.BorderStyle = BorderStyle.None;

            gradeClientes.Dock = DockStyle.Fill;

            gradeClientes.Location = new Point(0, 125);

            gradeClientes.ReadOnly = true;

            gradeClientes.RowHeadersVisible = false;

            gradeClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            AutoScaleDimensions = new SizeF(7F, 15F);

            AutoScaleMode = AutoScaleMode.Font;

            BackColor = Color.FromArgb(241, 245, 249);

            Controls.Add(gradeClientes);

            Controls.Add(pnlCabecalho);

            Name = "PaginaClientes";

            Size = new Size(1000, 700);

            pnlCabecalho.ResumeLayout(false);

            pnlCabecalho.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)gradeClientes).EndInit();

            ResumeLayout(false);

        }
        private Panel pnlCabecalho;

        private Label lblTitulo;

        private Label lblSubtitulo;

        private TextBox txtPesquisa;

        private Button btnNovo;

        private DataGridView gradeClientes;


    }

}
