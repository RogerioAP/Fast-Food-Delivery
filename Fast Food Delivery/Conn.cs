using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;
using System.IO;

namespace Telas
{
    /// <summary>
    /// Classe responsável pela conexão com o banco de dados
    /// </summary>
    public class Conn
    {
        public static MySqlConnection mConn;
        //buscar das variaveis de programa
        static string connectionstring;/* = "server=localhost;database=trabalhofinal;" +
            "uid=root; pwd='123456'";*/
        static MySqlConnectionStringBuilder myCSB = new MySqlConnectionStringBuilder();

        static public String hostDB { get; set; }

        static public String userDB { get; set; }

        static public String passwdDB { get; set; }

        static public String Database { get; set; }

        public static void CriarTabelas(string sql)
        {
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);
            Conn.ExecuteNonQuery(commS);
        }

        //esse parâmetro vai ser o BD a qual o software vai se conectar
        public static void Conectar(string bd)
        {
            try
            {
                //AppSettingsSection appSetSec = new AppSettingsSection();
                //connectionstring = "server=" + appSetSec.Settings["hostDB"].Value.ToString();
                //connectionstring += ";database=" + appSetSec.Settings["database"].Value.ToString();
                //connectionstring += ";uid=" + appSetSec.Settings["userDB"].Value.ToString();
                //connectionstring += ";pwd='" + appSetSec.Settings["passwordDB"].Value.ToString() + "'";

                connectionstring = "server=" + ConfigurationSettings.AppSettings["hostDB"].ToString();
                connectionstring += ";database=" + bd/*ConfigurationSettings.AppSettings["database"].ToString()*/;
                connectionstring += ";uid=" + ConfigurationSettings.AppSettings["userDB"].ToString();
                connectionstring += ";pwd='" + ConfigurationSettings.AppSettings["passwordDB"].ToString() + "'";

                mConn = new MySqlConnection(connectionstring);
                mConn.Open();
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        //public static void ExecuteNonQueryFile(string arq)
        //{
        //    try
        //    {
        //        StreamReader rw = new StreamReader(arq);
        //        string sql = rw.ReadToEnd();
        //        MySqlCommand commS = new MySqlCommand(sql, mConn);

        //        if (mConn.State == ConnectionState.Open)
        //        {
        //            try
        //            {
        //                int i = commS.ExecuteNonQuery();
        //            }
        //            catch (MySqlException e)
        //            {
        //                throw e;
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        public static void ExecuteNonQuery(MySqlCommand commS)
        {
            if (mConn.State == ConnectionState.Open)
            {
                try
                {
                    int i = commS.ExecuteNonQuery();
                }
                catch (MySqlException e)
                {
                    throw e;

                }
            }

        }

        public static DataTable ExecuteQuery(MySqlCommand commS)
        {
            if (mConn.State == ConnectionState.Open)
            {
                //Executa a SQL no banco de dados
                try
                {
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = commS;
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    return dt;
                }
                catch (MySqlException e)
                {
                    throw e; /*PODE DÁ ERRO AQUI SE TIVER APENAS O BD DO PROJETO, PORÉM SEM AS TABELAS*/
                }
            }
            return null;
        }

        /// <summary>
        /// Cria uma string de conexão e retorna-o
        /// </summary>
        /// <returns>string</returns>

        //static public string createStringConnection()
        //{
        //    myCSB.Server = hostDB;
        //    myCSB.UserID = userDB;
        //    myCSB.Password = passwdDB;
        //    myCSB.Database = Database;
        //    //connectionstring = myCSB.ConnectionString;
        //    return myCSB.ConnectionString;
        //}


        static public void Close()
        {
            mConn.Close(); //encerra a conexão com o MYSQL
            mConn.Dispose();
        }
        void recuperaConn()
        {
            //myCSB.Server =
            //if (System.Configuration.ConfigurationManager.AppSettings["serverDB"] != null)
            //{
            //}
        }
    }
}
