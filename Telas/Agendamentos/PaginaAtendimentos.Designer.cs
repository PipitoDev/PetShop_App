#nullable disable
namespace PetShop_App.Telas.Agendamentos
{
    partial class PaginaAtendimentos
    {
        private System.ComponentModel.IContainer components;

        protected override void Dispose(bool d)
        {
            if (d) components?.Dispose();

            base.Dispose(d);

        }
        private Button btnEditarRegistro;

        private Button btnExcluirRegistro;

        private DataGridViewTextBoxColumn gradeAtendimentosColId;

private DataGridViewTextBoxColumn gradeAtendimentosColData;

private DataGridViewTextBoxColumn gradeAtendimentosColPet;

private DataGridViewTextBoxColumn gradeAtendimentosColTutor;

private DataGridViewTextBoxColumn gradeAtendimentosColServico;

private DataGridViewTextBoxColumn gradeAtendimentosColValor;

private DataGridViewTextBoxColumn gradeAtendimentosColStatus;

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

            gradeAtendimentos = new DataGridView();

gradeAtendimentos.Name = "gradeAtendimentos";

gradeAtendimentosColId = new DataGridViewTextBoxColumn();

gradeAtendimentosColId.Name = "Id";

gradeAtendimentosColId.DataPropertyName = "Id";

gradeAtendimentosColId.HeaderText = "Id";

gradeAtendimentosColId.Visible = false;

gradeAtendimentosColData = new DataGridViewTextBoxColumn();

gradeAtendimentosColData.Name = "Data";

gradeAtendimentosColData.DataPropertyName = "Data";

gradeAtendimentosColData.HeaderText = "Data";

gradeAtendimentosColPet = new DataGridViewTextBoxColumn();

gradeAtendimentosColPet.Name = "Pet";

gradeAtendimentosColPet.DataPropertyName = "Pet";

gradeAtendimentosColPet.HeaderText = "Pet";

gradeAtendimentosColTutor = new DataGridViewTextBoxColumn();

gradeAtendimentosColTutor.Name = "Tutor";

gradeAtendimentosColTutor.DataPropertyName = "Tutor";

gradeAtendimentosColTutor.HeaderText = "Tutor";

gradeAtendimentosColServico = new DataGridViewTextBoxColumn();

gradeAtendimentosColServico.Name = "Servico";

gradeAtendimentosColServico.DataPropertyName = "Servico";

gradeAtendimentosColServico.HeaderText = "Servico";

gradeAtendimentosColValor = new DataGridViewTextBoxColumn();

gradeAtendimentosColValor.Name = "Valor";

gradeAtendimentosColValor.DataPropertyName = "Valor";

gradeAtendimentosColValor.HeaderText = "Valor";

gradeAtendimentosColStatus = new DataGridViewTextBoxColumn();

gradeAtendimentosColStatus.Name = "Status";

gradeAtendimentosColStatus.DataPropertyName = "Status";

gradeAtendimentosColStatus.HeaderText = "Status";

gradeAtendimentos.AutoGenerateColumns = false;

gradeAtendimentos.Columns.AddRange(new DataGridViewColumn[] { gradeAtendimentosColId, gradeAtendimentosColData, gradeAtendimentosColPet, gradeAtendimentosColTutor, gradeAtendimentosColServico, gradeAtendimentosColValor, gradeAtendimentosColStatus });

            btnEditarRegistro = new Button();
 btnEditarRegistro.Name = "btnEditarRegistro";
 btnEditarRegistro.Text = "Editar";
 btnEditarRegistro.Size = new Size(90, 40);
 btnEditarRegistro.Location = new Point(579, 8);
 btnEditarRegistro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
 btnEditarRegistro.BackColor = Color.White;
 btnEditarRegistro.ForeColor = Color.FromArgb(255, 128, 0);
 btnEditarRegistro.FlatStyle = FlatStyle.Flat;
 pnlCabecalho.Controls.Add(btnEditarRegistro);

            btnExcluirRegistro = new Button();
 btnExcluirRegistro.Name = "btnExcluirRegistro";
 btnExcluirRegistro.Text = "Remover";
 btnExcluirRegistro.Size = new Size(105, 40);
 btnExcluirRegistro.Location = new Point(677, 8);
 btnExcluirRegistro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
 btnExcluirRegistro.BackColor = Color.White;
 btnExcluirRegistro.ForeColor = Color.FromArgb(255, 128, 0);
 btnExcluirRegistro.FlatStyle = FlatStyle.Flat;
 pnlCabecalho.Controls.Add(btnExcluirRegistro);

            pnlCabecalho.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)gradeAtendimentos).BeginInit();

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

            lblTitulo.Text = "Atendimentos";

            lblSubtitulo.AutoSize = true;

            lblSubtitulo.ForeColor = Color.FromArgb(100, 116, 139);

            lblSubtitulo.Location = new Point(0, 46);

            lblSubtitulo.Text = "Selecione o pet e o serviço; o valor é calculado automaticamente.";

            btnNovo.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            btnNovo.BackColor = Color.FromArgb(255, 128, 0);

            btnNovo.FlatStyle = FlatStyle.Flat;

            btnNovo.ForeColor = Color.White;

            btnNovo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            btnNovo.Location = new Point(790, 8);

            btnNovo.Size = new Size(190, 40);

            btnNovo.Text = "+ Agendar atendimento";

            gradeAtendimentos.AllowUserToAddRows = false;

            gradeAtendimentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            gradeAtendimentos.BackgroundColor = Color.White;

            gradeAtendimentos.BorderStyle = BorderStyle.None;

            gradeAtendimentos.Dock = DockStyle.Fill;

            gradeAtendimentos.ReadOnly = true;

            gradeAtendimentos.RowHeadersVisible = false;

            gradeAtendimentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            AutoScaleDimensions = new SizeF(7, 15);

            AutoScaleMode = AutoScaleMode.Font;

            BackColor = Color.FromArgb(241, 245, 249);

            Controls.Add(gradeAtendimentos);

            Controls.Add(pnlCabecalho);

            Name = "PaginaAtendimentos";

            Size = new Size(1000, 700);

            pnlCabecalho.ResumeLayout(false);

            pnlCabecalho.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)gradeAtendimentos).EndInit();

            ResumeLayout(false);

        }
        private Panel pnlCabecalho;

        private Label lblTitulo;

        private Label lblSubtitulo;

        private Button btnNovo;

        private DataGridView gradeAtendimentos;

    }

}
