#nullable disable
namespace PetShop_App.Telas.Pets
{
    partial class PaginaPets
    {
        private System.ComponentModel.IContainer components;

        protected override void Dispose(bool disposing)
        {
            if (disposing) components?.Dispose();

            base.Dispose(disposing);

        }
        private Button btnEditarRegistro;

        private Button btnExcluirRegistro;

        private DataGridViewTextBoxColumn gradePetsColId;

private DataGridViewTextBoxColumn gradePetsColNome;

private DataGridViewTextBoxColumn gradePetsColTutor;

private DataGridViewTextBoxColumn gradePetsColEspecie;

private DataGridViewTextBoxColumn gradePetsColRaca;

private DataGridViewTextBoxColumn gradePetsColPorte;

private DataGridViewTextBoxColumn gradePetsColPeso;

private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            pnlCabecalho = new Panel();
pnlCabecalho.Size = new Size(1000, 125);

            lblTitulo = new Label();

            lblSubtitulo = new Label();

            txtPesquisa = new TextBox();

            btnNovo = new Button();

            gradePets = new DataGridView();

gradePetsColId = new DataGridViewTextBoxColumn();

gradePetsColId.Name = "Id";

gradePetsColId.DataPropertyName = "Id";

gradePetsColId.HeaderText = "Id";

gradePetsColId.Visible = false;

gradePetsColNome = new DataGridViewTextBoxColumn();

gradePetsColNome.Name = "Nome";

gradePetsColNome.DataPropertyName = "Nome";

gradePetsColNome.HeaderText = "Nome";

gradePetsColTutor = new DataGridViewTextBoxColumn();

gradePetsColTutor.Name = "Tutor";

gradePetsColTutor.DataPropertyName = "Tutor";

gradePetsColTutor.HeaderText = "Tutor";

gradePetsColEspecie = new DataGridViewTextBoxColumn();

gradePetsColEspecie.Name = "Especie";

gradePetsColEspecie.DataPropertyName = "Especie";

gradePetsColEspecie.HeaderText = "Especie";

gradePetsColRaca = new DataGridViewTextBoxColumn();

gradePetsColRaca.Name = "Raca";

gradePetsColRaca.DataPropertyName = "Raca";

gradePetsColRaca.HeaderText = "Raca";

gradePetsColPorte = new DataGridViewTextBoxColumn();

gradePetsColPorte.Name = "Porte";

gradePetsColPorte.DataPropertyName = "Porte";

gradePetsColPorte.HeaderText = "Porte";

gradePetsColPeso = new DataGridViewTextBoxColumn();

gradePetsColPeso.Name = "Peso";

gradePetsColPeso.DataPropertyName = "Peso";

gradePetsColPeso.HeaderText = "Peso";

gradePets.AutoGenerateColumns = false;

gradePets.Columns.AddRange(new DataGridViewColumn[] { gradePetsColId, gradePetsColNome, gradePetsColTutor, gradePetsColEspecie, gradePetsColRaca, gradePetsColPorte, gradePetsColPeso });

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

            ((System.ComponentModel.ISupportInitialize)gradePets).BeginInit();

            SuspendLayout();


            pnlCabecalho.Controls.Add(btnNovo);

            pnlCabecalho.Controls.Add(txtPesquisa);

            pnlCabecalho.Controls.Add(lblSubtitulo);

            pnlCabecalho.Controls.Add(lblTitulo);

            pnlCabecalho.Dock = DockStyle.Top;

            pnlCabecalho.Height = 125;

            pnlCabecalho.Name = "pnlCabecalho";


            lblTitulo.AutoSize = true;

            lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);

            lblTitulo.ForeColor = Color.FromArgb(15, 23, 42);

            lblTitulo.Location = new Point(0, 4);

            lblTitulo.Name = "lblTitulo";

            lblTitulo.Text = "Pets";


            lblSubtitulo.AutoSize = true;

            lblSubtitulo.ForeColor = Color.FromArgb(100, 116, 139);

            lblSubtitulo.Location = new Point(0, 46);

            lblSubtitulo.Name = "lblSubtitulo";

            lblSubtitulo.Text = "Todo pet deve estar vinculado a um cliente cadastrado.";


            txtPesquisa.Location = new Point(0, 82);

            txtPesquisa.Name = "txtPesquisa";

            txtPesquisa.PlaceholderText = "Nome do pet ou tutor";

            txtPesquisa.Size = new Size(420, 23);

            txtPesquisa.TabIndex = 0;


            btnNovo.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            btnNovo.BackColor = Color.FromArgb(255, 128, 0);

            btnNovo.FlatStyle = FlatStyle.Flat;

            btnNovo.ForeColor = Color.White;

            btnNovo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            btnNovo.Location = new Point(830, 8);

            btnNovo.Name = "btnNovo";

            btnNovo.Size = new Size(150, 40);

            btnNovo.Text = "+ Cadastrar pet";

            btnNovo.UseVisualStyleBackColor = false;


            gradePets.AllowUserToAddRows = false;

            gradePets.AllowUserToDeleteRows = false;

            gradePets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            gradePets.BackgroundColor = Color.White;

            gradePets.BorderStyle = BorderStyle.None;

            gradePets.Dock = DockStyle.Fill;

            gradePets.Location = new Point(0, 125);

            gradePets.Name = "gradePets";

            gradePets.ReadOnly = true;

            gradePets.RowHeadersVisible = false;

            gradePets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            AutoScaleDimensions = new SizeF(7F, 15F);

            AutoScaleMode = AutoScaleMode.Font;

            BackColor = Color.FromArgb(241, 245, 249);

            Controls.Add(gradePets);

            Controls.Add(pnlCabecalho);

            Name = "PaginaPets";

            Size = new Size(1000, 700);

            pnlCabecalho.ResumeLayout(false);

            pnlCabecalho.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)gradePets).EndInit();

            ResumeLayout(false);

        }
        private Panel pnlCabecalho;

        private Label lblTitulo;

        private Label lblSubtitulo;

        private TextBox txtPesquisa;

        private Button btnNovo;

        private DataGridView gradePets;


    }

}
