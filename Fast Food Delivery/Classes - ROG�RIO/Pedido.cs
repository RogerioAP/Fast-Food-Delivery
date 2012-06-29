using System;
using System.Collections;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace Telas
{
    public class Pedido
    {
        private string nome, preco, descricao;
        private int quantidade, idprodutos;

        public int Idprodutos
        {
            get { return idprodutos; }
            set { idprodutos = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public ArrayList Produtoss()
        {
            ArrayList arr = new ArrayList();
            string sql = "SELECT*FROM produtos;";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);



            DataTable dt = Conn.ExecuteQuery(commS);
            if (dt != null)
            {
                int i = 0;
                while (i < dt.Rows.Count)
                {
                    Pedido u = new Pedido();
                    u.Idprodutos = int.Parse(dt.Rows[i][0].ToString());
                    u.Nome = dt.Rows[i][1].ToString();
                    u.Descricao = dt.Rows[i][2].ToString();
                    u.Preco = dt.Rows[i][3].ToString();
                    u.Quantidade = int.Parse(dt.Rows[i][4].ToString());
                    arr.Add(u);
                    i++;
                }
            }
            return arr;
        }

        public ArrayList listar(int id)
        {
            ArrayList arr = new ArrayList();
            string sql = "SELECT*FROM produtos where idprodutos = " + "@idprodutos";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);

            commS.Parameters.Add("@idprodutos", MySqlDbType.VarChar);
            commS.Parameters["@idprodutos"].Value = id;

            DataTable dt = Conn.ExecuteQuery(commS);
            if (dt != null)
            {
                int i = 0;
                while (i < dt.Rows.Count)
                {
                    Pedido u = new Pedido();
                    u.Idprodutos = int.Parse(dt.Rows[i][0].ToString());
                    u.Nome = dt.Rows[i][1].ToString();
                    u.Descricao = dt.Rows[i][2].ToString();
                    u.Preco = dt.Rows[i][3].ToString();
                    u.Quantidade = int.Parse(dt.Rows[i][4].ToString());
                    arr.Add(u);
                    i++;
                }
            }
            return arr;
        }


        public ArrayList Quant(string nomm)
        {
            ArrayList arr = new ArrayList();
            string sql = "SELECT*FROM produtos where nome like " + "@nome";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);

            commS.Parameters.Add("@nome", MySqlDbType.VarChar);
            commS.Parameters["@nome"].Value = nomm;

            DataTable dt = Conn.ExecuteQuery(commS);
            if(dt != null)
            {
                int i = 0;
                while(i < dt.Rows.Count)
                {
                    Pedido pe = new Pedido();
                    pe.Nome = dt.Rows[i][i].ToString();
                    pe.Quantidade = int.Parse(dt.Rows[i][4].ToString());
                    arr.Add(pe);
                    i++;
                }
            }
            return arr;
        }
        
        public void Salvar() //vai valer tanto se tiver descrição ou não, quando for adicionar bairro
        {
            string sql = "INSERT INTO produtos VALUES(null, @nome, @descricao, @preco, @quantidade);";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);

            commS.Parameters.Add("@nome", MySqlDbType.VarChar);
            commS.Parameters["@nome"].Value = nome;

            commS.Parameters.Add("@descricao", MySqlDbType.VarChar);
            commS.Parameters["@descricao"].Value = descricao;

            commS.Parameters.Add("@preco", MySqlDbType.VarChar);
            commS.Parameters["@preco"].Value = preco;

            commS.Parameters.Add("@quantidade", MySqlDbType.VarChar);
            commS.Parameters["@quantidade"].Value = quantidade;

            try
            {
                Conn.ExecuteNonQuery(commS);
            }
            catch(Exception w)
            {
                throw w;
            }
        }

        public void Alterar(int quant, string nom) //diminuir a quantidade que foi vendida
        {
            string sql = "UPDATE produtos set quantidade= " + "@quant" + " WHERE nome=" + "@nom"+ ";";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);

            commS.Parameters.Add("@quant", MySqlDbType.VarChar);
            commS.Parameters["@quant"].Value = quant;

            commS.Parameters.Add("@nom", MySqlDbType.VarChar);
            commS.Parameters["@nom"].Value = nom;

            try
            {
                Conn.ExecuteNonQuery(commS);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        //passa o novo pedido para o BD
        public void Inserirpedido(string codi, string clie, string funci, string produts, string valort, string dat, string bair)
        {
            string sql = "INSERT INTO venda VALUES(null, @entrega, @codigo, @cliente, @funcionario, @produtos," + 
                " @valortotal, @data, @bairro);";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);

            commS.Parameters.Add("@entrega", MySqlDbType.VarChar);
            commS.Parameters["@entrega"].Value = "0";

            commS.Parameters.Add("@codigo", MySqlDbType.VarChar);
            commS.Parameters["@codigo"].Value = codi;

            commS.Parameters.Add("@cliente", MySqlDbType.VarChar);
            commS.Parameters["@cliente"].Value = clie;

            commS.Parameters.Add("@funcionario", MySqlDbType.VarChar);
            commS.Parameters["@funcionario"].Value = funci;

            commS.Parameters.Add("@produtos", MySqlDbType.VarChar);
            commS.Parameters["@produtos"].Value = produts;

            commS.Parameters.Add("@valortotal", MySqlDbType.VarChar);
            commS.Parameters["@valortotal"].Value = valort;

            commS.Parameters.Add("@data", MySqlDbType.VarChar);
            commS.Parameters["@data"].Value = dat;

            commS.Parameters.Add("@bairro", MySqlDbType.VarChar);
            commS.Parameters["@bairro"].Value = bair;

            try
            {
                Conn.ExecuteNonQuery(commS);
            }
            catch(Exception ed)
            {
                throw ed;
            }
        }

        public void Alteracaoproduto(int idpro)
        {
            string sql = "UPDATE produtos set nome=@nome, descricao=@descricao, preco=@preco, quantidade=@quantidade where idprodutos=" + idpro + ";";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);

            commS.Parameters.Add("@idprodutos", MySqlDbType.Int32);
            commS.Parameters["@idprodutos"].Value = idpro;

            commS.Parameters.Add("@nome", MySqlDbType.VarChar);
            commS.Parameters["@nome"].Value = nome;

            commS.Parameters.Add("@descricao", MySqlDbType.VarChar);
            commS.Parameters["@descricao"].Value = descricao;

            commS.Parameters.Add("@preco", MySqlDbType.VarChar);
            commS.Parameters["@preco"].Value = preco;

            commS.Parameters.Add("@quantidade", MySqlDbType.VarChar);
            commS.Parameters["@quantidade"].Value = quantidade;

            try
            {
                Conn.ExecuteNonQuery(commS);
            }
            catch(Exception cd)
            {
                throw cd;
            }
        }

        public void Excluirproduto(int idpro)
        {
            string sql = "DELETE FROM produtos where idprodutos=" + idpro + ";";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);

            commS.Parameters.Add("@idprodutos", MySqlDbType.Int32);
            commS.Parameters["@idprodutos"].Value = idpro;

            Conn.ExecuteNonQuery(commS);
        }

    }
}
