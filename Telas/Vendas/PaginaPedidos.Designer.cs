#nullable disable
namespace PetShop_App.Telas.Vendas
{
    partial class PaginaPedidos
    {
        private DataGridViewTextBoxColumn gradePedidosColNumero;

private DataGridViewTextBoxColumn gradePedidosColCliente;

private DataGridViewTextBoxColumn gradePedidosColData;

private DataGridViewTextBoxColumn gradePedidosColTotal;

private DataGridViewTextBoxColumn gradePedidosColStatus;

private DataGridViewTextBoxColumn gradePedidosColPagamento;

private System.ComponentModel.IContainer components;

protected override void Dispose(bool disposing)
{
    if (disposing && components != null) components.Dispose();

    base.Dispose(disposing);

}
private void InitializeComponent()
        {
components = new System.ComponentModel.Container();

            lblTitulo = new Label();

lblTitulo.Name = "lblTitulo";

            lblResumo = new Label();

lblResumo.Name = "lblResumo";

            btnAtualizar = new Button();

btnAtualizar.Name = "btnAtualizar";

            gradePedidos = new DataGridView();

gradePedidos.Name = "gradePedidos";

gradePedidosColNumero = new DataGridViewTextBoxColumn();

gradePedidosColNumero.Name = "Numero";

gradePedidosColNumero.DataPropertyName = "Numero";

gradePedidosColNumero.HeaderText = "Numero";

gradePedidosColCliente = new DataGridViewTextBoxColumn();

gradePedidosColCliente.Name = "Cliente";

gradePedidosColCliente.DataPropertyName = "Cliente";

gradePedidosColCliente.HeaderText = "Cliente";

gradePedidosColData = new DataGridViewTextBoxColumn();

gradePedidosColData.Name = "Data";

gradePedidosColData.DataPropertyName = "Data";

gradePedidosColData.HeaderText = "Data";

gradePedidosColTotal = new DataGridViewTextBoxColumn();

gradePedidosColTotal.Name = "Total";

gradePedidosColTotal.DataPropertyName = "Total";

gradePedidosColTotal.HeaderText = "Total";

gradePedidosColStatus = new DataGridViewTextBoxColumn();

gradePedidosColStatus.Name = "Status";

gradePedidosColStatus.DataPropertyName = "Status";

gradePedidosColStatus.HeaderText = "Status";

gradePedidosColPagamento = new DataGridViewTextBoxColumn();

gradePedidosColPagamento.Name = "Pagamento";

gradePedidosColPagamento.DataPropertyName = "Pagamento";

gradePedidosColPagamento.HeaderText = "Pagamento";

gradePedidos.AutoGenerateColumns = false;

gradePedidos.Columns.AddRange(new DataGridViewColumn[] { gradePedidosColNumero, gradePedidosColCliente, gradePedidosColData, gradePedidosColTotal, gradePedidosColStatus, gradePedidosColPagamento });

            ((System.ComponentModel.ISupportInitialize)gradePedidos).BeginInit();

            SuspendLayout();

            lblTitulo.AutoSize = true;

            lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);

            lblTitulo.Location = new Point(0, 4);

            lblTitulo.Text = "Pedidos";

            lblResumo.AutoSize = true;

            lblResumo.ForeColor = Color.FromArgb(100, 116, 139);

            lblResumo.Location = new Point(0, 48);

            lblResumo.Text = "Histórico e andamento dos pedidos";

            btnAtualizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            btnAtualizar.BackColor = Color.FromArgb(255, 128, 0);

            btnAtualizar.ForeColor = Color.White;

            btnAtualizar.FlatStyle = FlatStyle.Flat;

            btnAtualizar.Location = new Point(850, 8);

            btnAtualizar.Size = new Size(130, 40);

            btnAtualizar.Text = "Atualizar";

            gradePedidos.AllowUserToAddRows = false;

            gradePedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            gradePedidos.BackgroundColor = Color.White;

            gradePedidos.BorderStyle = BorderStyle.None;

            gradePedidos.Location = new Point(0, 82);

            gradePedidos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            gradePedidos.Size = new Size(1000, 618);

            gradePedidos.ReadOnly = true;

            gradePedidos.RowHeadersVisible = false;

            BackColor = Color.FromArgb(241, 245, 249);

            Controls.AddRange(new Control[] { lblTitulo, lblResumo, btnAtualizar, gradePedidos });

            Name = "PaginaPedidos";

            Size = new Size(1000, 700);

            ((System.ComponentModel.ISupportInitialize)gradePedidos).EndInit();

            ResumeLayout(false);

            PerformLayout();

        }
        private Label lblTitulo, lblResumo;

        private Button btnAtualizar;

        private DataGridView gradePedidos;

    }

}
