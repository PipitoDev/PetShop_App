namespace PetShop_App
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            plLadoDireito = new Panel();
            SuspendLayout();
            // 
            // plLadoDireito
            // 
            plLadoDireito.Dock = DockStyle.Fill;
            plLadoDireito.Location = new Point(0, 0);
            plLadoDireito.Margin = new Padding(4, 3, 4, 3);
            plLadoDireito.Name = "plLadoDireito";
            plLadoDireito.Size = new Size(884, 561);
            plLadoDireito.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(plLadoDireito);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(898, 593);
            Name = "Form1";
            Text = "PetShop";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel plLadoDireito;
    }
}
