using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Telas
{
    public partial class frmEditarbairros : Form
    {
        ArrayList arr = new ArrayList();
        Bairro bar = new Bairro();

        public int idB=0;

        public frmEditarbairros()
        {
            InitializeComponent();
        }

        public frmEditarbairros(int id)
        {
            idB = id;
            InitializeComponent();

            arr = bar.listar(id); //busca no BD pelo id passado

            txtNome.Text = ((Bairro)arr[0]).Nome;
            txtPerfrete.Text = (((Bairro)arr[0]).Percentual).ToString();
            txtValfrete.Text = (((Bairro)arr[0]).Valordeentrega).ToString();
            txtTempoestimado.Text = (((Bairro)arr[0]).Tempodeentrega).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == null)
            {
                MessageBox.Show("Os campos marcados com * precisam se preenchidos!", "Erro!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                bar.Nome = txtNome.Text;
                bar.Percentual = txtPerfrete.Text;
                bar.Valordeentrega = txtValfrete.Text;
                bar.Tempodeentrega = txtTempoestimado.Text;
                bar.Idbairro = idB;

                try
                {
                    bar.Alterarbairro(int.Parse((((Bairro)arr[0]).Idbairro).ToString()));
                    MessageBox.Show("Os dados foram alterado com sucesso!", "Concluído!", MessageBoxButtons.OK,
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
