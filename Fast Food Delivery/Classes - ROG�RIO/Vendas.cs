using System;
using System.Collections;
using MySql.Data.MySqlClient;
using System.Data;

namespace Telas
{
    public class Vendas
    {

        private int idvenda;
        private  int entrega;
        private string codigo;  //para controle de estoque
        private string cliente;
        private string funcionario;
        private string valortotal;
        private string data;
        private string bairro;
        private string endereco;
        private string produto; //esse é para guardar os nomes dos produtos que foram comprados

        public int Idvenda
        {
            get { return idvenda; }
            set { idvenda = value; }
        }
        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
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
        public string Data
        {
            get { return data; }
            set { data = value; }
        }
        public int Entrega
        {
            get { return entrega; }
            set { entrega = value; }
        }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public string Produto
        {
            get { return produto; }
            set { produto = value; }
        }

        public ArrayList Listarvendas() //entregas pendentes
        {
            ArrayList arr = new ArrayList();
            string sql = "SELECT*FROM venda where entrega=1;"; //com 1 tá pendente
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);
            DataTable dt = Conn.ExecuteQuery(commS);
            if (dt != null)
            {
                int i = 0;
                while (i < dt.Rows.Count)
                {
                    Vendas ve = new Vendas();
                    ve.Idvenda = int.Parse(dt.Rows[i][0].ToString());
                    ve.Entrega = int.Parse(dt.Rows[i][1].ToString()); //aqui já é possível detectar se já está entregue ou não
                    ve.Codigo = dt.Rows[i][2].ToString();
                    ve.Cliente = dt.Rows[i][3].ToString();
                    ve.Funcionario = dt.Rows[i][4].ToString();
                    ve.Produto = dt.Rows[i][5].ToString();
                    ve.Valortotal = dt.Rows[i][6].ToString();
                    ve.Data = dt.Rows[i][7].ToString();
                    ve.Bairro = dt.Rows[i][8].ToString();
                    ve.Endereco = dt.Rows[i][9].ToString();
                    arr.Add(ve);
                    i++;
                }
            }
            return arr;
        }

        public void Salvar()
        {
            string sql = "INSERT INTO venda VALUES(null, @entrega, @codigo, @cliente, @funcionario, @produto, @valortotal, @data, @bairro, @endereco);";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);

            commS.Parameters.Add("@entrega", MySqlDbType.Int32);
            commS.Parameters["@entrega"].Value = Entrega;

            commS.Parameters.Add("@codigo", MySqlDbType.VarChar);
            commS.Parameters["@codigo"].Value = "2=2";

            commS.Parameters.Add("@cliente", MySqlDbType.VarChar);
            commS.Parameters["@cliente"].Value = Cliente;
            
            commS.Parameters.Add("@funcionario", MySqlDbType.VarChar);
            commS.Parameters["@funcionario"].Value = Funcionario;

            commS.Parameters.Add("@produto", MySqlDbType.VarChar);
            commS.Parameters["@produto"].Value = Produto;

            commS.Parameters.Add("@valortotal", MySqlDbType.VarChar);
            commS.Parameters["@valortotal"].Value = Valortotal;
            
            commS.Parameters.Add("@data", MySqlDbType.VarChar);
            commS.Parameters["@data"].Value = Data;

            commS.Parameters.Add("@bairro", MySqlDbType.VarChar);
            commS.Parameters["@bairro"].Value = Bairro;

            commS.Parameters.Add("@endereco", MySqlDbType.VarChar);
            commS.Parameters["@endereco"].Value = Endereco;
            
            try
            {
                Conn.ExecuteNonQuery(commS);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        
        public void Entregaconcluida(int co) //concluir a entrega
        {
            string sql = "Update venda set entrega=0 where idvenda=" + co + ";";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);
            
            commS.Parameters.Add("@idvenda", MySqlDbType.Int32);
            commS.Parameters["@idvenda"].Value = co;
            
            try
            {
                Conn.ExecuteNonQuery(commS);
            }
            catch(Exception rf)
            {
                throw rf;
            }
        }
        
        public void Deletarpedido(int id) //exclui o pedido cancelado
        {
            string sql = "DELETE FROM venda WHERE idvenda="+"@idvenda;";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);

            commS.Parameters.Add("@idvenda", MySqlDbType.Int32);
            commS.Parameters["@idvenda"].Value = id;

            Conn.ExecuteNonQuery(commS);
        }
    }
}
