using PetShop_App.Componentes;

namespace PetShop_App.Telas.Principal;

partial class Principal
{
    private System.ComponentModel.IContainer? components;
    protected override void Dispose(bool disposing) { if (disposing) components?.Dispose(); base.Dispose(disposing); }
    private void InitializeComponent()
    {
        menuLateral = new MenuLateral();
        pnlTopo = new Panel();
        lblSaudacao = new Label();
        lblData = new Label();
        txtBuscaGlobal = new TextBox();
        pnlConteudo = new Panel();
        pnlTopo.SuspendLayout(); SuspendLayout();
        menuLateral.Dock = DockStyle.Left; menuLateral.Location = new Point(0,0); menuLateral.Name = "menuLateral"; menuLateral.Size = new Size(240,900); menuLateral.TabIndex = 0;
        pnlTopo.BackColor = Color.White; pnlTopo.Controls.Add(txtBuscaGlobal); pnlTopo.Controls.Add(lblData); pnlTopo.Controls.Add(lblSaudacao); pnlTopo.Dock = DockStyle.Top; pnlTopo.Location = new Point(240,0); pnlTopo.Name = "pnlTopo"; pnlTopo.Padding = new Padding(24,12,24,10); pnlTopo.Size = new Size(1200,72); pnlTopo.TabIndex = 1;
        lblSaudacao.AutoSize = true; lblSaudacao.Font = new Font("Segoe UI",10F,FontStyle.Bold); lblSaudacao.ForeColor = Color.FromArgb(15,23,42); lblSaudacao.Location = new Point(24,14); lblSaudacao.Name = "lblSaudacao"; lblSaudacao.Text = "Bom dia, Funcionário";
        lblData.AutoSize = true; lblData.ForeColor = Color.FromArgb(100,116,139); lblData.Location = new Point(24,38); lblData.Name = "lblData"; lblData.Text = "segunda-feira, 20/10/2026";
        txtBuscaGlobal.Anchor = AnchorStyles.Top | AnchorStyles.Right; txtBuscaGlobal.Font = new Font("Segoe UI",11F); txtBuscaGlobal.Location = new Point(746,20); txtBuscaGlobal.Name = "txtBuscaGlobal"; txtBuscaGlobal.PlaceholderText = "Buscar cliente, pet ou serviço"; txtBuscaGlobal.Size = new Size(430,27); txtBuscaGlobal.TabIndex = 2;
        pnlConteudo.BackColor = Color.FromArgb(241,245,249); pnlConteudo.Dock = DockStyle.Fill; pnlConteudo.Location = new Point(240,72); pnlConteudo.Name = "pnlConteudo"; pnlConteudo.Padding = new Padding(26); pnlConteudo.Size = new Size(1200,828); pnlConteudo.TabIndex = 2;
        AutoScaleDimensions = new SizeF(7F,15F); AutoScaleMode = AutoScaleMode.Font; BackColor = Color.FromArgb(241,245,249); ClientSize = new Size(1440,900); Controls.Add(pnlConteudo); Controls.Add(pnlTopo); Controls.Add(menuLateral); MinimumSize = new Size(1100,700); Name = "Principal"; StartPosition = FormStartPosition.CenterScreen; Text = "PetShop Central — Gestão"; WindowState = FormWindowState.Maximized;
        pnlTopo.ResumeLayout(false); pnlTopo.PerformLayout(); ResumeLayout(false);
    }
    private MenuLateral menuLateral = null!; private Panel pnlTopo = null!; private Label lblSaudacao = null!; private Label lblData = null!; private TextBox txtBuscaGlobal = null!; private Panel pnlConteudo = null!;
}
