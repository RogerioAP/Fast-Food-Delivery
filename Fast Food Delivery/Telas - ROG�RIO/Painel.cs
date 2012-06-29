using System;
using System.Windows.Forms;
using System.Collections;

namespace Telas
{
    public partial class frmPainel : Form
    {
        Cliente cl = new Cliente();
        Pedido pe = new Pedido();
        Usuario us = new Usuario();
        ArrayList arr = new ArrayList();
        ArrayList arr2 = new ArrayList();
        Vendas ve = new Vendas();

        public frmPainel()
        {
            InitializeComponent();
            lblUsuarioativo.Text = lblUsuarioativo.Text + Usuario.usuarioativo;
            if (Usuario.status == "funcionario")
            {
                tsmAdministrador.Enabled = false;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            us.Tirartipodeconta();
            us.TirarUsuario();
            Close();
        }

        private void frmPainel_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Space:
                    new frmLabirinto().ShowDialog();
                    break;
            }
        }

        private void btnEntregaspendentes_Click(object sender, EventArgs e)
        {
            new frmEntregas_pendentes().ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tsmSair_Click_1(object sender, EventArgs e)
        {
            int qu = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if(dataGridView1[1, i].Value != null)
                {
                    qu++;
                    break;
                }
            }

            if(qu > 0)
            {
                DialogResult dialogo = MessageBox.Show("Ainda existem pedidos pendentes!\nMesmo encerrando a aplicação, é possível vê-los depois, quando entrar novamente no sistema!\nDeseja sair assim mesmo?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.Yes)
                {
                    Close();
                }
                else
                {
                    dataGridView1.Visible = true;
                    btnConcluir.Visible = true;
                    btnCancelar.Visible = true;
                }
            }
            else
            {
                Close();
            }
        }

        public void Listarpendentes() //lista todos os pedidos ainda não concluídos
        {
            dataGridView1.DataSource = null; //limpa o dataGridView
            dataGridView1.Rows.Clear();

            arr = ve.Listarvendas(); //lista no painel todas as vendas que estão pendentes
            for (int i = 0; i < arr.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1[2, i].Value = (((Vendas)arr[i]).Cliente);
                dataGridView1[3, i].Value = (((Vendas)arr[i]).Bairro);
                dataGridView1[4, i].Value = (((Vendas)arr[i]).Valortotal);
                dataGridView1[5, i].Value = (((Vendas)arr[i]).Idvenda);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //clique no checkBox
        {
            if(dataGridView1.Columns[e.ColumnIndex].Name == "Selecione") //para deixar somente um checkedList marcado
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if(bool.Parse(dataGridView1[0, i].EditedFormattedValue.ToString()))
                    {
                        dataGridView1[0, i].Value = null;
                    }
                }
            }
        }

        //private void btnCancelar_Click(object sender, EventArgs e) //botão CANCELAR
        //{
        //    /*aqui terá que pegar o código e separá-lo para adicionar a quantidade de cada produto
        //     * no banco de dados
        //     */
        //    int cont = 0; //serve para verificar se selecionou alguma coisa
        //    for (int i = 0; i < dataGridView1.Rows.Count; i++)
        //    {
        //        try
        //        {
        //            if (bool.Parse(dataGridView1[0, i].EditedFormattedValue.ToString())) //pegar e separar o código
        //            {
        //                arr = ve.Listarvendas();
        //                cont++;

        //                string codigoo = (((Vendas)arr[i]).Codigo).ToString();

        //                int contando = 1;
        //                string total = "";
        //                for (int r = 0; r < codigoo.ToString().Length; r++)
        //                {
        //                    if (codigoo[r].ToString() != "=") //pega o 1° número(quantidade de 
        //                    {                                                                   //produtos diferentes)
        //                        total += codigoo[r].ToString();
        //                    }
        //                    else { break; }
        //                }


        //                string antigo = codigoo; //aqui nessa parte separa o 1° número do restante
        //                codigoo = "";

        //                int f = 0;
        //                for (int h = 0; h < antigo.Length; h++) //o 1° do codigoo tem que ser "-"
        //                {                            
        //                    if (f != 0)
        //                    {
        //                        codigoo += antigo[h];
        //                    }
        //                    if (antigo[h].ToString() == "=")
        //                    {
        //                        codigoo += "-";
        //                        f++;
        //                    }
        //                }

        //                while (contando <= int.Parse(total))
        //                {
        //                    int g = 0;
        //                    string idpr = "", quanti = "";

        //                    for (int p = 0; p < codigoo.Length; p++) //pega o id do produto
        //                    {
        //                        if (g != 0 && codigoo[p].ToString() != ",")
        //                        {
        //                            idpr += codigoo[p].ToString();
        //                        }
        //                        else if(codigoo[p].ToString() == "-")
        //                        {
        //                            g++;
        //                        }
        //                        else if (codigoo[p].ToString() == ",")
        //                        {
        //                            break;
        //                        }
        //                    }

        //                    int t = 0;
        //                    for (int p = 0; p < codigoo.Length; p++)
        //                    {
        //                        if (t != 0 && codigoo[p].ToString() != "-")
        //                        {
        //                            quanti += codigoo[p].ToString(); //pega a quantidade a ser adicionada no BD
        //                        }
        //                        if (codigoo[p].ToString() == ",")
        //                        {
        //                            t++;
        //                        }
        //                        if (t !=0 && codigoo[p].ToString() == "-")
        //                        {
        //                            break;
        //                        }
        //                    }
        //                    //MessageBox.Show(idpr + " " + quanti);

        //                    arr = null;
        //                    arr = new Pedido().Produtoss();
        //                    for (int p = 0; p < arr.Count; p++)
        //                    {
        //                        if (idpr == (((Pedido)arr[p]).Idprodutos).ToString())
        //                        {
        //                            int esto = (((Pedido)arr[p]).Quantidade); //estoque
        //                            int calculado = esto + int.Parse(quanti); //quantidade já atualizada
        //                            new Pedido().Alterar(calculado, (((Pedido)arr[p]).Nome)); //atualiza o BD
        //                            break;
        //                        }
        //                    }
        //                    //MessageBox.Show(idpr + " " + quanti);

        //                    antigo = codigoo;
        //                    codigoo = "";

        //                    if (contando < int.Parse(total))
        //                    {
        //                        int w = 0;
        //                        for (int h = 0; h < antigo.Length; h++) //o 1° do codigoo tem que ser "-"
        //                        {
        //                            if(antigo[h].ToString() == "-")
        //                            {
        //                                w++;
        //                            }
        //                            if(w >= 2)
        //                            {
        //                                codigoo += antigo[h].ToString();
        //                            }
        //                        }
        //                        MessageBox.Show(codigoo);
        //                    }
        //                    contando++;
        //                } //fim do WHILE, após isso a quantidade já terá sido atualizada. Restando excluir o pedido do BD

        //                new Vendas().Deletarpedido(int.Parse(dataGridView1[4, i].Value.ToString())); //excluir o pedido
        //                dataGridView1.Rows.Remove(dataGridView1.Rows[i]); //remove a linha

        //                MessageBox.Show("Pedido cancelado com sucesso!", "Concluído!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        //                break;
        //            }
        //        }
        //        catch(Exception fg)
        //        {
        //            MessageBox.Show("Não foi possível cancelar!\nMotivo: " + fg.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    if (cont == 0)
        //    {
        //        MessageBox.Show("Você não selecionou nada!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void btnConcluir_Click(object sender, EventArgs e) //botão CONCLUIR
        {
            /*a princípio esse botão somente retira a linha do dataGridView que contém o pedido ser concluído
             * e também marca na entrega no BD como entrega=1
             * 
             * Quando a entrega estiver 1 > já foi concluída
             * Quando entrega estiver 0 > ela está pendente
             */

                int cont = 0;
                for (int d = 0; d < dataGridView1.Rows.Count; d++)
                {
                    try
                    {
                        if (bool.Parse(dataGridView1[0, d].EditedFormattedValue.ToString()))
                        {
                            int idvend = int.Parse(dataGridView1[4, d].Value.ToString());
                            ve.Entregaconcluida(idvend);
                            dataGridView1.Rows.Remove(dataGridView1.Rows[d]);
                            cont++;
                            MessageBox.Show("Venda concluída com sucesso!", "Concluído!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            break;
                        }
                    }
                    catch (Exception xc)
                    {
                        MessageBox.Show("Não foi possível conclui a venda.\nMotivo: " + xc.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (cont == 0)
                {
                    MessageBox.Show("Você não selecionou nada!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void configuraçõesGeraisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmGerais().ShowDialog();
        }

        private void tsmNovopedido_Click(object sender, EventArgs e)
        {
            //faz um for para verificar se existem clientes cadastrados
            arr = null;
            arr = cl.Clientess();
            if(arr.Count == 0)
            {
                MessageBox.Show("Não tem CLIENTE cadastrado para efetuar um pedido!", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //se tiver cliente testa para ver se também produtos cadastrados
            {
                arr2 = null;
                arr2 = pe.Produtoss();
                if(arr2.Count == 0)
                {
                    MessageBox.Show("Não tem PRODUTOS cadastrados para efetuar um pedido!", "Erro!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    new Novopedido_clientes().ShowDialog();
                }
            }
        }

        private void tsmCadastrarcliente_Click(object sender, EventArgs e)
        {
            new frmCadastrarcliente().ShowDialog();
        }

        private void tsmClientescadastrados_Click(object sender, EventArgs e)
        {
            new frmClientescadastrados().ShowDialog();
        }

        private void tsmAdicionarprodutos_Click(object sender, EventArgs e)
        {
            new frmProduto().ShowDialog();
        }

        private void tsmProdutoscadastrados_Click(object sender, EventArgs e)
        {
            new frmProdutoscadastrados().ShowDialog();
        }

        private void tsmBairroscadastrados_Click(object sender, EventArgs e)
        {
            new frmNovobairro().ShowDialog();
        }

        private void tsmRelatorio_Click(object sender, EventArgs e)
        {
            new frmRelatorio().ShowDialog();
        }

        private void tsmAlterarsenha_Click(object sender, EventArgs e)
        {
            new frmAlterarsenha().ShowDialog();
        }

        private void usuáriosCadastradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmUsuarios_cadastrados().ShowDialog();
        }

        private void tsmCadastrarusuario_Click(object sender, EventArgs e)
        {
            new frmNovo_usuario().ShowDialog();
        }

        private void bairrosCadastradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmBairros_cadastrados().ShowDialog();
        }

        private void tsmSobre_Click(object sender, EventArgs e)
        {
            new frmSobre().ShowDialog();
        }
    }
}
