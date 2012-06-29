using System;
using System.Collections;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Telas
{
    public class Classe_relatorio
    {
        private int codigo;
        private string clientes;
        private string funcionario;
        private string valortotal;
        private string produtos;
        private string data;
        public string bairro;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Clientes
        {
            get { return clientes; }
            set { clientes = value; }
        }

        public string Funcionario
        {
            get { return funcionario; }
            set { funcionario = value; }
        }
        public string Valortotal
        {
            get { return valortotal; }
            set { valortotal = value; }
        }

        public string Produtos
        {
            get { return produtos; }
            set { produtos = value; }
        }
        public string Data
        {
            get { return data; }
            set { data = value; }
        }
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public static int vez = 0;
        public int Vezdabusca()     // os números IMPARES é busca normal
        {                           // os números PARES é busca avançada
            vez++;
            return vez;
        }

        public ArrayList Listar(string s, string _n)  //busca pelo nome do cliente ou funcionário e exibe no dataGridView
        {
            ArrayList arr = new ArrayList();
            string sql = "SELECT * FROM venda where " + s + " like " + "@venda";

            MySqlCommand commS = new MySqlCommand
                (sql, Conn.mConn);

            commS.Parameters.Add("@venda", MySqlDbType.VarChar);
            commS.Parameters["@venda"].Value = _n;

            DataTable dt = Conn.ExecuteQuery(commS);
            if (dt != null)
            {
                int i = 0;
                while (i < dt.Rows.Count)
                {
                    Classe_relatorio cr = new Classe_relatorio();
                    cr.Codigo = int.Parse(dt.Rows[i][0].ToString());
                    cr.Clientes = dt.Rows[i][3].ToString();
                    cr.Funcionario = dt.Rows[i][4].ToString();
                    cr.Produtos = dt.Rows[i][5].ToString();
                    cr.Valortotal = dt.Rows[i][6].ToString();
                    cr.Data = dt.Rows[i][7].ToString();
                    cr.Bairro = dt.Rows[i][8].ToString();
                    arr.Add(cr);
                    i++;
                }
            }
            return arr;
        }

        public ArrayList Clientefuncionario(string c, string f, string d)
        {
            string sql;
            ArrayList arr = new ArrayList();
            if(d == "")     //busca pelo nome de do cliente e funcionário
            {
                sql = "SELECT * FROM venda WHERE cliente='" + c + "' AND funcionario='" + f + "';";
            }
            else        //busca pelo nome do cliente, funcionário e data
            {
                sql = "SELECT * FROM venda WHERE cliente='" + c + "' AND funcionario='" + f + "' AND data='" + d + "';";
            }

            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);

            DataTable dt = Conn.ExecuteQuery(commS);

            if(dt != null)
            {
                int i = 0;
                while(i < dt.Rows.Count)
                {
                    Classe_relatorio cr = new Classe_relatorio();
                    cr.Codigo = int.Parse(dt.Rows[i][0].ToString());
                    cr.Clientes = dt.Rows[i][1].ToString();
                    cr.Funcionario = dt.Rows[i][2].ToString();
                    cr.Produtos = dt.Rows[i][3].ToString();
                    cr.Valortotal = dt.Rows[i][4].ToString();
                    cr.Data = dt.Rows[i][5].ToString();
                    cr.Bairro = dt.Rows[i][6].ToString();
                    arr.Add(cr);
                    i++;
                }
            }
            return arr;
        }

        public ArrayList Buscarpordatas(int numero, string clien, string funcion, string data1, string data2)
        {
            ArrayList arr = new ArrayList();
            string sql = "";

            //busca só por datas
            if (numero == 1)
            {
                sql = "SELECT * FROM venda WHERE data>='" + data1 + "' AND data<='" + data2 + "';";
            }

            //busca por cliente e uma data
            else if (numero == 2)
            {
                sql = "SELECT * FROM venda WHERE cliente='" + clien + "' AND data='" + data1 + "';";
            }

            //busca por cliente e as duas datas
            else if(numero == 3)
            {
                sql = "SELECT * FROM venda WHERE cliente='" + clien + "' AND data>='" + data1 + "' AND data<='" + data2 + "';";
            }

            //funcionário e uma data
            else if(numero == 4)
            {
                sql = "SELECT * FROM venda WHERE funcionario='" + funcion + "' AND data='" + data1 + "';";
            }

            //funcionário e as datas
            else if(numero == 5)
            {
                sql = "SELECT * FROM venda WHERE funcionario='" + funcion + "' AND data>='" + data1 + "' AND data<='" + data2 + "';";
            }

            //cliente e funcionário
            else if(numero == 6)
            {
                sql = "SELECT * FROM venda WHERE cliente='" + clien + "' AND funcionario='" + funcion + "';";
            }

            //cliente, funcionário e uma data
            else if(numero == 7)
            {
                sql = "SELECT * FROM venda WHERE cliente='" + clien + "' AND funcionario='" + funcion + "' AND data='" + data1 + "';";
            }

            //BUSCA COMPLETA
            else if(numero == 8)
            {
                sql = "SELECT * FROM venda WHERE cliente='" + clien + "' AND funcionario='" + funcion + "' AND data>='" + data1 + "' AND data<='" + data2 + "';";
            }

            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);

            DataTable dt = Conn.ExecuteQuery(commS);

            if(dt != null)
            {
                int i = 0;
                while(i < dt.Rows.Count)
                {
                    Classe_relatorio cr = new Classe_relatorio();
                    cr.Codigo = int.Parse(dt.Rows[i][0].ToString());
                    cr.Clientes = dt.Rows[i][3].ToString();
                    cr.Funcionario = dt.Rows[i][4].ToString();
                    cr.Produtos = dt.Rows[i][5].ToString();
                    cr.Valortotal = dt.Rows[i][6].ToString();
                    cr.Data = dt.Rows[i][7].ToString();
                    cr.Bairro = dt.Rows[i][8].ToString();
                    arr.Add(cr);
                    i++;
                }
            }
            return arr;
        }

        public ArrayList listar_data(string dat)  //busca por uma data e exibe no dataGridView
        {
            ArrayList arr = new ArrayList();
            string sql = "SELECT * FROM venda where data like " +
                "@venda";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);
            commS.Parameters.Add("@venda", MySqlDbType.VarChar);
            commS.Parameters["@venda"].Value = dat;
            DataTable dt = Conn.ExecuteQuery(commS);
            if(dt !=null)
            {
                int i = 0;
                while (i <dt.Rows.Count)
                {
                    Classe_relatorio cr = new Classe_relatorio();
                    //cr.Codigo = int.Parse(dt.Rows[i][0].ToString());
                    cr.Clientes = dt.Rows[i][3].ToString();
                    cr.Funcionario = dt.Rows[i][4].ToString();
                    cr.Produtos = dt.Rows[i][5].ToString();
                    cr.Valortotal = dt.Rows[i][6].ToString();
                    cr.Data = dt.Rows[i][7].ToString();
                    cr.Bairro = dt.Rows[i][8].ToString();
                    arr.Add(cr);
                    i++;
                }
            }
            return arr;
        }

        public ArrayList listar_venda(string nn)
        {
            ArrayList arr = new ArrayList();
            string sql = "SELECT * FROM venda WHERE funcionario LIKE " + 
                "@venda";
            MySqlCommand commS = new MySqlCommand
                (sql, Conn.mConn);
            commS.Parameters.Add("@venda", MySqlDbType.VarChar);
            commS.Parameters["@venda"].Value = nn;
            DataTable dt = Conn.ExecuteQuery(commS);

            if (dt != null)
            {
                int i = 0;
                while (i < dt.Rows.Count)
                {
                    Classe_relatorio c = new Classe_relatorio();
                    c.Codigo = int.Parse(dt.Rows[i][0].ToString());
                    c.Clientes = dt.Rows[i][1].ToString();
                    c.Funcionario = dt.Rows[i][2].ToString();
                    c.Produtos = dt.Rows[i][3].ToString();
                    c.Valortotal = dt.Rows[i][4].ToString();
                    c.Data = dt.Rows[i][5].ToString();
                    c.Bairro = dt.Rows[i][6].ToString();
                    arr.Add(c);
                    i++;
                }
            }
            return arr;
        }
    }
}
