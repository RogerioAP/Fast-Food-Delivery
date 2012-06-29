using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;

namespace Telas
{
    public partial class frmAlterarsenha : Form
    {
        ArrayList arr = new ArrayList();
        Usuario us = new Usuario();
        public frmAlterarsenha()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (txtNomecompleto.Text != string.Empty || txtLogin.Text != string.Empty || txtSenha.Text != string.Empty)
            {
                DialogResult di = MessageBox.Show("A alteração não foi concluído!\nDeseja sair assim mesmo?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(di == DialogResult.Yes)
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
        }

        public void Verificarcampos()
        {
            lblNomecompleto.ForeColor = Color.Red;
            lblLogin.ForeColor = Color.Red;
            lblNovasenha.ForeColor = Color.Red;

            lblNomecompleto.Text = "Nome Completo *";
            lblLogin.Text = "Login *";
            lblNovasenha.Text = "Nova Senha *";
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int cont = 0, existe = 0;
            if(txtNomecompleto.Text == string.Empty || txtLogin.Text == string.Empty || txtSenha.Text == string.Empty)
            {
                MessageBox.Show("Os campos com * não podem ser nulos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cont++;
                Verificarcampos();
            }
            if(cont==0)
            {
                try
                {
                    arr = us.Usuarios();
                    for (int i = 0; i < arr.Count;i++ )
                    {
                        if (txtNomecompleto.Text == (((Usuario)arr[i]).Nomecompleto))
                        {
                            if (txtLogin.Text == (((Usuario)arr[i]).Login))
                            {
                                existe++;
                                us.Alterar(txtSenha.Text, (((Usuario)arr[i]).Codigo));
                                break;
                            }
                        }
                    }
                    if (existe > 0)
                    {
                        MessageBox.Show("Alteração realizada com sucesso!\n\nLogin: " + txtLogin.Text + "\nNova Senha: " + txtSenha.Text, "Concluído!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Limpar();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("O usuário não existe!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception s)
                {
                    MessageBox.Show("A alteração não pode ser feita!\nMotivo: " + s.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void Limpar()
        {
            txtLogin.Text = null;
            txtSenha.Text = null;
        }
    }
}
