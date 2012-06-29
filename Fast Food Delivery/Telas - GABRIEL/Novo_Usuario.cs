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
    public partial class frmNovo_usuario : Form
    {
        Usuario us = new Usuario();
        ArrayList arr = new ArrayList();
        
        public frmNovo_usuario()
        {
            InitializeComponent();
        }

        public frmNovo_usuario(int a) 
        {                              
            InitializeComponent();

            rdbgerente.Checked = true;
            rdbgerente.Enabled = false;
            rdbusuario.Enabled = false;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtsenha.Text == txtsenha1.Text)
            {
                us.Nomecompleto = txtNome.Text;

                us.Login = txtlogin.Text;
                
                if (rdbgerente.Checked == true)
                {
                    us.Tipodeconta = "administrador";
                }
                else if (rdbusuario.Checked == true)
                {
                    us.Tipodeconta = "funcionario";
                }
                
                us.Senha = txtsenha.Text;
                
                us.Email = txtemail.Text;
                
                try
                {
                    us.SalvarUsuario();
                    DialogResult dialogo = MessageBox.Show("Os dados foram inseridos com sucesso!", "Concluído!",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if (dialogo == DialogResult.OK)
                    {
                        Close();
                    }
                }
                catch (Exception h)
                {
                    MessageBox.Show("Não foi possível adicionar o usuário.\n" + h.Message, "Erro!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("As senhas digitadas não estão iguais!", "Erro!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}