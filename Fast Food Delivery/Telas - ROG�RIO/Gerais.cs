using System;
using System.Windows.Forms;
using System.Collections;
using Microsoft.Win32;
using System.Drawing;
using System.Configuration;
using System.Net.Mail;
using System.Net;
using System.IO;
using iTextSharp.text.api;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Diagnostics;
using System.Threading;
using System.Text;

namespace Telas
{
    public partial class frmGerais : Form
    {
        ArrayList arr = new ArrayList();
        RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        //criou esse objeto para mudar se o software vai iniciar ou não com o windows

        public frmGerais()
        {
            InitializeComponent();
        }

        //public void PopularGrid()
        //{
        //    dataGridView1.DataSource = null;
        //    dataGridView1.Rows.Clear();

        //    Usuario us = new Usuario();
        //    arr = us.Smpts();
        //    for (int i = 0; i < arr.Count; i++)
        //    {
        //        dataGridView1.Rows.Add();
        //        dataGridView1[0, i].Value = (((Usuario)arr[i]).Protocolo);
        //    }
        //}

        private void frmGerais_Load(object sender, EventArgs e)
        {
            //AppSettingsSection appSetSec = configfile.AppSettings;
            //txtLogin.Text = appSetSec.Settings["email"].Value.ToString();
            //txtSenha.Text = appSetSec.Settings["senha"].Value.ToString();

            //PopularGrid();

            if (rkApp.GetValue("FastFoodDelivery") == null) //verifica se está marcado para LIGAR
            {
                rbtNaoIniciar.Checked = true;
                rbtSimIniciar.Checked = false;
            }
            else
            {
                rbtSimIniciar.Checked = true;
                rbtNaoIniciar.Checked = false;
            }

            arr = new Usuario().Condicaoligar(); //marcar o radiobutton que é o atual no BD para DESLIGAR
            for (int i = 0; i < arr.Count; i++)
            {
                if ((((Usuario)arr[i]).Ligar) == "S")
                {
                    rbtSimDesligar.Checked = true;
                    break;
                }
                else if ((((Usuario)arr[i]).Ligar) == "N")
                {
                    rbtNaoDesligar.Checked = true;
                    break;
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        Configuration configfile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        public void EnviarEmail()
        {
            AppSettingsSection appSetSec = configfile.AppSettings;

            string email_sistema = txtLogin.Text;
            string senha_sistema = txtSenha.Text;
            string host_sistema = "smtp.gmail.com"/*appSetSec.Settings["hostemail"].Value*/;

            MailMessage messagem = new MailMessage();
            messagem.To.Add(email_sistema); //vai ter que fazer uma busca no BD para pegar o login do email
            messagem.CC.Add(email_sistema); //este vai ser o email do sistema

            //messagem.Priority = MailPriority.Normal;
            //messagem.IsBodyHtml = true;


            messagem.Subject = "Fast Food Delivery - Email do Sistema";         //assunto
            messagem.From = new MailAddress(email_sistema);         //esse é o email do software
            messagem.Body = "O teste do email do software FAST FOOD DELIVERY funcionou perfeitamente!" +
                " O email já está registrado no software!";

            //messagem.SubjectEncoding = Encoding.GetEncoding("ISO-8859-1");
            //messagem.BodyEncoding = Encoding.GetEncoding("ISO-8859-1");
 
            SmtpClient smtp = new SmtpClient();

            smtp.Host = host_sistema;
            smtp.EnableSsl = true;

            smtp.Credentials = new NetworkCredential(email_sistema, senha_sistema);
            smtp.Send(messagem);

            appSetSec.Settings["email"].Value = txtLogin.Text;
            appSetSec.Settings["senha"].Value = txtSenha.Text;

            //para salvar o arquivo modificado alinha abaixo
            configfile.Save(ConfigurationSaveMode.Modified);
            //faz a atualização do appSettings abaixo
            ConfigurationManager.RefreshSection("appSettings");
        }

        public void Mudarlabel()
        {
            lblLogin.ForeColor = Color.Red;
            lblSenha.ForeColor = Color.Red;
            lblLogin.Text = "Login do Email *";
            lblSenha.Text = "Senha do Email *";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text == string.Empty && txtSenha.Text == string.Empty)
            {
                MessageBox.Show("Os campos com * não podem ser nulos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Mudarlabel();
            }
            else
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    EnviarEmail();
                    MessageBox.Show("Email de teste enviado e adicionado ao software com sucesso!", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch(Exception ew)
                {
                    MessageBox.Show("Erro ao enviar email!\nMotivo: " + ew.Message + "\n\nVerifique o seguinte:\n- Existe conexão com a internet?" +
                        "\n-O email e a senha estão corretos?", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Cursor = Cursors.Default;

                //int contador = 0;
                //string armazenador = "";
                //if(txtLogin.Text[i].ToString() == "@" || contador>0) //já tá percorrendo todos os caracteres
                //{
                //    contador++;
                //    armazenador += txtLogin.Text[i].ToString();
                //}
                //MessageBox.Show(armazenador.ToString() + " parou aqui!");
                ////for() //este for é do app.config do SMTP
                ////{
                ////}
            }
        }

        //private void btnEnviar_Click(object sender, EventArgs e)
        //{
        //    new frmAdicionarSMTP().ShowDialog(); //depois desta linha atualiza o banco de dados
        //    PopularGrid();
        //}

        //private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    int indice = dataGridView1.CurrentRow.Index;
        //    DialogResult dialogo = MessageBox.Show("Tem certeza que deseja excluir o seguinte protocolo de email: "
        //        + dataGridView1[0, indice].Value.ToString() + " ?", "Atenção!",
        //        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        //    if(dialogo == DialogResult.Yes)
        //    {
        //        //exclui o smtp
        //        Usuario us = new Usuario();
        //        us.DeletarSMTP(dataGridView1[0, indice].Value.ToString());
        //        MessageBox.Show("SMTP apagado com sucesso!", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        //    }
        //    PopularGrid();
        //}

        private void rbtSimIniciar_CheckedChanged_1(object sender, EventArgs e)
        {
            rkApp.SetValue("FastFoodDelivery", Application.ExecutablePath.ToString());
            // Isso fará com que ele INICIE junto com o windows
        }

        private void rbtNaoIniciar_CheckedChanged(object sender, EventArgs e)
        {
            rkApp.DeleteValue("FastFoodDelivery", false);
            // Isso fará com que ele NÃO inicie junto com o windows
        }

        private void rbtSimDesligar_CheckedChanged(object sender, EventArgs e)
        {
            new Usuario().Alterarligar("S");
        }

        private void rbtNaoDesligar_CheckedChanged(object sender, EventArgs e)
        {
            new Usuario().Alterarligar("N");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este email será útil nas seguintes possibilidades:\n" +
                "- Quando um usuário perder a senha do software, o sistema poderá enviar um email de " +
                " recuperação de senha para o mesmo;\n" +
                "- E quando for necessário enviar relatórios para alguma pessoa por email.\n\n" +
                "Para isso, crie um email, depois coloque nos campos em branco o que se pede!");
        }
    }
}
