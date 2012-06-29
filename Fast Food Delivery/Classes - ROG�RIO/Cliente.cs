using System;
using System.Collections;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace Telas
{
    public class Cliente
    {
        private int idclientes;  //colocar o CPF
        private string clientes;
        private string endereco, bairro, telefone, cpf;
        
        public int Idclientes
        {
            get { return idclientes; }
            set { idclientes = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string Clientes
        {
            get { return clientes; }
            set { clientes = value; }
        }



        public ArrayList listarnome(string nom)
        {
            ArrayList arr = new ArrayList();
            string sql = "SELECT * FROM clientes where nome like '%" + nom + "%';" ;
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);

            commS.Parameters.Add("@nome", MySqlDbType.VarChar);
            commS.Parameters["@nome"].Value = nom;

            DataTable dt = Conn.ExecuteQuery(commS);
            if (dt != null)
            {
                int i = 0;
                while (i < dt.Rows.Count)
                {
                    Cliente cl = new Cliente();
                    cl.cpf = dt.Rows[i][0].ToString();
                    cl.Clientes = dt.Rows[i][1].ToString();
                    cl.Endereco = dt.Rows[i][2].ToString();
                    cl.Bairro = dt.Rows[i][3].ToString();
                    cl.Telefone = dt.Rows[i][4].ToString();
                    arr.Add(cl);
                    i++;
                }
            }
            return arr;
        }

        public ArrayList listarcpf( string cp)
        {
            ArrayList arr = new ArrayList();
            string sql = "SELECT * FROM clientes where cpf like '%" + cp + "%';";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);

            commS.Parameters.Add("@cpf", MySqlDbType.VarChar);
            commS.Parameters["@cpf"].Value = cp;

            DataTable dt = Conn.ExecuteQuery(commS);
            if (dt != null)
            {
                int i = 0;
                while (i < dt.Rows.Count)
                {
                    Cliente cl = new Cliente();
                    cl.Clientes = dt.Rows[i][1].ToString();
                    cl.Endereco = dt.Rows[i][2].ToString();
                    cl.Bairro = dt.Rows[i][3].ToString();
                    cl.Telefone = dt.Rows[i][4].ToString();

                    cl.cpf = dt.Rows[i][0].ToString();
                    arr.Add(cl);
                    i++;
                }
            }
            return arr;
        }

        public ArrayList Clientess()
        {
            ArrayList arr = new ArrayList();
            string sql = "SELECT*FROM clientes;";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);
            DataTable dt = Conn.ExecuteQuery(commS);
            if(dt!=null)
            {
                int i = 0;
                while(i < dt.Rows.Count)
                {
                    Cliente cl = new Cliente();
                    cl.Clientes = dt.Rows[i][1].ToString();
                    cl.Endereco = dt.Rows[i][2].ToString();
                    cl.Bairro = dt.Rows[i][3].ToString();
                    cl.Telefone = dt.Rows[i][4].ToString();
                    cl.Cpf = dt.Rows[i][0].ToString();
                    arr.Add(cl);
                    i++;
                }
            }
            return arr;
        }
        
        public void Salvar()
        {
            string sql = "INSERT INTO clientes VALUES(@cpf, @nome, @endereco, @bairro, @telefone);";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);

            commS.Parameters.Add("@cpf", MySqlDbType.VarChar);
            commS.Parameters["@cpf"].Value = cpf;

            commS.Parameters.Add("@nome", MySqlDbType.VarChar);
            commS.Parameters["@nome"].Value = clientes;

            commS.Parameters.Add("@endereco", MySqlDbType.VarChar);
            commS.Parameters["@endereco"].Value = endereco;

            commS.Parameters.Add("@bairro", MySqlDbType.VarChar);
            commS.Parameters["@bairro"].Value = bairro;

            commS.Parameters.Add("@telefone", MySqlDbType.VarChar);
            commS.Parameters["@telefone"].Value = telefone;
            
            try
            {
                Conn.ExecuteNonQuery(commS);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Deletar(string cli)
        {
            string sql = "DELETE FROM clientes WHERE nome='" + cli + "';";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);

            commS.Parameters.Add("@nome", MySqlDbType.VarChar);
            commS.Parameters["@nome"].Value = cli;
            Conn.ExecuteNonQuery(commS);
        }

        public ArrayList Nomecliente(string tipoo) //busca o nome do cliente para saber o BAIRRO
        {
            ArrayList arr = new ArrayList();
            string sql = "SELECT*FROM clientes where nome like '" + tipoo + "';";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);

            commS.Parameters.Add("@nome", MySqlDbType.VarChar);
            commS.Parameters["@nome"].Value = tipoo;

            DataTable dt = Conn.ExecuteQuery(commS);
            if (dt != null)
            {
                int i = 0;
                while (i < dt.Rows.Count)
                {
                    Cliente cl = new Cliente();
                    cl.Clientes = dt.Rows[i][1].ToString();
                    cl.Bairro = dt.Rows[i][3].ToString();
                    arr.Add(cl);
                    i++;
                }
            }
            return arr;
        }

        public void Alterarcliente(string cli)
        {
            string sql = "UPDATE clientes set nome=@nome, endereco=@endereco, bairro=@bairro, telefone=@telefone, cpf=@cpf where cpf='" + cli + "';";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);

            commS.Parameters.Add("@idclientes",MySqlDbType.VarChar);
            commS.Parameters["@idclientes"].Value = cli;

            commS.Parameters.Add("@nome", MySqlDbType.VarChar);
            commS.Parameters["@nome"].Value = clientes;

            commS.Parameters.Add("@endereco", MySqlDbType.VarChar);
            commS.Parameters["@endereco"].Value = endereco;

            commS.Parameters.Add("@bairro", MySqlDbType.VarChar);
            commS.Parameters["@bairro"].Value = bairro;

            commS.Parameters.Add("@telefone", MySqlDbType.VarChar);
            commS.Parameters["@telefone"].Value = telefone;

            commS.Parameters.Add("@cpf", MySqlDbType.VarChar);
            commS.Parameters["@cpf"].Value = cpf;

            try
            {
                Conn.ExecuteNonQuery(commS);
            }
            catch (Exception df)
            {
                throw df;
            }
        }
    }
}
