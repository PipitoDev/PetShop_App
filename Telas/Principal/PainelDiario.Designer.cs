#nullable disable
namespace PetShop_App.Telas.Principal
{
    partial class PainelDiario
    {
        private System.ComponentModel.IContainer components;

        protected override void Dispose(bool d)
        {
            if (d) components?.Dispose();

            base.Dispose(d);

        }
        private DataGridViewTextBoxColumn gradeAgendaColHorario;

private DataGridViewTextBoxColumn gradeAgendaColPet;

private DataGridViewTextBoxColumn gradeAgendaColTutor;

private DataGridViewTextBoxColumn gradeAgendaColServico;

private DataGridViewTextBoxColumn gradeAgendaColValor;

private DataGridViewTextBoxColumn gradeAgendaColStatus;

private void InitializeComponent()
        {
components = new System.ComponentModel.Container();

            pnlCabecalho = new Panel();

            lblSubtitulo = new Label();

            lblTitulo = new Label();

            flpCartoes = new FlowLayoutPanel();

            pnlAtendimentos = new Panel();

            icnAtendimentos = new FontAwesome.Sharp.IconPictureBox();

            lblValorAtendimentos = new Label();

            lblTituloAtendimentos = new Label();

            lblDetalheAtendimentos = new Label();

            pnlAgendamentos = new Panel();

            lblValorAgendamentos = new Label();

            lblTituloAgendamentos = new Label();

            pnlPets = new Panel();

            lblValorPets = new Label();

            lblTituloPets = new Label();

            pnlFaturamento = new Panel();

            lblValorFaturamento = new Label();

            lblTituloFaturamento = new Label();

            gradeAgenda = new DataGridView();

gradeAgendaColHorario = new DataGridViewTextBoxColumn();

gradeAgendaColHorario.Name = "Horário";

gradeAgendaColHorario.DataPropertyName = "Horário";

gradeAgendaColHorario.HeaderText = "Horário";

gradeAgendaColPet = new DataGridViewTextBoxColumn();

gradeAgendaColPet.Name = "Pet";

gradeAgendaColPet.DataPropertyName = "Pet";

gradeAgendaColPet.HeaderText = "Pet";

gradeAgendaColTutor = new DataGridViewTextBoxColumn();

gradeAgendaColTutor.Name = "Tutor";

gradeAgendaColTutor.DataPropertyName = "Tutor";

gradeAgendaColTutor.HeaderText = "Tutor";

gradeAgendaColServico = new DataGridViewTextBoxColumn();

gradeAgendaColServico.Name = "Serviço";

gradeAgendaColServico.DataPropertyName = "Serviço";

gradeAgendaColServico.HeaderText = "Serviço";

gradeAgendaColValor = new DataGridViewTextBoxColumn();

gradeAgendaColValor.Name = "Valor";

gradeAgendaColValor.DataPropertyName = "Valor";

gradeAgendaColValor.HeaderText = "Valor";

gradeAgendaColStatus = new DataGridViewTextBoxColumn();

gradeAgendaColStatus.Name = "Status";

gradeAgendaColStatus.DataPropertyName = "Status";

gradeAgendaColStatus.HeaderText = "Status";

gradeAgenda.AutoGenerateColumns = false;

gradeAgenda.Columns.AddRange(new DataGridViewColumn[] { gradeAgendaColHorario, gradeAgendaColPet, gradeAgendaColTutor, gradeAgendaColServico, gradeAgendaColValor, gradeAgendaColStatus });

            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();

            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();

            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();

            pnlCabecalho.SuspendLayout();

            flpCartoes.SuspendLayout();

            pnlAtendimentos.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)icnAtendimentos).BeginInit();

            pnlAgendamentos.SuspendLayout();

            pnlPets.SuspendLayout();

