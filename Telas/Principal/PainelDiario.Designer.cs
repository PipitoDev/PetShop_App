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
            lblAtendimentosEmAndamento = new Label();
            pnlAgendamentos = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            lblValorAgendamentos = new Label();
            lblTituloAgendamentos = new Label();
            pnlPets = new Panel();
            icnPetsCadastrados = new FontAwesome.Sharp.IconPictureBox();
            lblValorPets = new Label();
            lblTituloPets = new Label();
            pnlFaturamento = new Panel();
            icnFaturamento = new FontAwesome.Sharp.IconPictureBox();
            lblValorFaturamento = new Label();
            lblTituloFaturamento = new Label();
            gradeAgenda = new DataGridView();
            gradeAgendaColHorario = new DataGridViewTextBoxColumn();
            gradeAgendaColPet = new DataGridViewTextBoxColumn();
            gradeAgendaColTutor = new DataGridViewTextBoxColumn();
            gradeAgendaColServico = new DataGridViewTextBoxColumn();
            gradeAgendaColValor = new DataGridViewTextBoxColumn();
            gradeAgendaColStatus = new DataGridViewTextBoxColumn();
            pnlCabecalho.SuspendLayout();
            flpCartoes.SuspendLayout();
            pnlAtendimentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icnAtendimentos).BeginInit();
            pnlAgendamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            pnlPets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icnPetsCadastrados).BeginInit();
            pnlFaturamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icnFaturamento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradeAgenda).BeginInit();
            SuspendLayout();
            // 
            // pnlCabecalho
            // 
            pnlCabecalho.Controls.Add(lblSubtitulo);
            pnlCabecalho.Controls.Add(lblTitulo);
            pnlCabecalho.Dock = DockStyle.Top;
            pnlCabecalho.Location = new Point(0, 0);
            pnlCabecalho.Margin = new Padding(3, 4, 3, 4);
            pnlCabecalho.Name = "pnlCabecalho";
            pnlCabecalho.Size = new Size(1257, 104);
            pnlCabecalho.TabIndex = 2;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.ForeColor = Color.FromArgb(100, 116, 139);
            lblSubtitulo.Location = new Point(0, 61);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(522, 20);
            lblSubtitulo.TabIndex = 0;
            lblSubtitulo.Text = "Acompanhe o movimento de hoje e acesse rapidamente as principais tarefas.";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(15, 23, 42);
            lblTitulo.Location = new Point(0, 5);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(490, 50);
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
            flpCartoes.Location = new Point(0, 104);
            flpCartoes.Margin = new Padding(3, 4, 3, 4);
            flpCartoes.Name = "flpCartoes";
            flpCartoes.Padding = new Padding(0, 21, 0, 13);
            flpCartoes.Size = new Size(1257, 193);
            flpCartoes.TabIndex = 1;
            flpCartoes.WrapContents = false;
            // 
            // pnlAtendimentos
            // 
            pnlAtendimentos.BackColor = Color.White;
            pnlAtendimentos.Controls.Add(icnAtendimentos);
            pnlAtendimentos.Controls.Add(lblValorAtendimentos);
            pnlAtendimentos.Controls.Add(lblTituloAtendimentos);
            pnlAtendimentos.Controls.Add(lblAtendimentosEmAndamento);
            pnlAtendimentos.Location = new Point(0, 21);
            pnlAtendimentos.Margin = new Padding(0, 0, 17, 0);
            pnlAtendimentos.Name = "pnlAtendimentos";
            pnlAtendimentos.Padding = new Padding(17, 20, 17, 20);
            pnlAtendimentos.Size = new Size(280, 149);
            pnlAtendimentos.TabIndex = 0;
            // 
            // icnAtendimentos
            // 
            icnAtendimentos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            icnAtendimentos.BackColor = Color.White;
            icnAtendimentos.ForeColor = Color.Fuchsia;
            icnAtendimentos.IconChar = FontAwesome.Sharp.IconChar.User;
            icnAtendimentos.IconColor = Color.Fuchsia;
            icnAtendimentos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icnAtendimentos.IconSize = 27;
            icnAtendimentos.Location = new Point(226, 20);
            icnAtendimentos.Margin = new Padding(3, 4, 3, 4);
            icnAtendimentos.Name = "icnAtendimentos";
            icnAtendimentos.Size = new Size(27, 32);
            icnAtendimentos.TabIndex = 2;
            icnAtendimentos.TabStop = false;
            // 
            // lblValorAtendimentos
            // 
            lblValorAtendimentos.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            lblValorAtendimentos.ForeColor = Color.FromArgb(15, 23, 42);
            lblValorAtendimentos.Location = new Point(14, 49);
            lblValorAtendimentos.Name = "lblValorAtendimentos";
            lblValorAtendimentos.Size = new Size(114, 57);
            lblValorAtendimentos.TabIndex = 0;
            lblValorAtendimentos.Text = "0";
            // 
            // lblTituloAtendimentos
            // 
            lblTituloAtendimentos.ForeColor = Color.FromArgb(71, 85, 105);
            lblTituloAtendimentos.Location = new Point(14, 19);
            lblTituloAtendimentos.Name = "lblTituloAtendimentos";
            lblTituloAtendimentos.Size = new Size(200, 35);
            lblTituloAtendimentos.TabIndex = 1;
            lblTituloAtendimentos.Text = "Atendimentos hoje";
            // 
            // lblAtendimentosEmAndamento
            // 
            lblAtendimentosEmAndamento.AutoSize = true;
            lblAtendimentosEmAndamento.Font = new Font("Segoe UI", 8F);
            lblAtendimentosEmAndamento.ForeColor = Color.FromArgb(71, 85, 105);
            lblAtendimentosEmAndamento.Location = new Point(14, 112);
            lblAtendimentosEmAndamento.Name = "lblAtendimentosEmAndamento";
            lblAtendimentosEmAndamento.Size = new Size(114, 19);
            lblAtendimentosEmAndamento.TabIndex = 3;
            lblAtendimentosEmAndamento.Text = "1 em andamento";
            // 
            // pnlAgendamentos
            // 
            pnlAgendamentos.BackColor = Color.White;
            pnlAgendamentos.Controls.Add(iconPictureBox1);
            pnlAgendamentos.Controls.Add(lblValorAgendamentos);
            pnlAgendamentos.Controls.Add(lblTituloAgendamentos);
            pnlAgendamentos.Location = new Point(297, 21);
            pnlAgendamentos.Margin = new Padding(0, 0, 17, 0);
            pnlAgendamentos.Name = "pnlAgendamentos";
            pnlAgendamentos.Padding = new Padding(17, 20, 17, 20);
            pnlAgendamentos.Size = new Size(280, 149);
            pnlAgendamentos.TabIndex = 1;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = Color.Blue;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            iconPictureBox1.IconColor = Color.Blue;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 27;
            iconPictureBox1.Location = new Point(236, 19);
            iconPictureBox1.Margin = new Padding(3, 4, 3, 4);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(27, 32);
            iconPictureBox1.TabIndex = 3;
            iconPictureBox1.TabStop = false;
            // 
            // lblValorAgendamentos
            // 
            lblValorAgendamentos.Dock = DockStyle.Fill;
            lblValorAgendamentos.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblValorAgendamentos.ForeColor = Color.FromArgb(15, 23, 42);
            lblValorAgendamentos.Location = new Point(17, 55);
            lblValorAgendamentos.Name = "lblValorAgendamentos";
            lblValorAgendamentos.Size = new Size(246, 74);
            lblValorAgendamentos.TabIndex = 0;
            lblValorAgendamentos.Text = "0";
            // 
            // lblTituloAgendamentos
            // 
            lblTituloAgendamentos.Dock = DockStyle.Top;
            lblTituloAgendamentos.ForeColor = Color.FromArgb(100, 116, 139);
            lblTituloAgendamentos.Location = new Point(17, 20);
            lblTituloAgendamentos.Name = "lblTituloAgendamentos";
            lblTituloAgendamentos.Size = new Size(246, 35);
            lblTituloAgendamentos.TabIndex = 1;
            lblTituloAgendamentos.Text = "Agendamentos";
            // 
            // pnlPets
            // 
            pnlPets.BackColor = Color.White;
            pnlPets.Controls.Add(icnPetsCadastrados);
            pnlPets.Controls.Add(lblValorPets);
            pnlPets.Controls.Add(lblTituloPets);
            pnlPets.Location = new Point(594, 21);
            pnlPets.Margin = new Padding(0, 0, 17, 0);
            pnlPets.Name = "pnlPets";
            pnlPets.Padding = new Padding(17, 20, 17, 20);
            pnlPets.Size = new Size(280, 149);
            pnlPets.TabIndex = 2;
            // 
            // icnPetsCadastrados
            // 
            icnPetsCadastrados.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            icnPetsCadastrados.BackColor = Color.White;
            icnPetsCadastrados.ForeColor = Color.FromArgb(255, 128, 0);
            icnPetsCadastrados.IconChar = FontAwesome.Sharp.IconChar.Paw;
            icnPetsCadastrados.IconColor = Color.FromArgb(255, 128, 0);
            icnPetsCadastrados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icnPetsCadastrados.IconSize = 27;
            icnPetsCadastrados.Location = new Point(236, 19);
            icnPetsCadastrados.Margin = new Padding(3, 4, 3, 4);
            icnPetsCadastrados.Name = "icnPetsCadastrados";
            icnPetsCadastrados.Size = new Size(27, 32);
            icnPetsCadastrados.TabIndex = 4;
            icnPetsCadastrados.TabStop = false;
            // 
            // lblValorPets
            // 
            lblValorPets.Dock = DockStyle.Fill;
            lblValorPets.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblValorPets.ForeColor = Color.FromArgb(15, 23, 42);
            lblValorPets.Location = new Point(17, 55);
            lblValorPets.Name = "lblValorPets";
            lblValorPets.Size = new Size(246, 74);
            lblValorPets.TabIndex = 0;
            lblValorPets.Text = "0";
            // 
            // lblTituloPets
            // 
            lblTituloPets.Dock = DockStyle.Top;
            lblTituloPets.ForeColor = Color.FromArgb(100, 116, 139);
            lblTituloPets.Location = new Point(17, 20);
            lblTituloPets.Name = "lblTituloPets";
            lblTituloPets.Size = new Size(246, 35);
            lblTituloPets.TabIndex = 1;
            lblTituloPets.Text = "Pets cadastrados";
            // 
            // pnlFaturamento
            // 
            pnlFaturamento.BackColor = Color.White;
            pnlFaturamento.Controls.Add(icnFaturamento);
            pnlFaturamento.Controls.Add(lblValorFaturamento);
            pnlFaturamento.Controls.Add(lblTituloFaturamento);
            pnlFaturamento.Location = new Point(891, 21);
            pnlFaturamento.Margin = new Padding(0, 0, 17, 0);
            pnlFaturamento.Name = "pnlFaturamento";
            pnlFaturamento.Padding = new Padding(17, 20, 17, 20);
            pnlFaturamento.Size = new Size(280, 149);
            pnlFaturamento.TabIndex = 3;
            // 
            // icnFaturamento
            // 
            icnFaturamento.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            icnFaturamento.BackColor = Color.White;
            icnFaturamento.ForeColor = Color.Lime;
            icnFaturamento.IconChar = FontAwesome.Sharp.IconChar.Donate;
            icnFaturamento.IconColor = Color.Lime;
            icnFaturamento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icnFaturamento.IconSize = 27;
            icnFaturamento.Location = new Point(233, 20);
            icnFaturamento.Margin = new Padding(3, 4, 3, 4);
            icnFaturamento.Name = "icnFaturamento";
            icnFaturamento.Size = new Size(27, 32);
            icnFaturamento.TabIndex = 5;
            icnFaturamento.TabStop = false;
            // 
            // lblValorFaturamento
            // 
            lblValorFaturamento.Dock = DockStyle.Fill;
            lblValorFaturamento.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblValorFaturamento.ForeColor = Color.FromArgb(15, 23, 42);
            lblValorFaturamento.Location = new Point(17, 55);
            lblValorFaturamento.Name = "lblValorFaturamento";
            lblValorFaturamento.Size = new Size(246, 74);
            lblValorFaturamento.TabIndex = 0;
            lblValorFaturamento.Text = "0";
            // 
            // lblTituloFaturamento
            // 
            lblTituloFaturamento.Dock = DockStyle.Top;
            lblTituloFaturamento.ForeColor = Color.FromArgb(100, 116, 139);
            lblTituloFaturamento.Location = new Point(17, 20);
            lblTituloFaturamento.Name = "lblTituloFaturamento";
            lblTituloFaturamento.Size = new Size(246, 35);
            lblTituloFaturamento.TabIndex = 1;
            lblTituloFaturamento.Text = "Faturamento do turno";
            // 
            // gradeAgenda
            // 
            gradeAgenda.AllowUserToAddRows = false;
            gradeAgenda.AllowUserToDeleteRows = false;
            gradeAgenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gradeAgenda.AutoGenerateColumns = false;
            gradeAgenda.BackgroundColor = Color.White;
            gradeAgenda.BorderStyle = BorderStyle.None;
            gradeAgenda.ColumnHeadersHeight = 29;
            gradeAgenda.Columns.AddRange(new DataGridViewColumn[] { gradeAgendaColHorario, gradeAgendaColPet, gradeAgendaColTutor, gradeAgendaColServico, gradeAgendaColValor, gradeAgendaColStatus });
            gradeAgenda.Dock = DockStyle.Fill;
            gradeAgenda.Location = new Point(0, 297);
            gradeAgenda.Margin = new Padding(3, 4, 3, 4);
            gradeAgenda.Name = "gradeAgenda";
            gradeAgenda.ReadOnly = true;
            gradeAgenda.RowHeadersVisible = false;
            gradeAgenda.RowHeadersWidth = 51;
            gradeAgenda.Size = new Size(1257, 636);
            gradeAgenda.TabIndex = 0;
            // 
            // gradeAgendaColHorario
            // 
            gradeAgendaColHorario.DataPropertyName = "Horario";
            gradeAgendaColHorario.HeaderText = "Horário";
            gradeAgendaColHorario.Name = "gradeAgendaColHorario";
            gradeAgendaColHorario.ReadOnly = true;
            // 
            // gradeAgendaColPet
            // 
            gradeAgendaColPet.DataPropertyName = "Pet";
            gradeAgendaColPet.HeaderText = "Pet";
            gradeAgendaColPet.Name = "gradeAgendaColPet";
            gradeAgendaColPet.ReadOnly = true;
            // 
            // gradeAgendaColTutor
            // 
            gradeAgendaColTutor.DataPropertyName = "Tutor";
            gradeAgendaColTutor.HeaderText = "Tutor";
            gradeAgendaColTutor.Name = "gradeAgendaColTutor";
            gradeAgendaColTutor.ReadOnly = true;
            // 
            // gradeAgendaColServico
            // 
            gradeAgendaColServico.DataPropertyName = "Servico";
            gradeAgendaColServico.HeaderText = "Serviço";
            gradeAgendaColServico.Name = "gradeAgendaColServico";
            gradeAgendaColServico.ReadOnly = true;
            // 
            // gradeAgendaColValor
            // 
            gradeAgendaColValor.DataPropertyName = "Valor";
            gradeAgendaColValor.HeaderText = "Valor";
            gradeAgendaColValor.Name = "gradeAgendaColValor";
            gradeAgendaColValor.ReadOnly = true;
            // 
            // gradeAgendaColStatus
            // 
            gradeAgendaColStatus.DataPropertyName = "Status";
            gradeAgendaColStatus.HeaderText = "Status";
            gradeAgendaColStatus.Name = "gradeAgendaColStatus";
            gradeAgendaColStatus.ReadOnly = true;
            // 
            // PainelDiario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            Controls.Add(gradeAgenda);
            Controls.Add(flpCartoes);
            Controls.Add(pnlCabecalho);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PainelDiario";
            Size = new Size(1257, 933);
            pnlCabecalho.ResumeLayout(false);
            pnlCabecalho.PerformLayout();
            flpCartoes.ResumeLayout(false);
            pnlAtendimentos.ResumeLayout(false);
            pnlAtendimentos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)icnAtendimentos).EndInit();
            pnlAgendamentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            pnlPets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icnPetsCadastrados).EndInit();
            pnlFaturamento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icnFaturamento).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradeAgenda).EndInit();
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

        private Label lblAtendimentosEmAndamento;

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;

        private FontAwesome.Sharp.IconPictureBox icnPetsCadastrados;

        private FontAwesome.Sharp.IconPictureBox icnFaturamento;

    }

}
