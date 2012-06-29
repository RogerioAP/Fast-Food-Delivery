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
    public partial class Editarusuario : Form
    {
        int idu;
        Usuario us = new Usuario();
        ArrayList arr = new ArrayList();
        
        public Editarusuario()
        {
            InitializeComponent();
        }
        
        public Editarusuario(int id) //construtor para alterar o USUÁRIO
        {
            InitializeComponent();

            idu = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int t = 0;//se  o login é valido ou não
            //for (int i = 0; i < arr.Count || t != 0; i++) //for para verificar se se o LOGiN já está sendo utilizado
            //{
            //    if (txtLogin.Text == ((Usuario)arr[i]).Login)
            //    {
            //        MessageBox.Show("Esse login já esta sendo usado.", "Erro!",
            //                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        t++;
            //    }
            //}

            //if (t == 0) //se o login for ÚNICO (ou seja, se tiver somente ele) executa esse
            //{

            if (rbtSim.Checked == true) //caso esteja marcado que DESEJA ALTERÁ A SENHA
            {
                if (txtSenha.Text == txtSenha1.Text) //se as senhas forem iguais
                {
                    us.Nomecompleto = txtNome.Text;
                    us.Login = txtLogin.Text;

                    if (rdbGerente.Checked == true)
                    {
                        us.Tipodeconta = "administrador";
                    }
                    else if (rdbUsuario.Checked == true)
                    {
                        us.Tipodeconta = "funcionario";
                    }

                    us.Senha = txtSenha.Text;
                    us.Email = txtemail.Text;

                    try
                    {
                        us.Editar(idu/*((Usuario)arr[0]).Codigo*/); //altera o usuário
                        MessageBox.Show("Os dados foram alterado com sucesso!", "Concluído!", MessageBoxButtons.OK,
                            MessageBoxIcon.Asterisk);
                    }
                    catch (Exception h)
                    {
                        MessageBox.Show("Não foi possível editar o usuário.\n" + h.Message, "Erro!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.Close();
                }
                else //caso as senhas forem diferentes
                {
                    MessageBox.Show("As senhas digitadas não são iguais", "Erro!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rbtNao.Checked == true) //caso esteja marcado que NÃO QUER ALTERAR A SENHA executa esse
            {
                us.Nomecompleto = txtNome.Text;
                us.Login = txtLogin.Text;

                if (rdbGerente.Checked == true)
                {
                    us.Tipodeconta = "administrador";
                }
                else if (rdbUsuario.Checked == true)
                {
                    us.Tipodeconta = "funcionario";
                }

                us.Email = txtemail.Text;

                try
                {
                    us.Editar_sem_senha(idu/*((Usuario)arr[0]).Codigo*/);
                    MessageBox.Show("Os dados foram alterado com sucesso!", "Concluído!", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                }
                catch (Exception h)
                {
                    MessageBox.Show("Não foi possível editar o usuário.\n" + h.Message, "Erro!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.Close();
            }

            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Editarusuario_Load(object sender, EventArgs e)
        {
            arr = us.listar(idu);

            rbtNao.Checked = true;
            txtSenha.Enabled = false;
            txtSenha1.Enabled = false;

            txtNome.Text = ((Usuario)arr[0]).Nomecompleto;

            txtLogin.Text = ((Usuario)arr[0]).Login;

            txtemail.Text = ((Usuario)arr[0]).Email;
            
            rdbGerente.Checked = true;
        }

        private void rbtSim_CheckedChanged(object sender, EventArgs e)
        {
            txtSenha.Enabled = true;
            txtSenha1.Enabled = true;
        }

        private void rbtNao_CheckedChanged(object sender, EventArgs e)
        {
            txtSenha.Enabled = false;
            txtSenha1.Enabled = false;
        }
    }
}
