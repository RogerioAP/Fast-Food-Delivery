using System;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;
using System.Configuration;

namespace Telas
{
    public partial class frmConfiguracoes : Form
    {
        ArrayList arr = new ArrayList();

        public frmConfiguracoes()
        {
            InitializeComponent();
        }

        //status é para verificar se 
        public static bool status = false;

        public void Status(bool st)
        {
            status = st;
        }

        //muda textos na tela
        public void MudarLabel()
        {
            lblServer.Text = "Server: *";
            lblUsuario.Text = "Usuário *";

            lblServer.ForeColor = Color.Red;
            lblUsuario.ForeColor = Color.Red;
        }
        
        //botão fechar
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        //busca o arquivo de configuração
        Configuration configfile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        private void btnConectar_Click(object sender, EventArgs e)
        {
            //testa se existem campos em branco
            if (txtServer.Text == string.Empty || txtUsuario.Text == string.Empty)
            {
                MudarLabel();
                MessageBox.Show("Os campos com * não podem ser nulos!", "Erro!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else  //se tiver tudo certo
            {
                //Conn.hostDB = txtServer.Text; //vai armazenando os txtBox nos objetos da classe conn
                //Conn.Database = "mysql";
                //Conn.userDB = txtUsuario.Text;
                //Conn.passwdDB = txtSenha.Text;
                //Conn.createStringConnection();

                AppSettingsSection appSetSec = configfile.AppSettings;
                try
                {
                    //muda o estilo do cursor
                    this.Cursor = Cursors.WaitCursor;

                    //MessageBox.Show(appSetSec.Settings["database"].Value);
                    //Conn.Conectar();

                    //escrevendo no app.config
                    appSetSec.Settings["hostDb"].Value = txtServer.Text;
                    appSetSec.Settings["userDB"].Value = txtUsuario.Text;
                    appSetSec.Settings["passwordDB"].Value = txtSenha.Text;

                    //tenta conectar ao banco de dados padrão do MySql
                    Conn.Conectar("mysql");

                    //para salvar o arquivo modificado alinha abaixo
                    configfile.Save(ConfigurationSaveMode.Modified);

                    //faz a atualização do appSettings abaixo
                    ConfigurationManager.RefreshSection("appSettings");

                    //appSetSec.Settings["database"].Value = "fast";
                    ////para salvar o arquivo modificado alinha abaixo
                    //configfile.Save(ConfigurationSaveMode.Modified);
                    ////faz a atualização do appSettings abaixo
                    //ConfigurationManager.RefreshSection("appSettings");

                    //se tiver conectado cria as tabelas
                    Conn.CriarTabelas(appSetSec.Settings["tabelas"].Value);

                    lblStatusdaconexao.ForeColor = Color.Blue;
                    lblStatusdaconexao.Text = "conectado";
                    MessageBox.Show("Configuração salva com sucesso!", "Concluído!", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);

                    //com a conexão realizada com sucesso passa o status para true
                    Status(true);
                    
                    this.Close();                    
                }
                catch (Exception es)
                {
                    this.Cursor = Cursors.Default;
                    MessageBox.Show("Não foi possível conectar.\nMotivo: " + es.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Cursor = Cursors.Default;
            }
        }
    }
}
