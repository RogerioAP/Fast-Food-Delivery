using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Telas
{
    public partial class frmEnviarPDF : Form
    {
        public static string email, messagem;
        public static bool enviar = false;

        public frmEnviarPDF()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtDestino.Text == string.Empty)
            {
                MessageBox.Show("Defina o email para ser enviado o relatório!", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                email = txtDestino.Text;
                messagem = txtBody.Text;
                enviar = true;
                Close();
            }
        }
    }
}
