using System;
using System.Windows.Forms;

namespace PetShop_App
{
    public partial class DialogoAviso : Form
    {
        public DialogoAviso()
        {
            InitializeComponent();
        }

        public DialogoAviso(string titulo, string mensagem) : this()
        {
            lblTitulo.Text = titulo;
            lblMensagem.Text = mensagem;
            Text = titulo;
        }
    }
}
