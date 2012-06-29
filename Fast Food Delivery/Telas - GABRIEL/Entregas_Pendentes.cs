using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Telas
{
    public partial class frmEntregas_pendentes : Form
    {
        Vendas ven = new Vendas();
        ArrayList arr = new ArrayList();
        Cliente clie = new Cliente();
        public frmEntregas_pendentes()
        {
            InitializeComponent();
        }

        public void PopularGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            arr = ven.Listarvendas();
            
            for (int i = 0; i < arr.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1[0, i].Value = (((Vendas)arr[i]).Cliente);
                dataGridView1[1, i].Value = (((Vendas)arr[i]).Bairro);
                dataGridView1[2, i].Value = (((Vendas)arr[i]).Endereco);
                dataGridView1[3, i].Value = (((Vendas)arr[i]).Valortotal);
                dataGridView1[4, i].Value = "Pendente";
                dataGridView1[5, i].Value = (((Vendas)arr[i]).Idvenda);
                //dataGridView1.Rows.Add(((Vendas)arr[i]).Cliente, ((Vendas)arr[i]).Bairro, ((Cliente)arr[i]).Endereco, ((Vendas)arr[i]).Valortotal, "Pendente");
            }
        }

        private void Entregas_pendentes_Load(object sender, EventArgs e)
        {
            PopularGrid();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {

                int indice = dataGridView1.CurrentRow.Index;
                //MessageBox.Show(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
                int idvend = int.Parse(dataGridView1[5, indice].Value.ToString());
                ven.Deletarpedido(idvend);
                dataGridView1.Rows.Remove(dataGridView1.Rows[indice]); //remove a linha do dataGridView

                MessageBox.Show("Pedido cancelado com sucesso!", "Concluído!", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
            }
            catch(Exception xc)
            {
                MessageBox.Show("Não foi possível cancelar a venda.\nMotivo: " + xc.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //this.dataGridView1.Rows.Remove(this.dataGridView1.CurrentRow);
            //int l = ((Vendas)arr[this.dataGridView1.CurrentRow.Index]).Idvenda;
        









            /*aqui terá que pegar o código e separá-lo para adicionar a quantidade de cada produto
             * no banco de dados
             */
            //int cont = 0; //serve para verificar se selecionou alguma coisa
            //for (int i = 0; i < dataGridView1.Rows.Count; i++)      //percorre o datatGridView
            //{
            //    try
            //    {       //esse IF serve para verificar se a caixinha está marcada
            //        if (bool.Parse(dataGridView1[0, i].EditedFormattedValue.ToString())) //pegar e separar o código
            //        {
            //            arr = ven.Listarvendas();
            //            cont++;

            //            string codigoo = (((Vendas)arr[i]).Codigo).ToString(); //é o código para repor o estoque

            //            string total = "";  //esse atributo pega a quantidade de produtos diferentes
            //            for (int r = 0; r < codigoo.ToString().Length; r++)
            //            {
            //                if (codigoo[r].ToString() != "=") //pega o 1° número(quantidade de 
            //                {                                                                //produtos diferentes)
            //                    total += codigoo[r].ToString();
            //                }
            //                else { break; }  //caso chegue ao caracter "=" para de percorrer
            //            }

            //            //esse atributo abaixo "antigo" receber o código original com "=" e tudo mais
            //            string antigo = codigoo; //aqui nessa parte separa o 1° número do restante
            //            codigoo = "";

            //            int f = 0;
            //            for (int h = 0; h < antigo.Length; h++) //o 1° do codigoo tem que ser "-"
            //            {
            //                if (f != 0)
            //                {
            //                    codigoo += antigo[h];
            //                }
            //                if (antigo[h].ToString() == "=") //esse é excutado somente quando o caracter for "="
            //                {
            //                    codigoo += "-";
            //                    f++;
            //                }
            //            }

            //            int contando = 1; //esse tem que ser 1 pois já conta o 1° produto
            //            while (contando <= int.Parse(total)) //o total é a quantidade de produto diferentes,
            //            {                                       //logo, vai dá loop pela quantidade falada acima
            //                int g = 0;
            //                string idpr = "", quanti = "";

            //                for (int p = 0; p < codigoo.Length; p++) //pega o id do produto
            //                {
            //                    if (g != 0 && codigoo[p].ToString() != ",") //vai armazenando o id
            //                    {
            //                        idpr += codigoo[p].ToString();
            //                    }
            //                    else if (codigoo[p].ToString() == "-") //quanto chegar no caracter "-" inicia
            //                    {
            //                        g++;
            //                    }
            //                    else if (codigoo[p].ToString() == ",") //quando chegar no caracter "," termina o id
            //                    {
            //                        break;
            //                    }
            //                }

            //                int t = 0;          //agora "codigoo" é somente os id's e as quantidades
            //                for (int p = 0; p < codigoo.Length; p++)
            //                {
            //                    if (t != 0 && codigoo[p].ToString() != "-")
            //                    {
            //                        quanti += codigoo[p].ToString(); //pega a quantidade a ser adicionada no BD
            //                    }
            //                    if (codigoo[p].ToString() == ",")
            //                    {
            //                        t++;
            //                    }
            //                    if (t != 0 && codigoo[p].ToString() == "-") //quando chegar no caracter "-" acabou
            //                    {                                                                   //a quantidade
            //                        break;
            //                    }
            //                }
            //                //MessageBox.Show(idpr + " " + quanti);

            //                arr = null;
            //                arr = new Pedido().Produtoss();
            //                for (int p = 0; p < arr.Count; p++)
            //                {                                        //idpr é o id do produto
            //                    if (idpr == (((Pedido)arr[p]).Idprodutos).ToString())
            //                    {
            //                        int esto = (((Pedido)arr[p]).Quantidade); //estoque
            //                        int calculado = esto + int.Parse(quanti); //quantidade já atualizada
            //                        new Pedido().Alterar(calculado, (((Pedido)arr[p]).Nome)); //atualiza o BD
            //                        break;
            //                    }
            //                }
            //                //MessageBox.Show(idpr + " " + quanti);

            //                antigo = codigoo;
            //                codigoo = "";

            //                /*O IF abaixo serve para tirar o id e a quantidade que foram usados nesse loop
            //                 Por exemplo se estava assim    -7,2-5,3
            //                            vai ficar assim     -5,3*/
            //                if (contando < int.Parse(total))
            //                {
            //                    int w = 0;
            //                    for (int h = 0; h < antigo.Length; h++) //o 1° do codigoo tem que ser "-"
            //                    {
            //                        if (antigo[h].ToString() == "-") //logo quando passar pelo 2º "-" começa a armazenar
            //                        {
            //                            w++;
            //                        }
            //                        if (w >= 2)
            //                        {
            //                            codigoo += antigo[h].ToString(); //vai armazenando o "novo" codigo
            //                        }
            //                    }
            //                    MessageBox.Show(codigoo);
            //                }
            //                contando++; //aumenta mais um para no próximo loop atualizar outro produto
            //            } //fim do WHILE, após isso a quantidade já terá sido atualizada. Restando excluir o pedido do BD


            //            PopularGrid();


            //            new Vendas().Deletarpedido(int.Parse(dataGridView1[4, i].Value.ToString())); //excluir o pedido
            //            dataGridView1.Rows.Remove(dataGridView1.Rows[i]); //remove a linha do dataGridView

            //            MessageBox.Show("Pedido cancelado com sucesso!", "Concluído!", MessageBoxButtons.OK,
            //                MessageBoxIcon.Asterisk);
            //            break;
            //        }
            //    }
            //    catch (Exception fg)
            //    {
            //        MessageBox.Show("Não foi possível cancelar!\nMotivo: " + fg.Message, "Erro!", MessageBoxButtons.OK,
            //            MessageBoxIcon.Error);
            //    }
            //}
            //if (cont == 0)
            //{
            //    MessageBox.Show("Você não selecionou nada!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        Vendas ve = new Vendas();
        private void btnConcluir_Click(object sender, EventArgs e)
        {
            /* Quando a entrega estiver 0 > já foi concluída
             * Quando entrega estiver 1 > ela está pendente
             */

            try
            {
                int indice = dataGridView1.CurrentRow.Index;
                //MessageBox.Show(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
                int idvend = int.Parse(dataGridView1[5, indice].Value.ToString());
                ve.Entregaconcluida(idvend);
                dataGridView1.Rows.Remove(dataGridView1.Rows[indice]);
                MessageBox.Show("Venda concluída com sucesso!", "Concluído!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception xc)
            {
                MessageBox.Show("Não foi possível conclui a venda.\nMotivo: " + xc.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //ven.Entregaconcluida(((Vendas)arr[this.dataGridView1.CurrentRow.Index]).Idvenda);
            //PopularGrid();
        }

        private void btnDespachar_Click(object sender, EventArgs e)
        {
            int cont = 0;
            for (int j = 0; j < dataGridView1.Rows.Count; j++)
            {
                if (Convert.ToBoolean(dataGridView1[0, j].Value) == true)
                {
                    cont++;
                }
            }
            
            string [,] array = new string[cont,4];
            
            for (int j = 0; j < dataGridView1.Rows.Count; j++)
            {
                if (Convert.ToBoolean(dataGridView1[0, j].Value) == true)
                {
                    array[j, 1] = dataGridView1[1, j].Value.ToString();
                    array[j, 2] = dataGridView1[2, j].Value.ToString();
                    array[j, 3] = dataGridView1[3, j].Value.ToString();
                    array[j, 4] = dataGridView1[4, j].Value.ToString();
                    dataGridView1[5,j].Value = "Despachado";
                 }
            }
            //new frmFDespachar(array,cont).ShowDialog(); //chama a outra tela
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(dataGridView1[0, dataGridView1.CurrentRow.Index].Value) == true)
            {
                if (dataGridView1[6, dataGridView1.CurrentRow.Index].Value.ToString() == "Pendente")
                {
 
                }
                else 
                {
                    dataGridView1[6, dataGridView1.CurrentRow.Index].Value = "Pendente";
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
