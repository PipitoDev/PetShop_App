#nullable disable
namespace PetShop_App.Telas.Servicos
{
    partial class PaginaServicos
    {
        private System.ComponentModel.IContainer components;

        protected override void Dispose(bool d)
        {
            if (d) components?.Dispose();

            base.Dispose(d);

        }
        private Button btnEditarRegistro;

        private Button btnExcluirRegistro;

        private DataGridViewTextBoxColumn gradeServicosColId;

private DataGridViewTextBoxColumn gradeServicosColNome;

private DataGridViewTextBoxColumn gradeServicosColDescricao;

private DataGridViewTextBoxColumn gradeServicosColValor;

private DataGridViewTextBoxColumn gradeServicosColDuracao;

private DataGridViewTextBoxColumn gradeServicosColStatus;

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

            btnNovo = new Button();

btnNovo.Name = "btnNovo";

            gradeServicos = new DataGridView();

gradeServicos.Name = "gradeServicos";

gradeServicosColId = new DataGridViewTextBoxColumn();

gradeServicosColId.Name = "Id";

gradeServicosColId.DataPropertyName = "Id";

gradeServicosColId.HeaderText = "Id";

gradeServicosColId.Visible = false;

gradeServicosColNome = new DataGridViewTextBoxColumn();

gradeServicosColNome.Name = "Nome";

gradeServicosColNome.DataPropertyName = "Nome";

gradeServicosColNome.HeaderText = "Nome";

gradeServicosColDescricao = new DataGridViewTextBoxColumn();

gradeServicosColDescricao.Name = "Descricao";

gradeServicosColDescricao.DataPropertyName = "Descricao";

gradeServicosColDescricao.HeaderText = "Descricao";

gradeServicosColValor = new DataGridViewTextBoxColumn();

gradeServicosColValor.Name = "Valor";

gradeServicosColValor.DataPropertyName = "Valor";

gradeServicosColValor.HeaderText = "Valor";

gradeServicosColDuracao = new DataGridViewTextBoxColumn();

gradeServicosColDuracao.Name = "Duração";

gradeServicosColDuracao.DataPropertyName = "Duração";

gradeServicosColDuracao.HeaderText = "Duração";

gradeServicosColStatus = new DataGridViewTextBoxColumn();

gradeServicosColStatus.Name = "Status";

gradeServicosColStatus.DataPropertyName = "Status";

gradeServicosColStatus.HeaderText = "Status";

gradeServicos.AutoGenerateColumns = false;

gradeServicos.Columns.AddRange(new DataGridViewColumn[] { gradeServicosColId, gradeServicosColNome, gradeServicosColDescricao, gradeServicosColValor, gradeServicosColDuracao, gradeServicosColStatus });

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

            ((System.ComponentModel.ISupportInitialize)gradeServicos).BeginInit();

            SuspendLayout();

            pnlCabecalho.Controls.Add(btnNovo);

            pnlCabecalho.Controls.Add(lblSubtitulo);

            pnlCabecalho.Controls.Add(lblTitulo);

            pnlCabecalho.Dock = DockStyle.Top;

            pnlCabecalho.Height = 82;

            lblTitulo.AutoSize = true;

            lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);

            lblTitulo.ForeColor = Color.FromArgb(15, 23, 42);

            lblTitulo.Location = new Point(0, 4);

            lblTitulo.Text = "Catálogo de serviços";

            lblSubtitulo.AutoSize = true;

            lblSubtitulo.ForeColor = Color.FromArgb(100, 116, 139);

            lblSubtitulo.Location = new Point(0, 46);

            lblSubtitulo.Text = "Defina preços e duração para calcular cada atendimento.";

            btnNovo.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            btnNovo.BackColor = Color.FromArgb(255, 128, 0);

            btnNovo.FlatStyle = FlatStyle.Flat;

            btnNovo.ForeColor = Color.White;

            btnNovo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            btnNovo.Location = new Point(810, 8);

            btnNovo.Size = new Size(170, 40);

            btnNovo.Text = "+ Cadastrar serviço";

            gradeServicos.AllowUserToAddRows = false;

            gradeServicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            gradeServicos.BackgroundColor = Color.White;

            gradeServicos.BorderStyle = BorderStyle.None;

            gradeServicos.Dock = DockStyle.Fill;

            gradeServicos.ReadOnly = true;

            gradeServicos.RowHeadersVisible = false;

            gradeServicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            AutoScaleDimensions = new SizeF(7, 15);

            AutoScaleMode = AutoScaleMode.Font;

            BackColor = Color.FromArgb(241, 245, 249);

            Controls.Add(gradeServicos);

            Controls.Add(pnlCabecalho);

            Name = "PaginaServicos";

            Size = new Size(1000, 700);

            pnlCabecalho.ResumeLayout(false);

            pnlCabecalho.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)gradeServicos).EndInit();

            ResumeLayout(false);

        }
        private Panel pnlCabecalho;

        private Label lblTitulo;

        private Label lblSubtitulo;

        private Button btnNovo;

        private DataGridView gradeServicos;

    }

}
