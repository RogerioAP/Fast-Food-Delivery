using System;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Telas
{
    public class Usuario
    {
        //tem a parte do login

        int codigo;
        string login;
        string senha;
        string tipodeconta, nomecompleto, email;

        public static string usuarioativo;  //essa parte serve para guardar o login como um usuário ativo
        public static string status;  //aqui é para saber e guardar se é funcionário ou administrador
        string protocolo; //esse é para pegar os smtp's

        public string ligar; //atributo para condição de ligar

        public string Protocolo
        {
            get { return protocolo; }
            set { protocolo = value; }
        }
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        public string Tipodeconta
        {
            get { return tipodeconta; }
            set { tipodeconta = value; }
        }
        public string Nomecompleto
        {
            get { return nomecompleto; }
            set { nomecompleto = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public void UsuarioAtivo(string ativo)
        {
            usuarioativo = ativo;
        }
        public void TirarUsuario()
        {
            usuarioativo = null;
        }


        public void TipodeConta(string tipo)
        {
            status = tipo;
        }
        public void Tirartipodeconta()
        {
            tipodeconta = null;
        }

        public ArrayList Usuarios()  //aqui é para listar e depois testar no login,
        {                                   //se ele e a respectiva senha são válidos
            ArrayList arr = new ArrayList();
            string sql = "SELECT*FROM entrar;";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);
            DataTable dt = Conn.ExecuteQuery(commS);
            if (dt != null)
            {
                int i = 0;
                while (i < dt.Rows.Count)
                {
                    Usuario u = new Usuario();
                    u.Codigo = int.Parse(dt.Rows[i][0].ToString());
                    u.Login = dt.Rows[i][1].ToString();
                    u.Senha = dt.Rows[i][2].ToString();
                    u.Tipodeconta = dt.Rows[i][3].ToString();
                    u.Nomecompleto = dt.Rows[i][4].ToString();
                    u.Email = dt.Rows[i][5].ToString();
                    arr.Add(u);
                    i++;
                }
            }
            return arr;
        }
        
        public void SalvarUsuario() //salvar um novo usuário
        {
            string sql = "INSERT INTO entrar VALUES(null, @login, @senha, @tipodeconta, @nomecompleto, @email);";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);

            commS.Parameters.Add("@login", MySqlDbType.VarChar);
            commS.Parameters["@login"].Value = login;

            commS.Parameters.Add("@senha", MySqlDbType.VarChar);
            commS.Parameters["@senha"].Value = senha;

            commS.Parameters.Add("@tipodeconta", MySqlDbType.VarChar);
            commS.Parameters["@tipodeconta"].Value = tipodeconta;

            commS.Parameters.Add("@nomecompleto", MySqlDbType.VarChar);
            commS.Parameters["@nomecompleto"].Value = nomecompleto;

            commS.Parameters.Add("@email", MySqlDbType.VarChar);
            commS.Parameters["@email"].Value = email;

            try
            {
                Conn.ExecuteNonQuery(commS);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Alterar(string senh, int codi) //alterar a senha (se um usuário esquecer a própria senha
        {                                                                          // outro pode alterar para o memória fraca)
            string sql = "UPDATE entrar SET senha='" + senh + "' WHERE identrar='" + codi + "';";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);

            commS.Parameters.Add("senha", MySqlDbType.VarChar);
            commS.Parameters["@senha"].Value = senh;

            try
            {
                Conn.ExecuteNonQuery(commS);
            }
            catch (Exception d)
            {
                throw d;
            }
        }

        public void Deletar(int codcod) //deletar usuário é claro dannnnnnnnnnnn
        {
            string sql = "DELETE FROM entrar where identrar= '" + codcod + "';";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);

            commS.Parameters.Add("@login", MySqlDbType.VarChar);
            commS.Parameters["@login"].Value = codcod;

            Conn.ExecuteNonQuery(commS);
        }

        public void Alterartipodeconta(int novotipo)
        {
            string sql = "UPDATE entrar set tipodeconta= @tipodeconta where identrar=" + novotipo + ";";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);

       
            commS.Parameters.Add("@tipodeconta", MySqlDbType.VarChar);
            commS.Parameters["@tipodeconta"].Value = tipodeconta;

            try
            {
                Conn.ExecuteNonQuery(commS);
            }
            catch (Exception ji)
            {
                throw ji;
            }
        }

        public void Alterarligar(string letra)
        {
            string sql = "UPDATE configuracoes SET ligar='" + letra + "';";
            //passa para o BD a letra corespondente se é para Ligar ou Não
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);

            commS.Parameters.Add("@ligar", MySqlDbType.VarChar);
            commS.Parameters["@ligar"].Value = ligar;

            try
            {
                Conn.ExecuteNonQuery(commS);
            }
            catch(Exception sd)
            {
                throw sd;
            }
        }

        public string Ligar
        {
            get { return ligar; }
            set { ligar = value; }
        }

        //serve para lista e verificar o status de ligar ou desligar no carregamento do load da tela gerais
        public ArrayList Condicaoligar()
        {
            ArrayList arr = new ArrayList();
            string sql = "SELECT * FROM configuracoes;";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);
            DataTable dt = Conn.ExecuteQuery(commS);
            if(dt != null)
            {
                int i = 0;
                while(i < dt.Rows.Count)
                {
                    Usuario us = new Usuario();
                    us.Ligar = dt.Rows[i][0].ToString();
                    arr.Add(us);
                    i++;
                }
            }
            return arr;
        }

        //public ArrayList Smpts() //listar os smtp's
        //{
        //    ArrayList arr = new ArrayList();
        //    string sql = "SELECT * FROM smtp;";
        //    MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);
        //    DataTable dt = Conn.ExecuteQuery(commS);
        //    if(dt != null)
        //    {
        //        int i = 0;
        //        while(i < dt.Rows.Count)
        //        {
        //            Usuario us = new Usuario();
        //            us.Protocolo = dt.Rows[i][0].ToString();
        //            arr.Add(us);
        //            i++;
        //        }
        //    }
        //    return arr;
        //}

        //public void InserirSMTP() //inserir novo smtp
        //{
        //    string sql = "INSERT INTO smtp VALUES(@protocolo);";
        //    MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);

        //    commS.Parameters.Add("@protocolo", MySqlDbType.VarChar);
        //    commS.Parameters["@protocolo"].Value = protocolo;

        //    try
        //    {
        //        Conn.ExecuteNonQuery(commS);
        //    }
        //    catch(Exception r)
        //    {
        //        throw r;
        //    }
        //}

        //public void DeletarSMTP(string sm) //deletar smtp. Como parametro está um smtp a ser deletado
        //{
        //    string sql = "DELETE FROM smtp where protocolo='" + sm + "';";
        //    MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);

        //    commS.Parameters.Add("@protocolo", MySqlDbType.VarChar);
        //    commS.Parameters["@protocolo"].Value = sm;

        //    Conn.ExecuteNonQuery(commS);
        //}

        public ArrayList listar(string nom) //nom é o nome
        {
            ArrayList arr = new ArrayList();
            string sql = "SELECT * FROM entrar where nome like " + " @nom ";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);

            commS.Parameters.Add("@nomecompleto", MySqlDbType.VarChar);
            commS.Parameters["@nomecompleto"].Value = nom;

            DataTable dt = Conn.ExecuteQuery(commS);
            if (dt != null)
            {
                int i = 0;
                while (i < dt.Rows.Count)
                {
                    Usuario u = new Usuario();
                    u.Codigo = int.Parse(dt.Rows[i][0].ToString());
                    u.Login = dt.Rows[i][1].ToString();
                    u.Senha = dt.Rows[i][2].ToString();
                    u.Tipodeconta = dt.Rows[i][3].ToString();
                    u.Nomecompleto = dt.Rows[i][4].ToString();
                    u.Email = dt.Rows[i][5].ToString();
                    arr.Add(u);
                    i++;
                }
            }
            return arr;
        }



        public ArrayList listar(int cod)
        {
            ArrayList arr = new ArrayList();
            string sql = "SELECT * FROM entrar where identrar='" + cod + "';";
            //string sql = "SELECT * FROM entrar where identrar like " + " @cod ";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);

            commS.Parameters.Add("@cod", MySqlDbType.VarChar);
            commS.Parameters["@cod"].Value = cod;

            DataTable dt = Conn.ExecuteQuery(commS);
            if (dt != null)
            {
                int i = 0;
                while (i < dt.Rows.Count)
                {
                    Usuario u = new Usuario();
                    u.Codigo = int.Parse(dt.Rows[i][0].ToString());
                    u.Login = dt.Rows[i][1].ToString();
                    u.Senha = dt.Rows[i][2].ToString();
                    u.Tipodeconta = dt.Rows[i][3].ToString();
                    u.Nomecompleto = dt.Rows[i][4].ToString();
                    u.Email = dt.Rows[i][5].ToString();
                    arr.Add(u);
                    i++;
                }
            }
            return arr;
        }
        
        public void Editar(int d)
        {
            string sql = "UPDATE entrar SET login = '" + login + "', nomecompleto = '" + nomecompleto +
                "', tipodeconta = '" + tipodeconta + "', email = '" + email + "', senha = '" + senha
                + "' WHERE identrar = " + d + ";";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);

            commS.Parameters.Add("nomecompleto", MySqlDbType.VarChar);
            commS.Parameters["@nomecompleto"].Value = nomecompleto;

            commS.Parameters.Add("tipodeconta", MySqlDbType.VarChar);
            commS.Parameters["@tipodeconta"].Value = tipodeconta;

            commS.Parameters.Add("email", MySqlDbType.VarChar);
            commS.Parameters["@email"].Value = email;

            commS.Parameters.Add("senha", MySqlDbType.VarChar);
            commS.Parameters["@senha"].Value = senha;

            commS.Parameters.Add("codigo", MySqlDbType.Int32);
            commS.Parameters["@codigo"].Value = d;

            try
            {
                Conn.ExecuteNonQuery(commS);
            }
            catch (Exception o)
            {
                throw o;
            }
        }
        
        public void Editar_sem_senha(int d)
        {
            string sql = "UPDATE entrar SET login = '" + login + "', nomecompleto = '" + nomecompleto +
                "', tipodeconta = '" + tipodeconta + "', email = '" + email + "' WHERE identrar = " + d + ";";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);

            commS.Parameters.Add("nomecompleto", MySqlDbType.VarChar);
            commS.Parameters["@nomecompleto"].Value = nomecompleto;

            commS.Parameters.Add("tipodeconta", MySqlDbType.VarChar);
            commS.Parameters["@tipodeconta"].Value = tipodeconta;

            commS.Parameters.Add("email", MySqlDbType.VarChar);
            commS.Parameters["@email"].Value = email;

            commS.Parameters.Add("codigo", MySqlDbType.Int32);
            commS.Parameters["@codigo"].Value = d;

            try
            {
                Conn.ExecuteNonQuery(commS);
            }
            catch (Exception o)
            {
                throw o;
            }
        }
    }
}
