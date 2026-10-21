namespace PetShop_App.Telas.Vendas;

partial class PaginaPDV
{
    private void InitializeComponent()
    {
        lblTitulo = new Label(); lblCliente = new Label(); cmbCliente = new ComboBox(); txtBusca = new TextBox(); numQuantidade = new NumericUpDown();
        lblStatusCaixa = new Label(); btnAbrirCaixa = new Button(); btnFecharCaixa = new Button();
        split = new SplitContainer(); gradeProdutos = new DataGridView(); btnAdicionar = new Button(); gradeCarrinho = new DataGridView(); btnRemover = new Button();
        pnlFechamento = new Panel(); lblItens = new Label(); lblSubtotal = new Label(); lblDesconto = new Label(); numDesconto = new NumericUpDown(); cmbPagamento = new ComboBox(); lblTotal = new Label(); btnLimpar = new Button(); btnFinalizar = new Button();
        ((System.ComponentModel.ISupportInitialize)numQuantidade).BeginInit(); ((System.ComponentModel.ISupportInitialize)split).BeginInit(); split.Panel1.SuspendLayout(); split.Panel2.SuspendLayout(); split.SuspendLayout(); ((System.ComponentModel.ISupportInitialize)gradeProdutos).BeginInit(); ((System.ComponentModel.ISupportInitialize)gradeCarrinho).BeginInit(); ((System.ComponentModel.ISupportInitialize)numDesconto).BeginInit(); pnlFechamento.SuspendLayout(); SuspendLayout();

        lblTitulo.AutoSize = true; lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold); lblTitulo.Location = new Point(0, 0); lblTitulo.Text = "PDV — Nova venda";
        lblCliente.AutoSize = true; lblCliente.Location = new Point(390, 9); lblCliente.Text = "Cliente"; cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList; cmbCliente.Location = new Point(390, 28); cmbCliente.Size = new Size(260, 23);
        lblStatusCaixa.AutoSize = true; lblStatusCaixa.Font = new Font("Segoe UI", 9F, FontStyle.Bold); lblStatusCaixa.Location = new Point(680, 8); lblStatusCaixa.Text = "● Caixa fechado"; lblStatusCaixa.ForeColor = Color.FromArgb(220, 38, 38);
        btnAbrirCaixa.Location = new Point(680, 31); btnAbrirCaixa.Size = new Size(140, 34); btnAbrirCaixa.Text = "Abrir caixa"; btnAbrirCaixa.BackColor = Color.FromArgb(22, 163, 74); btnAbrirCaixa.ForeColor = Color.White; btnAbrirCaixa.FlatStyle = FlatStyle.Flat;
        btnFecharCaixa.Location = new Point(830, 31); btnFecharCaixa.Size = new Size(140, 34); btnFecharCaixa.Text = "Fechar caixa"; btnFecharCaixa.BackColor = Color.FromArgb(220, 38, 38); btnFecharCaixa.ForeColor = Color.White; btnFecharCaixa.FlatStyle = FlatStyle.Flat;
        txtBusca.Location = new Point(0, 66); txtBusca.PlaceholderText = "Buscar produto por nome ou código"; txtBusca.Size = new Size(330, 23); numQuantidade.Location = new Point(338, 66); numQuantidade.Minimum = 1; numQuantidade.Maximum = 999; numQuantidade.Value = 1; numQuantidade.Size = new Size(70, 23);
        split.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right; split.Location = new Point(0, 100); split.Size = new Size(1000, 455); split.SplitterDistance = 480;
        gradeProdutos.AllowUserToAddRows = false; gradeProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; gradeProdutos.BackgroundColor = Color.White; gradeProdutos.Dock = DockStyle.Fill; gradeProdutos.ReadOnly = true; gradeProdutos.RowHeadersVisible = false; gradeProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        btnAdicionar.Dock = DockStyle.Bottom; btnAdicionar.Height = 44; btnAdicionar.BackColor = Color.FromArgb(255, 128, 0); btnAdicionar.FlatStyle = FlatStyle.Flat; btnAdicionar.ForeColor = Color.White; btnAdicionar.Text = "Adicionar ao carrinho"; split.Panel1.Controls.Add(gradeProdutos); split.Panel1.Controls.Add(btnAdicionar);
        gradeCarrinho.AllowUserToAddRows = false; gradeCarrinho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; gradeCarrinho.BackgroundColor = Color.White; gradeCarrinho.Dock = DockStyle.Fill; gradeCarrinho.ReadOnly = true; gradeCarrinho.RowHeadersVisible = false; gradeCarrinho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        btnRemover.Dock = DockStyle.Bottom; btnRemover.Height = 36; btnRemover.Text = "Remover item selecionado"; split.Panel2.Controls.Add(gradeCarrinho); split.Panel2.Controls.Add(btnRemover);
        pnlFechamento.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right; pnlFechamento.BackColor = Color.White; pnlFechamento.Location = new Point(0, 565); pnlFechamento.Size = new Size(1000, 135);
        lblItens.Location = new Point(16, 14); lblItens.Text = "0 item(ns)"; lblSubtotal.Location = new Point(16, 40); lblSubtotal.Text = "Subtotal: R$ 0,00"; lblDesconto.Location = new Point(250, 14); lblDesconto.Text = "Desconto (%)"; numDesconto.Location = new Point(250, 38); numDesconto.Maximum = 50; numDesconto.Size = new Size(100, 23);
        cmbPagamento.DropDownStyle = ComboBoxStyle.DropDownList; cmbPagamento.Items.AddRange(["PIX", "Cartão de crédito", "Cartão de débito", "Dinheiro"]); cmbPagamento.Location = new Point(380, 38); cmbPagamento.Size = new Size(190, 23); cmbPagamento.SelectedIndex = 0;
        lblTotal.AutoSize = true; lblTotal.Font = new Font("Segoe UI", 20F, FontStyle.Bold); lblTotal.ForeColor = Color.FromArgb(255, 128, 0); lblTotal.Location = new Point(590, 25); lblTotal.Text = "Total: R$ 0,00";
        btnLimpar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right; btnLimpar.Location = new Point(716, 82); btnLimpar.Size = new Size(120, 38); btnLimpar.Text = "Limpar venda";
        btnFinalizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right; btnFinalizar.BackColor = Color.FromArgb(255, 128, 0); btnFinalizar.FlatStyle = FlatStyle.Flat; btnFinalizar.ForeColor = Color.White; btnFinalizar.Font = new Font("Segoe UI", 10F, FontStyle.Bold); btnFinalizar.Location = new Point(844, 82); btnFinalizar.Size = new Size(140, 38); btnFinalizar.Text = "Finalizar venda";
        pnlFechamento.Controls.AddRange([lblItens, lblSubtotal, lblDesconto, numDesconto, cmbPagamento, lblTotal, btnLimpar, btnFinalizar]);
        BackColor = Color.FromArgb(241, 245, 249); Controls.AddRange([lblTitulo, lblCliente, cmbCliente, lblStatusCaixa, btnAbrirCaixa, btnFecharCaixa, txtBusca, numQuantidade, split, pnlFechamento]); Name = "PaginaPDV"; Size = new Size(1000, 700);
        ((System.ComponentModel.ISupportInitialize)numQuantidade).EndInit(); split.Panel1.ResumeLayout(false); split.Panel2.ResumeLayout(false); ((System.ComponentModel.ISupportInitialize)split).EndInit(); split.ResumeLayout(false); ((System.ComponentModel.ISupportInitialize)gradeProdutos).EndInit(); ((System.ComponentModel.ISupportInitialize)gradeCarrinho).EndInit(); ((System.ComponentModel.ISupportInitialize)numDesconto).EndInit(); pnlFechamento.ResumeLayout(false); pnlFechamento.PerformLayout(); ResumeLayout(false); PerformLayout();
    }

    private Label lblTitulo = null!, lblCliente = null!, lblItens = null!, lblSubtotal = null!, lblDesconto = null!, lblTotal = null!, lblStatusCaixa = null!;
    private ComboBox cmbCliente = null!, cmbPagamento = null!;
    private TextBox txtBusca = null!;
    private NumericUpDown numQuantidade = null!, numDesconto = null!;
    private SplitContainer split = null!;
    private DataGridView gradeProdutos = null!, gradeCarrinho = null!;
    private Panel pnlFechamento = null!;
    private Button btnAdicionar = null!, btnRemover = null!, btnLimpar = null!, btnFinalizar = null!, btnAbrirCaixa = null!, btnFecharCaixa = null!;
}
