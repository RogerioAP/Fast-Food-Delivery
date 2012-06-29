using System;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;
using System.Configuration;

/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Collections;
using System.Configuration;*/

namespace Telas
{
    public partial class frmConfiguracoes : Form
    {
        ArrayList arr = new ArrayList();

        public frmConfiguracoes()
        {
            InitializeComponent();
        }

        public void MudarLabel()
        {
            lblServer.Text = "Server: *";
            //lblDatabase.Text = "Database: *";
            lblUsuario.Text = "Usuário *";

            lblServer.ForeColor = Color.Red;
            //lblDatabase.ForeColor = Color.Red;
            lblUsuario.ForeColor = Color.Red;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        //busca o arquivo de configuração
        Configuration configfile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        private void btnConectar_Click(object sender, EventArgs e)
        {
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
                    this.Cursor = Cursors.WaitCursor;
                    //MessageBox.Show(appSetSec.Settings["database"].Value);
                    //Conn.Conectar();

                    appSetSec.Settings["hostDb"].Value = txtServer.Text;       //escrevendo no app.config
                    //appSetSec.Settings["database"].Value = "mysql";
                    appSetSec.Settings["userDB"].Value = txtUsuario.Text;
                    appSetSec.Settings["passwordDB"].Value = txtSenha.Text;

                    Conn.Conectar("mysql");

                    //para salvar o arquivo modificado alinha abaixo
                    configfile.Save(ConfigurationSaveMode.Modified);
                    //faz a atualização do appSettings abaixo
                    ConfigurationManager.RefreshSection("appSettings");

                    //MessageBox.Show("É " + appSetSec.Settings["hostDB"].Value.ToString());

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
                    this.Close();
                }
                catch (Exception es)
                {
                    MessageBox.Show("Não foi possível conectar.\nMotivo: " + es.Message, "Erro!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                this.Cursor = Cursors.WaitCursor;
                //MessageBox.Show(appSetSec.Settings["database"].Value);
            }
        }
    }
}