            pnlFaturamento.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)gradeAgenda).BeginInit();

            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();

            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();

            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();

            SuspendLayout();

            // 
            // pnlCabecalho
            // 
            pnlCabecalho.Controls.Add(lblSubtitulo);

            pnlCabecalho.Controls.Add(lblTitulo);

            pnlCabecalho.Dock = DockStyle.Top;

            pnlCabecalho.Location = new Point(0, 0);

            pnlCabecalho.Name = "pnlCabecalho";

            pnlCabecalho.Size = new Size(1100, 78);

            pnlCabecalho.TabIndex = 2;

            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;

            lblSubtitulo.ForeColor = Color.FromArgb(100, 116, 139);

            lblSubtitulo.Location = new Point(0, 46);

            lblSubtitulo.Name = "lblSubtitulo";

            lblSubtitulo.Size = new Size(414, 15);

            lblSubtitulo.TabIndex = 0;

            lblSubtitulo.Text = "Acompanhe o movimento de hoje e acesse rapidamente as principais tarefas.";

            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;

            lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);

            lblTitulo.ForeColor = Color.FromArgb(15, 23, 42);

            lblTitulo.Location = new Point(0, 4);

            lblTitulo.Name = "lblTitulo";

            lblTitulo.Size = new Size(395, 41);

            lblTitulo.TabIndex = 1;

            lblTitulo.Text = "Sua rotina, em um só lugar";

            // 
            // flpCartoes
            // 
            flpCartoes.Controls.Add(pnlAtendimentos);

            flpCartoes.Controls.Add(pnlAgendamentos);

            flpCartoes.Controls.Add(pnlPets);

            flpCartoes.Controls.Add(pnlFaturamento);

            flpCartoes.Dock = DockStyle.Top;

            flpCartoes.Location = new Point(0, 78);

            flpCartoes.Name = "flpCartoes";

            flpCartoes.Padding = new Padding(0, 16, 0, 10);

            flpCartoes.Size = new Size(1100, 145);

            flpCartoes.TabIndex = 1;

            flpCartoes.WrapContents = false;

            // 
            // pnlAtendimentos
            // 
            pnlAtendimentos.BackColor = Color.White;

            pnlAtendimentos.Controls.Add(icnAtendimentos);

            pnlAtendimentos.Controls.Add(lblValorAtendimentos);

            pnlAtendimentos.Controls.Add(lblTituloAtendimentos);

            pnlAtendimentos.Controls.Add(lblDetalheAtendimentos);

            pnlAtendimentos.Location = new Point(0, 16);

            pnlAtendimentos.Margin = new Padding(0, 0, 15, 0);

            pnlAtendimentos.Name = "pnlAtendimentos";

            pnlAtendimentos.Padding = new Padding(15);

            pnlAtendimentos.Size = new Size(245, 112);

            pnlAtendimentos.TabIndex = 0;

            // 
            // icnAtendimentos
            // 
            icnAtendimentos.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            icnAtendimentos.BackColor = Color.White;

            icnAtendimentos.ForeColor = Color.FromArgb(255, 128, 0);

            icnAtendimentos.IconChar = FontAwesome.Sharp.IconChar.Paw;

            icnAtendimentos.IconColor = Color.FromArgb(255, 128, 0);

            icnAtendimentos.IconFont = FontAwesome.Sharp.IconFont.Auto;

            icnAtendimentos.IconSize = 24;

            icnAtendimentos.Location = new Point(198, 15);

            icnAtendimentos.Name = "icnAtendimentos";

            icnAtendimentos.Size = new Size(24, 24);

            icnAtendimentos.TabIndex = 2;

            icnAtendimentos.TabStop = false;

            // 
            // lblValorAtendimentos
            // 
            lblValorAtendimentos.Font = new Font("Segoe UI", 21F, FontStyle.Bold);

            lblValorAtendimentos.ForeColor = Color.FromArgb(15, 23, 42);

            lblValorAtendimentos.Location = new Point(12, 37);

            lblValorAtendimentos.Name = "lblValorAtendimentos";

            lblValorAtendimentos.Size = new Size(100, 43);

            lblValorAtendimentos.TabIndex = 0;

            lblValorAtendimentos.Text = "0";

            lblValorAtendimentos.Click += lblValorAtendimentos_Click;

            // 
            // lblTituloAtendimentos
            // 
            lblTituloAtendimentos.ForeColor = Color.FromArgb(71, 85, 105);

            lblTituloAtendimentos.Location = new Point(12, 14);

            lblTituloAtendimentos.Name = "lblTituloAtendimentos";

            lblTituloAtendimentos.Size = new Size(100, 26);

            lblTituloAtendimentos.TabIndex = 1;

            lblTituloAtendimentos.Text = "Atendimentos hoje";

            // 
            // lblDetalheAtendimentos
            // 
            lblDetalheAtendimentos.AutoSize = true;

            lblDetalheAtendimentos.Font = new Font("Segoe UI", 8F);

            lblDetalheAtendimentos.ForeColor = Color.FromArgb(71, 85, 105);

            lblDetalheAtendimentos.Location = new Point(12, 84);

            lblDetalheAtendimentos.Name = "lblDetalheAtendimentos";

            lblDetalheAtendimentos.Size = new Size(93, 13);

            lblDetalheAtendimentos.TabIndex = 3;

            lblDetalheAtendimentos.Text = "1 em andamento";

            // 
            // pnlAgendamentos
            // 
            pnlAgendamentos.BackColor = Color.White;

            pnlAgendamentos.Controls.Add(iconPictureBox1);

            pnlAgendamentos.Controls.Add(lblValorAgendamentos);

            pnlAgendamentos.Controls.Add(lblTituloAgendamentos);

            pnlAgendamentos.Location = new Point(260, 16);

            pnlAgendamentos.Margin = new Padding(0, 0, 15, 0);

            pnlAgendamentos.Name = "pnlAgendamentos";

            pnlAgendamentos.Padding = new Padding(15);

            pnlAgendamentos.Size = new Size(245, 112);

            pnlAgendamentos.TabIndex = 1;

            // 
            // lblValorAgendamentos
            // 
            lblValorAgendamentos.Dock = DockStyle.Fill;

            lblValorAgendamentos.Font = new Font("Segoe UI", 20F, FontStyle.Bold);

            lblValorAgendamentos.ForeColor = Color.FromArgb(15, 23, 42);

            lblValorAgendamentos.Location = new Point(15, 41);

            lblValorAgendamentos.Name = "lblValorAgendamentos";

            lblValorAgendamentos.Size = new Size(215, 56);

            lblValorAgendamentos.TabIndex = 0;

            lblValorAgendamentos.Text = "0";

            // 
            // lblTituloAgendamentos
            // 
            lblTituloAgendamentos.Dock = DockStyle.Top;

            lblTituloAgendamentos.ForeColor = Color.FromArgb(100, 116, 139);

            lblTituloAgendamentos.Location = new Point(15, 15);

            lblTituloAgendamentos.Name = "lblTituloAgendamentos";

            lblTituloAgendamentos.Size = new Size(215, 26);

            lblTituloAgendamentos.TabIndex = 1;

            lblTituloAgendamentos.Text = "Agendamentos";

            // 
            // pnlPets
            // 
            pnlPets.BackColor = Color.White;

            pnlPets.Controls.Add(iconPictureBox2);

            pnlPets.Controls.Add(lblValorPets);

            pnlPets.Controls.Add(lblTituloPets);

            pnlPets.Location = new Point(520, 16);

            pnlPets.Margin = new Padding(0, 0, 15, 0);

            pnlPets.Name = "pnlPets";

            pnlPets.Padding = new Padding(15);

            pnlPets.Size = new Size(245, 112);

            pnlPets.TabIndex = 2;

            // 
            // lblValorPets
            // 
            lblValorPets.Dock = DockStyle.Fill;

            lblValorPets.Font = new Font("Segoe UI", 20F, FontStyle.Bold);

            lblValorPets.ForeColor = Color.FromArgb(15, 23, 42);

            lblValorPets.Location = new Point(15, 41);

            lblValorPets.Name = "lblValorPets";

            lblValorPets.Size = new Size(215, 56);

            lblValorPets.TabIndex = 0;

            lblValorPets.Text = "0";

            // 
            // lblTituloPets
            // 
            lblTituloPets.Dock = DockStyle.Top;

            lblTituloPets.ForeColor = Color.FromArgb(100, 116, 139);

            lblTituloPets.Location = new Point(15, 15);

            lblTituloPets.Name = "lblTituloPets";

            lblTituloPets.Size = new Size(215, 26);

            lblTituloPets.TabIndex = 1;

            lblTituloPets.Text = "Pets cadastrados";

            // 
            // pnlFaturamento
            // 
            pnlFaturamento.BackColor = Color.White;

            pnlFaturamento.Controls.Add(iconPictureBox3);

            pnlFaturamento.Controls.Add(lblValorFaturamento);

            pnlFaturamento.Controls.Add(lblTituloFaturamento);

            pnlFaturamento.Location = new Point(780, 16);

            pnlFaturamento.Margin = new Padding(0, 0, 15, 0);

            pnlFaturamento.Name = "pnlFaturamento";

            pnlFaturamento.Padding = new Padding(15);

            pnlFaturamento.Size = new Size(245, 112);

            pnlFaturamento.TabIndex = 3;

            // 
            // lblValorFaturamento
            // 
            lblValorFaturamento.Dock = DockStyle.Fill;

            lblValorFaturamento.Font = new Font("Segoe UI", 20F, FontStyle.Bold);

            lblValorFaturamento.ForeColor = Color.FromArgb(15, 23, 42);

            lblValorFaturamento.Location = new Point(15, 41);

            lblValorFaturamento.Name = "lblValorFaturamento";

            lblValorFaturamento.Size = new Size(215, 56);

            lblValorFaturamento.TabIndex = 0;

            lblValorFaturamento.Text = "0";

            // 
            // lblTituloFaturamento
            // 
            lblTituloFaturamento.Dock = DockStyle.Top;

            lblTituloFaturamento.ForeColor = Color.FromArgb(100, 116, 139);

            lblTituloFaturamento.Location = new Point(15, 15);

            lblTituloFaturamento.Name = "lblTituloFaturamento";

            lblTituloFaturamento.Size = new Size(215, 26);

            lblTituloFaturamento.TabIndex = 1;

            lblTituloFaturamento.Text = "Faturamento do turno";

            // 
            // gradeAgenda
            // 
            gradeAgenda.AllowUserToAddRows = false;

            gradeAgenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            gradeAgenda.BackgroundColor = Color.White;

            gradeAgenda.BorderStyle = BorderStyle.None;

            gradeAgenda.Dock = DockStyle.Fill;

            gradeAgenda.Location = new Point(0, 223);

            gradeAgenda.Name = "gradeAgenda";

            gradeAgenda.ReadOnly = true;

            gradeAgenda.RowHeadersVisible = false;

            gradeAgenda.Size = new Size(1100, 477);

            gradeAgenda.TabIndex = 0;

            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            iconPictureBox1.BackColor = Color.White;

            iconPictureBox1.ForeColor = Color.FromArgb(255, 128, 0);

            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Paw;

            iconPictureBox1.IconColor = Color.FromArgb(255, 128, 0);

            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;

            iconPictureBox1.IconSize = 24;

            iconPictureBox1.Location = new Point(206, 18);

            iconPictureBox1.Name = "iconPictureBox1";

            iconPictureBox1.Size = new Size(24, 24);

            iconPictureBox1.TabIndex = 3;

            iconPictureBox1.TabStop = false;

            // 
            // iconPictureBox2
            // 
            iconPictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            iconPictureBox2.BackColor = Color.White;

            iconPictureBox2.ForeColor = Color.FromArgb(255, 128, 0);

            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Paw;

            iconPictureBox2.IconColor = Color.FromArgb(255, 128, 0);

            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;

            iconPictureBox2.IconSize = 24;

            iconPictureBox2.Location = new Point(206, 18);

            iconPictureBox2.Name = "iconPictureBox2";

            iconPictureBox2.Size = new Size(24, 24);

            iconPictureBox2.TabIndex = 4;

            iconPictureBox2.TabStop = false;

            // 
            // iconPictureBox3
            // 
            iconPictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            iconPictureBox3.BackColor = Color.White;

            iconPictureBox3.ForeColor = Color.FromArgb(255, 128, 0);

            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Paw;

            iconPictureBox3.IconColor = Color.FromArgb(255, 128, 0);

            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;

            iconPictureBox3.IconSize = 24;

            iconPictureBox3.Location = new Point(206, 18);

            iconPictureBox3.Name = "iconPictureBox3";

            iconPictureBox3.Size = new Size(24, 24);

            iconPictureBox3.TabIndex = 5;

            iconPictureBox3.TabStop = false;

            // 
            // PainelDiario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);

            AutoScaleMode = AutoScaleMode.Font;

            BackColor = Color.FromArgb(241, 245, 249);

            Controls.Add(gradeAgenda);

            Controls.Add(flpCartoes);

            Controls.Add(pnlCabecalho);

            Name = "PainelDiario";

            Size = new Size(1100, 700);

            pnlCabecalho.ResumeLayout(false);

            pnlCabecalho.PerformLayout();

            flpCartoes.ResumeLayout(false);

            pnlAtendimentos.ResumeLayout(false);

            pnlAtendimentos.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)icnAtendimentos).EndInit();

            pnlAgendamentos.ResumeLayout(false);

            pnlPets.ResumeLayout(false);

            pnlFaturamento.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)gradeAgenda).EndInit();

            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();

            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();

            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();

            ResumeLayout(false);

        }
        private Panel pnlCabecalho;

        private Label lblTitulo;

        private Label lblSubtitulo;

        private Label lblTituloAtendimentos;

        private Label lblTituloAgendamentos;

        private Label lblTituloPets;

        private Label lblTituloFaturamento;

        private FlowLayoutPanel flpCartoes;

        private Panel pnlAtendimentos, pnlAgendamentos, pnlPets, pnlFaturamento;

        private Label lblValorAtendimentos, lblValorAgendamentos, lblValorPets, lblValorFaturamento;

        private DataGridView gradeAgenda;

        private FontAwesome.Sharp.IconPictureBox icnAtendimentos;

        private Label lblDetalheAtendimentos;

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;

        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;

        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;

    }

}
