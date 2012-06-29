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
    public partial class frmNovoPedido : Form
    {
        ArrayList lst = new ArrayList();//arraylist para cardápio
        ArrayList br = new ArrayList();//arraylist para bairros

        Pedido Ped = new Pedido(); //instancia de cardápio
        Bairro bar = new Bairro();//instancia de bairro

        string[,] array;

        int auxiliar = 0;
        int contadorauxiliar;

        string cancelar;
        int quantidade = 0;
        float valorpedido;
        string tempoestimado;

        string fretep;
        string freteadd;

        public frmNovoPedido()
        {
            InitializeComponent();
        }

        public frmNovoPedido(string nomcliente, string bair, string end)
        {
            InitializeComponent();

            lblCliente.Text = nomcliente;
            lblBairro.Text = bair;
            lblEndereco.Text = end;

            br = bar.listar(bair); //bairros

            double y;
            //para ajudar calcular o percentual da compra
            y = (double.Parse(((Bairro)br[0]).Percentual)) / 100;
            fretep = y.ToString();      //necessário quando for usar a percentagem para fazer o cálculo da soma

            //para adicionar um valor fixo ao frete se o usuario quiser
            freteadd = ((Bairro)br[0]).Valordeentrega;
            lblTempoestimado.Text = ((Bairro)br[0]).Tempodeentrega;
        }

        public void LimparGrid()
        {
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
        }
        
        //private void btnAdicionar_Click(object sender, EventArgs e)
        //{
        //    if (int.Parse(txtQuantidade.Text) > 0)
        //    {
        //        float d;

        //        for (int j=0; j<dataGridView2.Rows.Count; j++)
        //        {
        //            if (Convert.ToBoolean(dataGridView2[0, j].Value) == true)
        //            {
        //                //d é o preco do produto já multiplicado pela quantidade
        //                d = float.Parse(dataGridViewX[2, j].ToString()) * float.Parse(txtQuantidade.Text);
        //                dataGridView1.Rows.Add(dataGridView2[1, j], d, txtQuantidade.Text);
        //                d=0;
        //            }
        //        }

        //        float temp2 = 0, temp = 0; //temp é o valor total
        //        //Somar o valor da compra


        //        for (int r = 0; r < dataGridView1.RowCount; r++)
        //        {
        //            temp2 = float.Parse(dataGridView1[1, r].Value.ToString());
        //            temp = temp + temp2;
        //        }

        //        lblValorcompra.Text = temp.ToString();                

        //        if (radioButton1.Checked == true) //valor fixo
        //        {
        //            txtValortotal.Text = (temp + float.Parse(freteadd)).ToString();
        //        }
        //        else if (radioButton2.Checked == true) //não cobrar
        //        {
        //            txtValortotal.Text = temp.ToString();
        //        }
        //        else if (radioButton3.Checked == true) //percentual
        //        {
        //            txtValortotal.Text = (temp + (temp * float.Parse(fretep))).ToString();
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("A quantidade deve ser maior que zero!", "Erro!", MessageBoxButtons.OK,
        //            MessageBoxIcon.Error);
        //    }
        //}

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            //int index = dataGridView2.CurrentRow.Index;
            //ArrayList lis = new ArrayList();
            //lis = Ped.listar(index);
                       
            //txtDescricao.Text = (((Pedido)lis[index]).Descricao);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            lblValorcompra.Text = null;
            txtValortotal.Text = null;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int indice = dataGridView1.CurrentRow.Index;
            if (dataGridView1[0, indice].Value != null)
            {
                this.dataGridView1.Rows.Remove(dataGridView1.Rows[dataGridView1.CurrentRow.Index]);

                double temp2 = 0, temp = 0;
                //Somar o valor da compra
                //soma o valor de todos o preços(preço * quantidade) no grid pedido
                for (int r = 0; dataGridView1[0, r].Value != null; r++)
                {
                    temp2 = double.Parse(dataGridView1[1, r].Value.ToString());
                    temp = temp + temp2;
                }
                lblValorcompra.Text = temp.ToString();

                if (radioButton1.Checked == true)
                {
                    txtValortotal.Text = (temp + float.Parse(freteadd)).ToString();
                }
                else if (radioButton2.Checked == true)
                {
                    txtValortotal.Text = temp.ToString();
                }
                else if (radioButton3.Checked == true)
                {
                    txtValortotal.Text = (temp + (temp * float.Parse(fretep))).ToString();

                    string val = txtValortotal.Text;
                    txtValortotal.Text = null;
                    bool virgula = false;
                    int contador = 0;
                    for (int w = 0; w < val.Length; w++) //for para deixar o texto "preço" no txt com um valor BOM,
                    {
                        if (contador <= 2 && contador != 0)
                        {
                            txtValortotal.Text += val[w];
                            contador++;
                        }
                        if (val[w] == ',')
                        {
                            txtValortotal.Text += val[w];
                            virgula = true;
                            contador++;
                        }
                        if (virgula == false)
                        {
                            txtValortotal.Text += val[w];
                        }
                    }
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtValortotal.Text = ((float.Parse(lblValorcompra.Text)) + float.Parse(freteadd)).ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //txtValortotal.Text = (float.Parse(lblValorcompra.Text) + (float.Parse(lblValorcompra.Text) * float.Parse(fretep))).ToString();

            double temp2 = 0, temp = 0;
            for (int r = 0; dataGridView1[0, r].Value != null; r++)
            {
                temp2 = double.Parse(dataGridView1[1, r].Value.ToString());
                temp = temp + temp2;
            }
            txtValortotal.Text = (temp + (temp * float.Parse(fretep))).ToString();

            string val = txtValortotal.Text;
            txtValortotal.Text = null;
            bool virgula = false;
            int contador = 0;
            for (int w = 0; w < val.Length; w++) //for para deixar o texto "preço" no txt com um valor BOM,
            {
                if (contador <= 2 && contador != 0)
                {
                    txtValortotal.Text += val[w];
                    contador++;
                }
                if (val[w] == ',')
                {
                    txtValortotal.Text += val[w];
                    virgula = true;
                    contador++;
                }
                if (virgula == false)
                {
                    txtValortotal.Text += val[w];
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtValortotal.Text = lblValorcompra.Text;
        }

        private void btnEfetuarPedido_Click(object sender, EventArgs e)
        {
            if (lblValorcompra.Text == null)
            {
                MessageBox.Show("A lista de compras está vazia!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string nomes_produtos = "";
                for (int s = 0; dataGridView1[0, s].Value != null; s++)
                {
                    if (nomes_produtos == "") //esse if e else serve para pegar o nome dos produtos do pedido
                    {                       //se for a primeira vez esse é excutado
                        nomes_produtos = dataGridView1[0, s].Value.ToString();
                    }
                    else //esse é executado do segundo produto em diante
                    {
                        nomes_produtos += ", " + dataGridView1[0, s].Value;
                    }
                }

                Vendas ped = new Vendas();

                ped.Entrega = 1;
                ped.Cliente = lblCliente.Text;
                ped.Funcionario = Usuario.usuarioativo;
                ped.Produto = nomes_produtos;
                ped.Valortotal = txtValortotal.Text;

                string da = DateTime.Now.Date.ToString("dd/MM/yyyy"); //pega a data
                string data = null;

                for (int f = 0; f < da.Length; f++)
                {
                    if (da[f] != '/')
                    {
                        data = data + da[f];
                    }
                }

                ped.Data = data; //manada a data sem as barras
                ped.Bairro = lblBairro.Text;
                ped.Endereco = lblEndereco.Text;

                try
                {
                    ped.Salvar();
                    MessageBox.Show("Pedido efetuado com sucesso!", "Concluído!", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                        //new frmDespachar().ShowDialog();

                        //for (int z = 0; dataGridView1[0, z].Value != null; z++)
                        //{
                        //    array[0, z] = lblCliente.Text; //cliente
                        //    array[1, z] = lblBairro.Text; //bairro
                        //    array[2, z] = lblEndereco.Text; //endereço
                        //    array[3, z] = ; //valor
                        //    array[4, z] = dataGridView1[0, z].Value.ToString(); //produtos
                        //}
                    Close();
                }
                catch (Exception h)
                {
                    MessageBox.Show("Não foi possível realizar o pedido.\n" + h.Message, "Erro!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmNovoPedido_Load(object sender, EventArgs e)
        {
            LimparGrid();

            //array pega todos os produtos
            lst = Ped.Produtoss();

            //lista todos os produtos no dataGridView
            for (int i = 0; i < lst.Count; i++) //enquanto tiver produtos continua o loop
            {
                if (((Pedido)lst[i]).Quantidade > 0) //caso o quantidade de um produto maior que 0
                {
                    string nome = ((Pedido)lst[i]).Nome;
                    string preco = ((Pedido)lst[i]).Preco;

                    dataGridView2.Rows.Add();
                    dataGridView2[0, i].Value = nome;
                    dataGridView2[1, i].Value = preco;
                    nome = string.Empty;
                    preco = string.Empty;


                    //string nome = ((Pedido)lst[i]).Nome;
                    //string preco = ((Pedido)lst[i]).Preco;
                    //try
                    //{
                    //    dataGridView2.Rows.Add();
                    //}
                    //catch (Exception ex)
                    //{ }

                    //dataGridView2[1, i].Value = nome;
                    //dataGridView2[2, i].Value = preco;
                    //nome = string.Empty;

                    //dataGridView2.Rows.Add(true, nome, preco);
                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "Adicionar")
            {
                int indice = dataGridView2.CurrentRow.Index;

                //if (int.Parse(dataGridView2[3, 1].Value.ToString()) <= 0)
                //{
                //    MessageBox.Show("A quantidade está errada!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }

            //dataGridView1.Columns[e.ColumnIndex].Name == "Adicionar"
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtQuantidade.Text == "")
            {
                MessageBox.Show("A quantidade deve ser maior que zero!", "Erro!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (int.Parse(txtQuantidade.Text) > 0)
            {
                double d;

                int indice = dataGridView2.CurrentRow.Index;

                d = double.Parse(dataGridView2[1, indice].Value.ToString()) * double.Parse(txtQuantidade.Text); //multiplica para saber valor total
                dataGridView1.Rows.Add(dataGridView2[0, indice].Value, d, txtQuantidade.Text, dataGridView2[2, indice].Value); //adiciona na tabela pedido
                d = 0;
                
                double temp2 = 0, temp = 0; //temp é o valor total
                //Somar o valor da compra

                //for (int r = 0; r < dataGridView1.Rows.Count; r++)
                for (int r = 0; dataGridView1[0, r].Value != null; r++)
                {
                    temp2 = double.Parse(dataGridView1[1, r].Value.ToString()); //preço
                    temp = temp + temp2; //somando para saber o valor total
                    temp2 = 0;
                }

                lblValorcompra.Text = temp.ToString(); //passa o valor total para o label

                if (radioButton1.Checked == true) //valor fixo
                {
                    txtValortotal.Text = (temp + float.Parse(freteadd)).ToString();
                }
                else if (radioButton2.Checked == true) //não cobrar
                {
                    txtValortotal.Text = temp.ToString();
                }
                else if (radioButton3.Checked == true) //percentual
                {
                    txtValortotal.Text = (temp + (temp * float.Parse(fretep))).ToString();

                    string val = txtValortotal.Text;
                    txtValortotal.Text = null;
                    bool virgula = false;
                    int contador = 0;
                    for (int w = 0; w < val.Length; w++) //for para deixar o texto "preço" no txt com um valor BOM,
                    {
                        if (contador <= 2 && contador != 0)
                        {
                            txtValortotal.Text += val[w];
                            contador++;
                        }
                        if (val[w] == ',')
                        {
                            txtValortotal.Text += val[w];
                            virgula = true;
                            contador++;
                        }
                        if(virgula == false)
                        {
                            txtValortotal.Text += val[w];
                        }
                    }
                }
            }
        }
    }
}
