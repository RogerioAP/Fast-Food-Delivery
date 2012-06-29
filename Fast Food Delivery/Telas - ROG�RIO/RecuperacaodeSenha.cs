using System;
using System.Windows.Forms;
using System.Collections;
using System.Net;
using System.Net.Mail;
using System.Configuration;

namespace Telas
{
    public partial class frmRecuperacaodesenha : Form
    {
        ArrayList arr = new ArrayList();
        public frmRecuperacaodesenha()
        {
            InitializeComponent();
        }

        public int erros;
        public string email_usuario, nome_usuario, senha_usuario_software;

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Verifica();
            if( erros == 0) //se tiver tudo certo
            {
                AppSettingsSection appSetSec = configfile.AppSettings;
                if (appSetSec.Settings["email"].Value == string.Empty)
                {
                    MessageBox.Show("Ainda não tem um email configurado para o sistema!", "Erro!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else //se já tiver cadastrado um email para o sistema...
                {
                    Usuario us = new Usuario();
                    arr = us.Usuarios();            //lista os usuários
                    int contador = 0;
                    for (int i = 0; i < arr.Count; i++)
                    {
                        if (txtNome.Text == (((Usuario)arr[i]).Nomecompleto))
                        {
                            try
                            {
                                nome_usuario = (((Usuario)arr[i]).Nomecompleto);
                                senha_usuario_software = (((Usuario)arr[i]).Senha);
                                email_usuario = (((Usuario)arr[i]).Email);

                                this.Cursor = Cursors.WaitCursor;
                                EnviarEmail();
                                DialogResult dialogo = MessageBox.Show("Email enviado!");
                                if (dialogo == DialogResult.OK) { this.Close(); }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Não enviou.\nMotivo: " + ex.Message);
                            }
                            this.Cursor = Cursors.Default;
                            contador++;
                            break;
                        }
                    }

                    if (contador == 0) //caso não seja encotrado o nome digitado entre os usuários executa esse
                    {
                        MessageBox.Show("Não existe esse nome!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        Configuration configfile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        public void EnviarEmail()
        {
            //colocar para enviar o email
            //fazer um for para verificar se o nome completo do usuário EXISTE
            AppSettingsSection appSetSec = configfile.AppSettings;

            string email_sistema = appSetSec.Settings["email"].Value;
            string senha_email_sistema = appSetSec.Settings["senha"].Value;
            string host_sistema = "smtp.gmail.com";
            //MessageBox.Show(email_sistema);

            MailMessage messagem = new MailMessage();
            messagem.To.Add(email_usuario);         //email do USUÁRIO
            messagem.CC.Add(email_sistema);

            messagem.Subject = "Fast Food Delivery - Recuperação de Senha";
            messagem.From = new MailAddress(email_sistema);
            messagem.Body = "A sua senha " + nome_usuario + " no software Fast Food Delivery é:  " + senha_usuario_software  +
                "\n\nDICA: Para sua segurança não escreva sua senha em nenhum local. De preferência, tente memorizá-la!";

            SmtpClient smtp = new SmtpClient();

            smtp.Host = host_sistema;
            smtp.EnableSsl = true;

            smtp.Credentials = new NetworkCredential(email_sistema, senha_email_sistema);
            smtp.Send(messagem);
        }

        public void Verifica()
        {
            erros = 0;
            if(txtNome.Text == string.Empty)
            {
                MessageBox.Show("Os campos com * não podem ser nulos!", "Erro!", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                lblNome.Text = "Nome Completo *";
                lblNome.ForeColor = System.Drawing.Color.Red;
                erros++;
            }
        }
    }
}
