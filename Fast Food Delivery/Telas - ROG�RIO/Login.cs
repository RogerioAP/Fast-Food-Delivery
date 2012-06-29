using System;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Drawing;

namespace Telas
{
    public partial class frmLogin : Form
    {
        ArrayList arr = new ArrayList();

        public frmLogin()
        {
            InitializeComponent();
        }

        public void MudarLabel()
        {
            lblLogin.Text = "Login *";
            lblSenha.Text = "Senha *";
            lblLogin.ForeColor = Color.Red;
            lblSenha.ForeColor = Color.Red;
        }

        public int erros = 0; //para saber se o usuário esqueceu a senha
        public void btnOk_Click(object sender, EventArgs e)
        {
            int contador = 0;
            if (txtLogin.Text == string.Empty || txtSenha.Text == string.Empty) //verificar se existe algum campo vazio
            {
                MessageBox.Show("Os campos com * têm que ser preenchidos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MudarLabel();
                contador++;
            }

            else
            {
                Usuario us = new Usuario();
                arr = us.Usuarios();

                for (int i = 0; i < arr.Count; i++) //procura no banco de dados o login e a senha
                {
                    if (txtLogin.Text == (((Usuario)arr[i]).Login))
                    {
                        if (txtSenha.Text == (((Usuario)arr[i]).Senha))
                        {
                            us.UsuarioAtivo((((Usuario)arr[i]).Nomecompleto));
                            us.TipodeConta((((Usuario)arr[i]).Tipodeconta));
                            lblLogin.Text = "Login"; //a partir daqui as palavras ficam "normais"
                            lblSenha.Text = "Senha";
                            lblLogin.ForeColor = Color.Black;
                            lblSenha.ForeColor = Color.Black;
                            txtLogin.Text = null;
                            txtSenha.Text = null;
                            erros = 0;
                            new frmPainel().ShowDialog();
                            contador++;
                        }
                    }
                }
                
                if (erros == 2) //se errar a senha no mínimo três vezes
                {
                    DialogResult dialogo = MessageBox.Show("Login e ou senha incorreto(s)!\nVocê esqueceu sua senha?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    txtSenha.Text = null;

                    if (dialogo == DialogResult.Yes) //manda um email para o login, com a senha
                    {
                        new frmRecuperacaodesenha().ShowDialog(); //chama esta tela para recuperar
                    }                                           // a senha pelo email
                }
                else if (contador == 0) //se não tiver o login com o respectivo usuário, esse será executado
                {
                    MessageBox.Show("Login e ou senha incorreto(s)!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSenha.Text = null;
                    erros++;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            arr = new Usuario().Condicaoligar();
            int contador = 0;
            for (int i = 0; i < arr.Count; i++ )
            {
                if((((Usuario)arr[i]).Ligar) == "S")
                {
                    Process.Start("shutdown", "/s /t 0");  //marcar para desligar o PC
                    contador++;
                    break;
                }
            }

            if(contador == 0)
            {
                Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk.exe"); //inicia o teclado virtual
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            /*Apaga e depois cria a pasta RELATORIOS para dá a possibilidade de poder enviar mais de um PDF em um
             mesmo tempo de execução. Pois estava dando PROBLEMA, porque quando iria criar um "2º" PDF em mesmo tempo
             de execução o software estava tentando substituir o "1º" PDF que de acordo com o sistema ainda
             tinha uma thread pendente.
             Porém não dava para excluir o PDF que foi criado temporariamente, pois, como já disse tinha uma thread
             pendente*/

            string pasta = Path.Combine("Relatorios");
            if (Directory.Exists(pasta)) //serve quando for a 1º vez que executar esse software em um PC
            {
                Directory.Delete(pasta, true);       //deleta a pasta de relatório e o conteúdo
                Directory.CreateDirectory(pasta);        //cria a pasta
            }
            else
            {
                Directory.CreateDirectory(pasta);        //cria a pasta
            }
        }

            //string a = txtLogin.Text;
            //for (int i = 0; i < txtLogin.TextLength; i++)
            //{
            //    MessageBox.Show("Letra é " + a[i]);
            //}
    }
}
