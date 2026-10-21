namespace PetShop_App.Componentes
{
    partial class MenuLateral
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuLateral));
            tlpMenuLateral = new TableLayoutPanel();
            pnlCabecalhoMenu = new Panel();
            picLogoMenu = new PictureBox();
            pnlNavegacaoMenu = new Panel();
            flpBotoesMenu = new FlowLayoutPanel();
            btnPainel = new FontAwesome.Sharp.IconButton();
            btnClientes = new FontAwesome.Sharp.IconButton();
            btnPets = new FontAwesome.Sharp.IconButton();
            btnServicos = new FontAwesome.Sharp.IconButton();
            btnAgendamentos = new FontAwesome.Sharp.IconButton();
            btnAtendimentos = new FontAwesome.Sharp.IconButton();
            btnPDV = new FontAwesome.Sharp.IconButton();
            btnPedidos = new FontAwesome.Sharp.IconButton();
            btnEstoque = new FontAwesome.Sharp.IconButton();
            btnGestao = new FontAwesome.Sharp.IconButton();
            btnRelatorios = new FontAwesome.Sharp.IconButton();
            btnFuncionarios = new FontAwesome.Sharp.IconButton();
            btnAuditoria = new FontAwesome.Sharp.IconButton();
            pnlRodapeMenu = new Panel();
            tlpRodape = new TableLayoutPanel();
            pnlDivisoria = new Panel();
            icoUsuario = new FontAwesome.Sharp.IconPictureBox();
            lblCargo = new Label();
            lblNomeUsuario = new Label();
            pnlDadosUsuario = new Panel();
            lblCaixa = new Label();
            lblStatusCaixa = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            tlpMenuLateral.SuspendLayout();
            pnlCabecalhoMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoMenu).BeginInit();
            pnlNavegacaoMenu.SuspendLayout();
            flpBotoesMenu.SuspendLayout();
            pnlRodapeMenu.SuspendLayout();
            tlpRodape.SuspendLayout();
            pnlDivisoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icoUsuario).BeginInit();
            pnlDadosUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tlpMenuLateral
            // 
            tlpMenuLateral.ColumnCount = 1;
            tlpMenuLateral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMenuLateral.Controls.Add(pnlCabecalhoMenu, 0, 0);
            tlpMenuLateral.Controls.Add(pnlNavegacaoMenu, 0, 1);
            tlpMenuLateral.Controls.Add(pnlRodapeMenu, 0, 2);
            tlpMenuLateral.Dock = DockStyle.Fill;
            tlpMenuLateral.Location = new Point(0, 0);
            tlpMenuLateral.Margin = new Padding(4);
            tlpMenuLateral.Name = "tlpMenuLateral";
            tlpMenuLateral.RowCount = 3;
            tlpMenuLateral.RowStyles.Add(new RowStyle(SizeType.Absolute, 95F));
            tlpMenuLateral.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMenuLateral.RowStyles.Add(new RowStyle(SizeType.Absolute, 144F));
            tlpMenuLateral.Size = new Size(300, 875);
            tlpMenuLateral.TabIndex = 0;
            // 
            // pnlCabecalhoMenu
            // 
            pnlCabecalhoMenu.Controls.Add(picLogoMenu);
            pnlCabecalhoMenu.Dock = DockStyle.Fill;
            pnlCabecalhoMenu.Location = new Point(0, 0);
            pnlCabecalhoMenu.Margin = new Padding(0);
            pnlCabecalhoMenu.Name = "pnlCabecalhoMenu";
            pnlCabecalhoMenu.Size = new Size(300, 95);
            pnlCabecalhoMenu.TabIndex = 0;
            // 
            // picLogoMenu
            // 
            picLogoMenu.Image = (Image)resources.GetObject("picLogoMenu.Image");
            picLogoMenu.Location = new Point(5, 10);
            picLogoMenu.Margin = new Padding(15, 10, 15, 10);
            picLogoMenu.Name = "picLogoMenu";
            picLogoMenu.Size = new Size(285, 85);
            picLogoMenu.SizeMode = PictureBoxSizeMode.Zoom;
            picLogoMenu.TabIndex = 0;
            picLogoMenu.TabStop = false;
            // 
            // pnlNavegacaoMenu
            // 
            pnlNavegacaoMenu.Controls.Add(flpBotoesMenu);
            pnlNavegacaoMenu.Dock = DockStyle.Fill;
            pnlNavegacaoMenu.Location = new Point(0, 95);
            pnlNavegacaoMenu.Margin = new Padding(0);
            pnlNavegacaoMenu.Name = "pnlNavegacaoMenu";
            pnlNavegacaoMenu.Size = new Size(300, 636);
            pnlNavegacaoMenu.TabIndex = 1;
            // 
            // flpBotoesMenu
            // 
            flpBotoesMenu.AutoScroll = true;
            flpBotoesMenu.Controls.Add(btnPainel);
            flpBotoesMenu.Controls.Add(btnClientes);
            flpBotoesMenu.Controls.Add(btnPets);
            flpBotoesMenu.Controls.Add(btnServicos);
            flpBotoesMenu.Controls.Add(btnAgendamentos);
            flpBotoesMenu.Controls.Add(btnAtendimentos);
            flpBotoesMenu.Controls.Add(btnPDV);
            flpBotoesMenu.Controls.Add(btnPedidos);
            flpBotoesMenu.Controls.Add(btnEstoque);
            flpBotoesMenu.Controls.Add(btnGestao);
            flpBotoesMenu.Controls.Add(btnRelatorios);
            flpBotoesMenu.Controls.Add(btnFuncionarios);
            flpBotoesMenu.Controls.Add(btnAuditoria);
            flpBotoesMenu.Dock = DockStyle.Fill;
            flpBotoesMenu.FlowDirection = FlowDirection.TopDown;
            flpBotoesMenu.Location = new Point(0, 0);
            flpBotoesMenu.Margin = new Padding(0);
            flpBotoesMenu.Name = "flpBotoesMenu";
            flpBotoesMenu.Padding = new Padding(5, 10, 5, 0);
            flpBotoesMenu.Size = new Size(300, 636);
            flpBotoesMenu.TabIndex = 1;
            flpBotoesMenu.WrapContents = false;
            // 
            // btnPainel
            // 
            btnPainel.BackColor = Color.FromArgb(255, 240, 226);
            btnPainel.Cursor = Cursors.Hand;
            btnPainel.FlatAppearance.BorderSize = 0;
            btnPainel.FlatStyle = FlatStyle.Flat;
            btnPainel.Font = new Font("Segoe UI", 10F);
            btnPainel.ForeColor = Color.FromArgb(255, 128, 0);
            btnPainel.IconChar = FontAwesome.Sharp.IconChar.ThLarge;
            btnPainel.IconColor = Color.FromArgb(255, 128, 0);
            btnPainel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPainel.IconSize = 18;
            btnPainel.ImageAlign = ContentAlignment.MiddleLeft;
            btnPainel.Location = new Point(5, 10);
            btnPainel.Margin = new Padding(0, 0, 0, 5);
            btnPainel.Name = "btnPainel";
            btnPainel.Padding = new Padding(15, 0, 0, 0);
            btnPainel.Size = new Size(238, 48);
            btnPainel.TabIndex = 0;
            btnPainel.Text = "Painel";
            btnPainel.TextAlign = ContentAlignment.MiddleLeft;
            btnPainel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPainel.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.White;
            btnClientes.Cursor = Cursors.Hand;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 10F);
            btnClientes.ForeColor = Color.FromArgb(100, 116, 139);
            btnClientes.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            btnClientes.IconColor = Color.FromArgb(100, 116, 139);
            btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClientes.IconSize = 18;
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(5, 63);
            btnClientes.Margin = new Padding(0, 0, 0, 5);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new Padding(15, 0, 0, 0);
            btnClientes.Size = new Size(238, 48);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "Clientes";
            btnClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClientes.UseVisualStyleBackColor = false;
            // 
            // btnPets
            // 
            btnPets.BackColor = Color.White;
            btnPets.Cursor = Cursors.Hand;
            btnPets.FlatAppearance.BorderSize = 0;
            btnPets.FlatStyle = FlatStyle.Flat;
            btnPets.Font = new Font("Segoe UI", 10F);
            btnPets.ForeColor = Color.FromArgb(100, 116, 139);
            btnPets.IconChar = FontAwesome.Sharp.IconChar.Paw;
            btnPets.IconColor = Color.FromArgb(100, 116, 139);
            btnPets.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPets.IconSize = 18;
            btnPets.ImageAlign = ContentAlignment.MiddleLeft;
            btnPets.Location = new Point(5, 116);
            btnPets.Margin = new Padding(0, 0, 0, 5);
            btnPets.Name = "btnPets";
            btnPets.Padding = new Padding(15, 0, 0, 0);
            btnPets.Size = new Size(238, 48);
            btnPets.TabIndex = 2;
            btnPets.Text = "Pets";
            btnPets.TextAlign = ContentAlignment.MiddleLeft;
            btnPets.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPets.UseVisualStyleBackColor = false;
            // 
            // btnServicos
            // 
            btnServicos.BackColor = Color.White;
            btnServicos.Cursor = Cursors.Hand;
            btnServicos.FlatAppearance.BorderSize = 0;
            btnServicos.FlatStyle = FlatStyle.Flat;
            btnServicos.Font = new Font("Segoe UI", 10F);
            btnServicos.ForeColor = Color.FromArgb(100, 116, 139);
            btnServicos.IconChar = FontAwesome.Sharp.IconChar.Scissors;
            btnServicos.IconColor = Color.FromArgb(100, 116, 139);
            btnServicos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnServicos.IconSize = 18;
            btnServicos.ImageAlign = ContentAlignment.MiddleLeft;
            btnServicos.Location = new Point(5, 169);
            btnServicos.Margin = new Padding(0, 0, 0, 5);
            btnServicos.Name = "btnServicos";
            btnServicos.Padding = new Padding(15, 0, 0, 0);
            btnServicos.Size = new Size(238, 48);
            btnServicos.TabIndex = 3;
            btnServicos.Text = "Serviços";
            btnServicos.TextAlign = ContentAlignment.MiddleLeft;
            btnServicos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnServicos.UseVisualStyleBackColor = false;
            // 
            // btnAgendamentos
            // 
            btnAgendamentos.BackColor = Color.White;
            btnAgendamentos.Cursor = Cursors.Hand;
            btnAgendamentos.FlatAppearance.BorderSize = 0;
            btnAgendamentos.FlatStyle = FlatStyle.Flat;
            btnAgendamentos.Font = new Font("Segoe UI", 10F);
            btnAgendamentos.ForeColor = Color.FromArgb(100, 116, 139);
            btnAgendamentos.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            btnAgendamentos.IconColor = Color.FromArgb(100, 116, 139);
            btnAgendamentos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgendamentos.IconSize = 18;
            btnAgendamentos.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgendamentos.Location = new Point(5, 222);
            btnAgendamentos.Margin = new Padding(0, 0, 0, 5);
            btnAgendamentos.Name = "btnAgendamentos";
            btnAgendamentos.Padding = new Padding(15, 0, 0, 0);
            btnAgendamentos.Size = new Size(238, 48);
            btnAgendamentos.TabIndex = 4;
            btnAgendamentos.Text = "Agendamentos";
            btnAgendamentos.TextAlign = ContentAlignment.MiddleLeft;
            btnAgendamentos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgendamentos.UseVisualStyleBackColor = false;
            // 
            // btnAtendimentos
            // 
            btnAtendimentos.BackColor = Color.White;
            btnAtendimentos.Cursor = Cursors.Hand;
            btnAtendimentos.FlatAppearance.BorderSize = 0;
            btnAtendimentos.FlatStyle = FlatStyle.Flat;
            btnAtendimentos.Font = new Font("Segoe UI", 10F);
            btnAtendimentos.ForeColor = Color.FromArgb(100, 116, 139);
            btnAtendimentos.IconChar = FontAwesome.Sharp.IconChar.HeartPulse;
            btnAtendimentos.IconColor = Color.FromArgb(100, 116, 139);
            btnAtendimentos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAtendimentos.IconSize = 18;
            btnAtendimentos.ImageAlign = ContentAlignment.MiddleLeft;
            btnAtendimentos.Location = new Point(5, 275);
            btnAtendimentos.Margin = new Padding(0, 0, 0, 5);
            btnAtendimentos.Name = "btnAtendimentos";
            btnAtendimentos.Padding = new Padding(15, 0, 0, 0);
            btnAtendimentos.Size = new Size(238, 48);
            btnAtendimentos.TabIndex = 5;
            btnAtendimentos.Text = "Atendimentos";
            btnAtendimentos.TextAlign = ContentAlignment.MiddleLeft;
            btnAtendimentos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAtendimentos.UseVisualStyleBackColor = false;
            // 
            // btnPDV
            // 
            btnPDV.BackColor = Color.White;
            btnPDV.Cursor = Cursors.Hand;
            btnPDV.FlatAppearance.BorderSize = 0;
            btnPDV.FlatStyle = FlatStyle.Flat;
            btnPDV.Font = new Font("Segoe UI", 10F);
            btnPDV.ForeColor = Color.FromArgb(100, 116, 139);
            btnPDV.IconChar = FontAwesome.Sharp.IconChar.ShoppingBasket;
            btnPDV.IconColor = Color.FromArgb(100, 116, 139);
            btnPDV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPDV.IconSize = 18;
            btnPDV.ImageAlign = ContentAlignment.MiddleLeft;
            btnPDV.Location = new Point(5, 328);
            btnPDV.Margin = new Padding(0, 0, 0, 5);
            btnPDV.Name = "btnPDV";
            btnPDV.Padding = new Padding(15, 0, 0, 0);
            btnPDV.Size = new Size(238, 48);
            btnPDV.TabIndex = 6;
            btnPDV.Text = "PDV";
            btnPDV.TextAlign = ContentAlignment.MiddleLeft;
            btnPDV.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPDV.UseVisualStyleBackColor = false;
            // 
            // btnPedidos
            // 
            btnPedidos.BackColor = Color.White;
            btnPedidos.Cursor = Cursors.Hand;
            btnPedidos.FlatAppearance.BorderSize = 0;
            btnPedidos.FlatStyle = FlatStyle.Flat;
            btnPedidos.Font = new Font("Segoe UI", 10F);
            btnPedidos.ForeColor = Color.FromArgb(100, 116, 139);
            btnPedidos.IconChar = FontAwesome.Sharp.IconChar.Box;
            btnPedidos.IconColor = Color.FromArgb(100, 116, 139);
            btnPedidos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPedidos.IconSize = 18;
            btnPedidos.ImageAlign = ContentAlignment.MiddleLeft;
            btnPedidos.Location = new Point(5, 381);
            btnPedidos.Margin = new Padding(0, 0, 0, 5);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Padding = new Padding(15, 0, 0, 0);
            btnPedidos.Size = new Size(238, 48);
            btnPedidos.TabIndex = 7;
            btnPedidos.Text = "Pedidos";
            btnPedidos.TextAlign = ContentAlignment.MiddleLeft;
            btnPedidos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPedidos.UseVisualStyleBackColor = false;
            // 
            // btnEstoque
            // 
            btnEstoque.BackColor = Color.White;
            btnEstoque.Cursor = Cursors.Hand;
            btnEstoque.FlatAppearance.BorderSize = 0;
            btnEstoque.FlatStyle = FlatStyle.Flat;
            btnEstoque.Font = new Font("Segoe UI", 10F);
            btnEstoque.ForeColor = Color.FromArgb(100, 116, 139);
            btnEstoque.IconChar = FontAwesome.Sharp.IconChar.BoxesStacked;
            btnEstoque.IconColor = Color.FromArgb(100, 116, 139);
            btnEstoque.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEstoque.IconSize = 18;
            btnEstoque.ImageAlign = ContentAlignment.MiddleLeft;
            btnEstoque.Location = new Point(5, 434);
            btnEstoque.Margin = new Padding(0, 0, 0, 5);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Padding = new Padding(15, 0, 0, 0);
            btnEstoque.Size = new Size(238, 48);
            btnEstoque.TabIndex = 8;
            btnEstoque.Text = "Estoque";
            btnEstoque.TextAlign = ContentAlignment.MiddleLeft;
            btnEstoque.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEstoque.UseVisualStyleBackColor = false;
            // 
            // btnGestao
            // 
            btnGestao.BackColor = Color.White;
            btnGestao.Cursor = Cursors.Hand;
            btnGestao.FlatAppearance.BorderSize = 0;
            btnGestao.FlatStyle = FlatStyle.Flat;
            btnGestao.Font = new Font("Segoe UI", 10F);
            btnGestao.ForeColor = Color.FromArgb(100, 116, 139);
            btnGestao.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            btnGestao.IconColor = Color.FromArgb(100, 116, 139);
            btnGestao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGestao.IconSize = 18;
            btnGestao.ImageAlign = ContentAlignment.MiddleLeft;
            btnGestao.Location = new Point(5, 487);
            btnGestao.Margin = new Padding(0, 0, 0, 5);
            btnGestao.Name = "btnGestao";
            btnGestao.Padding = new Padding(15, 0, 0, 0);
            btnGestao.Size = new Size(238, 48);
            btnGestao.TabIndex = 9;
            btnGestao.Text = "Gestão";
            btnGestao.TextAlign = ContentAlignment.MiddleLeft;
            btnGestao.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGestao.UseVisualStyleBackColor = false;
            // 
            // btnRelatorios
            // 
            btnRelatorios.BackColor = Color.White;
            btnRelatorios.Cursor = Cursors.Hand;
            btnRelatorios.FlatAppearance.BorderSize = 0;
            btnRelatorios.FlatStyle = FlatStyle.Flat;
            btnRelatorios.Font = new Font("Segoe UI", 10F);
            btnRelatorios.ForeColor = Color.FromArgb(100, 116, 139);
            btnRelatorios.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            btnRelatorios.IconColor = Color.FromArgb(100, 116, 139);
            btnRelatorios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRelatorios.IconSize = 18;
            btnRelatorios.ImageAlign = ContentAlignment.MiddleLeft;
            btnRelatorios.Location = new Point(5, 540);
            btnRelatorios.Margin = new Padding(0, 0, 0, 5);
            btnRelatorios.Name = "btnRelatorios";
            btnRelatorios.Padding = new Padding(15, 0, 0, 0);
            btnRelatorios.Size = new Size(238, 48);
            btnRelatorios.TabIndex = 10;
            btnRelatorios.Text = "Relatórios";
            btnRelatorios.TextAlign = ContentAlignment.MiddleLeft;
            btnRelatorios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRelatorios.UseVisualStyleBackColor = false;
            // 
            // btnFuncionarios
            // 
            btnFuncionarios.BackColor = Color.White;
            btnFuncionarios.Cursor = Cursors.Hand;
            btnFuncionarios.FlatAppearance.BorderSize = 0;
            btnFuncionarios.FlatStyle = FlatStyle.Flat;
            btnFuncionarios.Font = new Font("Segoe UI", 10F);
            btnFuncionarios.ForeColor = Color.FromArgb(100, 116, 139);
            btnFuncionarios.IconChar = FontAwesome.Sharp.IconChar.IdBadge;
            btnFuncionarios.IconColor = Color.FromArgb(100, 116, 139);
            btnFuncionarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFuncionarios.IconSize = 18;
            btnFuncionarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnFuncionarios.Location = new Point(5, 593);
            btnFuncionarios.Margin = new Padding(0, 0, 0, 5);
            btnFuncionarios.Name = "btnFuncionarios";
            btnFuncionarios.Padding = new Padding(15, 0, 0, 0);
            btnFuncionarios.Size = new Size(238, 48);
            btnFuncionarios.TabIndex = 11;
            btnFuncionarios.Text = "Funcionários";
            btnFuncionarios.TextAlign = ContentAlignment.MiddleLeft;
            btnFuncionarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFuncionarios.UseVisualStyleBackColor = false;
            // 
            // btnAuditoria
            // 
            btnAuditoria.BackColor = Color.White;
            btnAuditoria.Cursor = Cursors.Hand;
            btnAuditoria.FlatAppearance.BorderSize = 0;
            btnAuditoria.FlatStyle = FlatStyle.Flat;
            btnAuditoria.Font = new Font("Segoe UI", 10F);
            btnAuditoria.ForeColor = Color.FromArgb(100, 116, 139);
            btnAuditoria.IconChar = FontAwesome.Sharp.IconChar.ShieldHalved;
            btnAuditoria.IconColor = Color.FromArgb(100, 116, 139);
            btnAuditoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAuditoria.IconSize = 18;
            btnAuditoria.ImageAlign = ContentAlignment.MiddleLeft;
            btnAuditoria.Location = new Point(5, 646);
            btnAuditoria.Margin = new Padding(0, 0, 0, 5);
            btnAuditoria.Name = "btnAuditoria";
            btnAuditoria.Padding = new Padding(15, 0, 0, 0);
            btnAuditoria.Size = new Size(238, 48);
            btnAuditoria.TabIndex = 12;
            btnAuditoria.Text = "Auditoria";
            btnAuditoria.TextAlign = ContentAlignment.MiddleLeft;
            btnAuditoria.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAuditoria.UseVisualStyleBackColor = false;
            // 
            // pnlRodapeMenu
            // 
            pnlRodapeMenu.Controls.Add(tlpRodape);
            pnlRodapeMenu.Dock = DockStyle.Fill;
            pnlRodapeMenu.Location = new Point(0, 731);
            pnlRodapeMenu.Margin = new Padding(0);
            pnlRodapeMenu.Name = "pnlRodapeMenu";
            pnlRodapeMenu.Size = new Size(300, 144);
            pnlRodapeMenu.TabIndex = 2;
            // 
            // tlpRodape
            // 
            tlpRodape.ColumnCount = 2;
            tlpRodape.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 52F));
            tlpRodape.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpRodape.Controls.Add(pnlDivisoria, 0, 0);
            tlpRodape.Controls.Add(pnlDadosUsuario, 1, 2);
            tlpRodape.Controls.Add(iconPictureBox1, 0, 2);
            tlpRodape.Dock = DockStyle.Fill;
            tlpRodape.Location = new Point(0, 0);
            tlpRodape.Margin = new Padding(0);
            tlpRodape.Name = "tlpRodape";
            tlpRodape.Padding = new Padding(5, 10, 5, 5);
            tlpRodape.RowCount = 3;
            tlpRodape.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            tlpRodape.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpRodape.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRodape.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpRodape.Size = new Size(300, 144);
            tlpRodape.TabIndex = 0;
            // 
            // pnlDivisoria
            // 
            pnlDivisoria.BackColor = Color.FromArgb(226, 232, 240);
            tlpRodape.SetColumnSpan(pnlDivisoria, 2);
            pnlDivisoria.Controls.Add(icoUsuario);
            pnlDivisoria.Controls.Add(lblCargo);
            pnlDivisoria.Controls.Add(lblNomeUsuario);
            pnlDivisoria.Dock = DockStyle.Top;
            pnlDivisoria.Location = new Point(5, 10);
            pnlDivisoria.Margin = new Padding(0);
            pnlDivisoria.Name = "pnlDivisoria";
            pnlDivisoria.Size = new Size(290, 54);
            pnlDivisoria.TabIndex = 0;
            // 
            // icoUsuario
            // 
            icoUsuario.BackColor = Color.Transparent;
            icoUsuario.ForeColor = Color.FromArgb(255, 128, 0);
            icoUsuario.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            icoUsuario.IconColor = Color.FromArgb(255, 128, 0);
            icoUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icoUsuario.IconSize = 54;
            icoUsuario.Location = new Point(0, 0);
            icoUsuario.Margin = new Padding(0);
            icoUsuario.Name = "icoUsuario";
            icoUsuario.Size = new Size(58, 54);
            icoUsuario.SizeMode = PictureBoxSizeMode.CenterImage;
            icoUsuario.TabIndex = 1;
            icoUsuario.TabStop = false;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Font = new Font("Segoe UI", 8F);
            lblCargo.ForeColor = Color.FromArgb(100, 116, 139);
            lblCargo.Location = new Point(62, 29);
            lblCargo.Margin = new Padding(4, 0, 4, 0);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(43, 19);
            lblCargo.TabIndex = 2;
            lblCargo.Text = "Dono";
            lblCargo.Click += lblUnidade_Click;
            // 
            // lblNomeUsuario
            // 
            lblNomeUsuario.AutoSize = true;
            lblNomeUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNomeUsuario.ForeColor = Color.FromArgb(15, 23, 42);
            lblNomeUsuario.Location = new Point(62, 9);
            lblNomeUsuario.Margin = new Padding(4, 0, 4, 0);
            lblNomeUsuario.Name = "lblNomeUsuario";
            lblNomeUsuario.Size = new Size(56, 20);
            lblNomeUsuario.TabIndex = 1;
            lblNomeUsuario.Text = "Admin";
            lblNomeUsuario.Click += lblNomeUsuario_Click;
            // 
            // pnlDadosUsuario
            // 
            pnlDadosUsuario.Controls.Add(lblCaixa);
            pnlDadosUsuario.Controls.Add(lblStatusCaixa);
            pnlDadosUsuario.Dock = DockStyle.Fill;
            pnlDadosUsuario.Location = new Point(61, 93);
            pnlDadosUsuario.Margin = new Padding(4);
            pnlDadosUsuario.Name = "pnlDadosUsuario";
            pnlDadosUsuario.Size = new Size(230, 42);
            pnlDadosUsuario.TabIndex = 2;
            // 
            // lblCaixa
            // 
            lblCaixa.AutoSize = true;
            lblCaixa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCaixa.ForeColor = Color.FromArgb(15, 23, 42);
            lblCaixa.Location = new Point(6, 10);
            lblCaixa.Margin = new Padding(4, 0, 4, 0);
            lblCaixa.Name = "lblCaixa";
            lblCaixa.Size = new Size(101, 20);
            lblCaixa.TabIndex = 3;
            lblCaixa.Text = "Caixa aberto!";
            lblCaixa.Click += label1_Click;
            // 
            // lblStatusCaixa
            // 
            lblStatusCaixa.AutoSize = true;
            lblStatusCaixa.Font = new Font("Segoe UI", 8F);
            lblStatusCaixa.ForeColor = Color.FromArgb(22, 163, 74);
            lblStatusCaixa.Location = new Point(0, 42);
            lblStatusCaixa.Margin = new Padding(4, 0, 4, 0);
            lblStatusCaixa.Name = "lblStatusCaixa";
            lblStatusCaixa.Size = new Size(85, 19);
            lblStatusCaixa.TabIndex = 0;
            lblStatusCaixa.Text = "Caixa aberto";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.Dock = DockStyle.Fill;
            iconPictureBox1.ForeColor = Color.FromArgb(22, 163, 74);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            iconPictureBox1.IconColor = Color.FromArgb(22, 163, 74);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 50;
            iconPictureBox1.Location = new Point(5, 89);
            iconPictureBox1.Margin = new Padding(0);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(52, 50);
            iconPictureBox1.TabIndex = 3;
            iconPictureBox1.TabStop = false;
            // 
            // MenuLateral
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            Controls.Add(tlpMenuLateral);
            Margin = new Padding(0);
            MinimumSize = new Size(275, 0);
            Name = "MenuLateral";
            Size = new Size(300, 875);
            tlpMenuLateral.ResumeLayout(false);
            pnlCabecalhoMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogoMenu).EndInit();
            pnlNavegacaoMenu.ResumeLayout(false);
            flpBotoesMenu.ResumeLayout(false);
            pnlRodapeMenu.ResumeLayout(false);
            tlpRodape.ResumeLayout(false);
            pnlDivisoria.ResumeLayout(false);
            pnlDivisoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)icoUsuario).EndInit();
            pnlDadosUsuario.ResumeLayout(false);
            pnlDadosUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMenuLateral;
        private Panel pnlCabecalhoMenu;
        private Panel pnlNavegacaoMenu;
        private Panel pnlRodapeMenu;
        private FontAwesome.Sharp.IconButton btnPainel;
        private FlowLayoutPanel flpBotoesMenu;
        private FontAwesome.Sharp.IconButton btnClientes;
        private FontAwesome.Sharp.IconButton btnPets;
        private FontAwesome.Sharp.IconButton btnServicos;
        private FontAwesome.Sharp.IconButton btnAgendamentos;
        private FontAwesome.Sharp.IconButton btnAtendimentos;
        private FontAwesome.Sharp.IconButton btnPDV;
        private FontAwesome.Sharp.IconButton btnPedidos;
        private FontAwesome.Sharp.IconButton btnEstoque;
        private FontAwesome.Sharp.IconButton btnGestao;
        private FontAwesome.Sharp.IconButton btnRelatorios;
        private FontAwesome.Sharp.IconButton btnFuncionarios;
        private FontAwesome.Sharp.IconButton btnAuditoria;
        private PictureBox picLogoMenu;
        private TableLayoutPanel tlpRodape;
        private Panel pnlDivisoria;
        private Panel pnlDadosUsuario;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label lblStatusCaixa;
        private Label lblNomeUsuario;
        private Label lblCargo;
        private FontAwesome.Sharp.IconPictureBox icoUsuario;
        private Label lblCaixa;
    }
}
