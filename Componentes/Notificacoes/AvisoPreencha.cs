using System;
using System.Windows.Forms;

namespace PetShop_App
{
    /// <summary>Janela modal padronizada para avisos de validação e conexão.</summary>
    public partial class DialogoAviso : Form
    {
        public DialogoAviso()
        {
            InitializeComponent();
        }

        /// <summary>Preenche título e mensagem mantendo o layout definido no Designer.</summary>
        public DialogoAviso(string titulo, string mensagem) : this()
        {
            lblTitulo.Text = titulo;
            lblMensagem.Text = mensagem;
            Text = titulo;
        }
    }
}
