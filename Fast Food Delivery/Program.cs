using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Telas;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;
using System.Collections;

namespace Mudancas
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
                                    
            //Verificar se existe banco de dados
            /*if (ConfigurationManager.AppSettings["hostDB"] == null)
            {
                Application.Run(new frmConfiguracoes());
                Conn.Conectar();
            }*/


            /*A 1° coisa a ser fazer é tentar abrir a conexão e caso der erro e para configuração do BD.
             Dessa forma, quando o software estiver funcionando corretamente, economizará tempo passando somente
                pela 1° etapa.*/

            //essa tela irá aparecer por 2 segundos
            new frmTela_Logo().ShowDialog();

            //tenta conectar
            try
            {
                Conn.Conectar("fast");
                Checar();

                //buscar os dados da conexão no app.config
                //string asd = ConfigurationSettings.AppSettings["database"].ToString();
                //MessageBox.Show("É " + asd);
                //pegando os valores do app.config
                //MessageBox.Show("É " + connectionstring);

                //new frmRecuperacaodesenha().ShowDialog(); //chama esta tela para recuperar
                //Checar();
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível conectar com o banco de dados!\nMotivo: " + e.Message, "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
                new frmConfiguracoes().ShowDialog();
                
                //verifcar se após a tentativa de conexão, se ela foi feita com sucesso
                if(frmConfiguracoes.status == true)
                {
                    Checar();
                }
            }

            //fecha a conexão com o banco de dados
            Conn.Close();
        }

        public static void Checar()
        {
            Usuario us = new Usuario();
            ArrayList arr = new ArrayList();
            arr = us.Usuarios();

            //se não existir usuário cadastrado
            if (arr.Count == 0)
            {
                //o parametro desse construtor é só para diferenciar
                new frmNovo_usuario(1).ShowDialog();
                arr = null;
                arr = us.Usuarios();

                //se já tiver sido criado o usuário executa o login
                if (arr.Count != 0)
                {
                    new frmLogin().ShowDialog();
                }
            }
            else
            {
                new frmLogin().ShowDialog();
            }
        }
    }
}
