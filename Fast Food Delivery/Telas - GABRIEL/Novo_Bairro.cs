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
    public partial class frmNovobairro : Form
    {
        public frmNovobairro()
        {
            InitializeComponent();
        }

        public frmNovobairro(string g)
        {
            InitializeComponent();

            txtNome.Text = g;
            txtPerfrete.TabIndex = 0;
            txtValfrete.TabIndex = 1;
            txtTempoestimado.TabIndex = 2;
            button1.TabIndex = 3;
            button2.TabIndex = 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == null)
            {
                MessageBox.Show("Os campos marcados com * precisam ser preenchidos!", "Erro!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                Bairro bar = new Bairro();
                //
                bar.Nome = txtNome.Text;
                bar.Percentual = txtPerfrete.Text;
                bar.Valordeentrega = txtValfrete.Text;
                bar.Tempodeentrega = txtTempoestimado.Text;
                
                try
                {
                    bar.Salvarbairro();

                    MessageBox.Show("Bairro cadastrado com sucesso!", "Concluído!", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                }
                catch (Exception h)
                {
                    MessageBox.Show("Não foi possível editar o bairro.\n" + h.Message, "Erro!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
