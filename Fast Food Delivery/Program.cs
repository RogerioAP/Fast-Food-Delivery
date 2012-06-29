using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Telas;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;

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

            /*A 1° coisa a ser fazer é tentar abrir a conexão e caso der erro e para configuração do BD.
             Dessa forma, quando o software estiver funcionando corretamente, economizará tempo passando somente
                pela 1° etapa.*/
                        
            //Verificar se existe banco de dados
            /*if (ConfigurationManager.AppSettings["hostDB"] == null)
            {
                Application.Run(new frmConfiguracoes());
                Conn.Conectar();
            }*/

            new frmTela_Logo().ShowDialog(); //essa tela irá aparecer por 2 segundos
            try //tenta conectar
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
                Checar();
            }
            Conn.Close();
        }

        public static void Checar()
        {
            Usuario us = new Usuario();
            System.Collections.ArrayList arr = new System.Collections.ArrayList();
            arr = us.Usuarios();

            if (arr.Count == 0) //se não existir usuário cadastrado
            {
                //o parametro desse construtor é só para diferenciar
                new frmNovo_usuario(1).ShowDialog();
                arr = null;
                arr = us.Usuarios();

                if (arr.Count != 0) //se já tiver sido criado o usuário executa o login
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
