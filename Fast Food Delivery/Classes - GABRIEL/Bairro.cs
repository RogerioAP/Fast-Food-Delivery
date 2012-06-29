using System;
using System.Collections;
using MySql.Data.MySqlClient;
using System.Data;

namespace Telas
{
    class Bairro
    {
        int idbairro; //essa parte é do bairro, entre eles está o cadastramento e etc
        string nome;//do bairro
        string tempodeentrega;
        string valordeentrega;
        string percentual;

        public int Idbairro
        {
            get { return idbairro; }
            set { idbairro = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Tempodeentrega
        {
            get { return tempodeentrega; }
            set { tempodeentrega = value; }
        }
        public string Valordeentrega
        {
            get { return valordeentrega; }
            set { valordeentrega = value; }
        }
        public string Percentual
        {
            get { return percentual; }
            set { percentual = value; }
        }


        public ArrayList listar()
        {
            ArrayList arr = new ArrayList();
            string sql = "SELECT * FROM bairro;";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);
            DataTable dt = Conn.ExecuteQuery(commS);
            if (dt != null)
            {
                int i = 0;
                while (i < dt.Rows.Count)
                {
                    Bairro bai = new Bairro();
                    bai.Idbairro = int.Parse(dt.Rows[i][0].ToString());
                    bai.Nome = dt.Rows[i][1].ToString();
                    bai.Tempodeentrega = dt.Rows[i][2].ToString();
                    bai.Valordeentrega = dt.Rows[i][3].ToString();
                    bai.Percentual = dt.Rows[i][4].ToString();
                    arr.Add(bai);
                    i++;
                }
            }
            return arr;
        }

        public ArrayList listar(string nom)
        {
            ArrayList arr = new ArrayList();
            string sql = "SELECT * FROM bairro where nome like'%" + nom + "%';";

            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);

            commS.Parameters.Add("@nome", MySqlDbType.VarChar);
            commS.Parameters["@nome"].Value = nom;

            DataTable dt = Conn.ExecuteQuery(commS);
            if (dt != null)
            {
                int i = 0;
                while (i < dt.Rows.Count)
                {
                    Bairro bai = new Bairro();
                    bai.Idbairro = int.Parse(dt.Rows[i][0].ToString());
                    bai.Nome = dt.Rows[i][1].ToString();
                    bai.Tempodeentrega = dt.Rows[i][2].ToString();
                    bai.Valordeentrega = dt.Rows[i][3].ToString();
                    bai.Percentual = dt.Rows[i][4].ToString();

                    arr.Add(bai);
                    i++;
                }
            }
            return arr;
        }
        public ArrayList listar(int id)
        {
            ArrayList arr = new ArrayList();
            string sql = "SELECT * FROM bairro where idbairro = @idbairro;";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);

            commS.Parameters.Add("@idbairro", MySqlDbType.VarChar);
            commS.Parameters["@idbairro"].Value = id;

            DataTable dt = Conn.ExecuteQuery(commS);
            if (dt != null)
            {
                int i = 0;
                while (i < dt.Rows.Count)
                {
                    Bairro bai = new Bairro();
                    bai.Idbairro = int.Parse(dt.Rows[i][0].ToString());
                    bai.Nome = dt.Rows[i][1].ToString();
                    bai.Tempodeentrega = dt.Rows[i][2].ToString();
                    bai.Valordeentrega = dt.Rows[i][3].ToString();
                    bai.Percentual = dt.Rows[i][4].ToString();

                    arr.Add(bai);
                    i++;
                }
            }
            return arr;
        }

        public void Salvarbairro()
        {
            string sql = "INSERT INTO bairro VALUES(null, @nome, @tempodeentrega, @valorentrega, @percentual);";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);

            commS.Parameters.Add("@nome", MySqlDbType.VarChar);
            commS.Parameters["@nome"].Value = nome;

            commS.Parameters.Add("@tempodeentrega", MySqlDbType.VarChar);
            commS.Parameters["@tempodeentrega"].Value = tempodeentrega;

            commS.Parameters.Add("@valorentrega", MySqlDbType.VarChar);
            commS.Parameters["@valorentrega"].Value = valordeentrega;

            commS.Parameters.Add("@percentual", MySqlDbType.VarChar);
            commS.Parameters["@percentual"].Value = percentual;


            try
            {
                Conn.ExecuteNonQuery(commS);
            }
            catch (Exception bn)
            {
                throw bn;
            }
        }

        public void Alterarbairro(int codig)
        {
            string sql = "Update bairro set nome=" + nome +", tempodeentrega=" + tempodeentrega +", valordeentrega=" + valordeentrega + ", percentual=" + percentual + " where idbairro=" + codig +";";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);

            commS.Parameters.Add("@nome", MySqlDbType.VarChar);
            commS.Parameters["@nome"].Value = nome;

            commS.Parameters.Add("@tempodeentrega", MySqlDbType.VarChar);
            commS.Parameters["@tempodeentrega"].Value = tempodeentrega;

            commS.Parameters.Add("@valordeentrega", MySqlDbType.VarChar);
            commS.Parameters["@valordeentrega"].Value = valordeentrega;

            commS.Parameters.Add("@percentual", MySqlDbType.VarChar);
            commS.Parameters["@percentual"].Value = percentual;

            commS.Parameters.Add("@idbairro", MySqlDbType.Int32);
            commS.Parameters["@idbairro"].Value = codig;

            try
            {
                Conn.ExecuteNonQuery(commS);
            }
            catch (Exception bn)
            {
                throw bn;
            }

        }

        public void Deletarbairro(int co)
        {
            string sql = "DELETE FROM bairro WHERE idbairro=@idbairro;";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);

            commS.Parameters.Add("@idbairro", MySqlDbType.Int32);
            commS.Parameters["@idbairro"].Value = co;

            Conn.ExecuteNonQuery(commS);
        }
    }
}
