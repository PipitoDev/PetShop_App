namespace PetShop_App
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            flpPainel = new FlowLayoutPanel();
            Painel = new Panel();
            btnPainel = new Button();
            panel4 = new Panel();
            btnClientes = new Button();
            panel5 = new Panel();
            btnPets = new Button();
            panel6 = new Panel();
            button4 = new Button();
            panel3 = new Panel();
            button8 = new Button();
            flpPainel.SuspendLayout();
            Painel.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(879, 48);
            panel1.TabIndex = 0;
            // 
            // flpPainel
            // 
            flpPainel.BackColor = Color.White;
            flpPainel.Controls.Add(Painel);
            flpPainel.Controls.Add(panel4);
            flpPainel.Controls.Add(panel5);
            flpPainel.Controls.Add(panel6);
            flpPainel.Controls.Add(panel3);
            flpPainel.Location = new Point(0, 0);
            flpPainel.Name = "flpPainel";
            flpPainel.Size = new Size(185, 558);
            flpPainel.TabIndex = 1;
            // 
            // Painel
            // 
            Painel.Controls.Add(btnPainel);
            Painel.Location = new Point(3, 3);
            Painel.Name = "Painel";
            Painel.Size = new Size(153, 71);
            Painel.TabIndex = 8;
            // 
            // btnPainel
            // 
            btnPainel.Location = new Point(20, 13);
            btnPainel.Name = "btnPainel";
            btnPainel.Size = new Size(112, 36);
            btnPainel.TabIndex = 2;
            btnPainel.Text = "Painel";
            btnPainel.UseVisualStyleBackColor = true;
            btnPainel.Click += button1_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnClientes);
            panel4.Location = new Point(3, 80);
            panel4.Name = "panel4";
            panel4.Size = new Size(153, 71);
            panel4.TabIndex = 9;
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(20, 13);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(112, 36);
            btnClientes.TabIndex = 2;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnPets);
            panel5.Location = new Point(3, 157);
            panel5.Name = "panel5";
            panel5.Size = new Size(153, 71);
            panel5.TabIndex = 9;
            // 
            // btnPets
            // 
            btnPets.Location = new Point(20, 13);
            btnPets.Name = "btnPets";
            btnPets.Size = new Size(112, 36);
            btnPets.TabIndex = 2;
            btnPets.Text = "Pets";
            btnPets.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(button4);
            panel6.Location = new Point(3, 234);
            panel6.Name = "panel6";
            panel6.Size = new Size(153, 71);
            panel6.TabIndex = 9;
            // 
            // button4
            // 
            button4.Location = new Point(20, 13);
            button4.Name = "button4";
            button4.Size = new Size(112, 36);
            button4.TabIndex = 2;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(button8);
            panel3.Location = new Point(3, 311);
            panel3.Name = "panel3";
            panel3.Size = new Size(153, 71);
            panel3.TabIndex = 9;
            // 
            // button8
            // 
            button8.Location = new Point(12, 14);
            button8.Name = "button8";
            button8.Size = new Size(112, 36);
            button8.TabIndex = 2;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(878, 544);
            Controls.Add(flpPainel);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            flpPainel.ResumeLayout(false);
            Painel.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flpPainel;
        private Button btnPainel;
        private Panel Painel;
        private Button button8;
        private Panel panel3;
        private Panel panel4;
        private Button btnClientes;
        private Panel panel5;
        private Button btnPets;
        private Panel panel6;
        private Button button4;
    }
}