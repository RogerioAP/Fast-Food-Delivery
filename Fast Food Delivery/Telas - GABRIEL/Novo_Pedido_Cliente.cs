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
    public partial class Novopedido_clientes : Form
    {
        ArrayList arr = new ArrayList();
        Cliente clie = new Cliente();

        public Novopedido_clientes()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            if (radioButton1.Checked == true)
            {
                arr = clie.listarnome(txtBuscar.Text);

                for (int y = 0; y < arr.Count; y++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1[0, y].Value = ((Cliente)arr[y]).Clientes;
                    dataGridView1[1, y].Value = ((Cliente)arr[y]).Bairro;
                    dataGridView1[2, y].Value = ((Cliente)arr[y]).Endereco;
                    dataGridView1[3, y].Value = ((Cliente)arr[y]).Telefone;
                    dataGridView1[4, y].Value = ((Cliente)arr[y]).Cpf;
                    //dataGridView1.Rows.Add();
                    //dataGridView1.Rows.Add(((Cliente)arr[y]).Clientes.ToString(), ((Cliente)arr[y]).Bairro.ToString(), ((Cliente)arr[y]).Endereco.ToString(), ((Cliente)arr[y]).Telefone.ToString(),((Cliente)arr[y]).Cpf.ToString());
                }
            }
            else
            {
                arr = clie.listarcpf(txtBuscar.Text);
                for (int y = 0; y < arr.Count; y++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1[0, y].Value = ((Cliente)arr[y]).Clientes;
                    dataGridView1[1, y].Value = ((Cliente)arr[y]).Bairro;
                    dataGridView1[2, y].Value = ((Cliente)arr[y]).Endereco;
                    dataGridView1[3, y].Value = ((Cliente)arr[y]).Telefone;
                    dataGridView1[4, y].Value = ((Cliente)arr[y]).Cpf;
                   // dataGridView1.Rows.Add();
                   //dataGridView1.Rows.Add(((Cliente)arr[y]).Clientes, ((Cliente)arr[y]).Bairro, ((Cliente)arr[y]).Endereco, ((Cliente)arr[y]).Telefone, ((Cliente)arr[y]).Cpf);
                }
            }
        }
        
        private void btnAvancar_Click(object sender, EventArgs e)
        {
            int t = dataGridView1.CurrentRow.Index;
            if(dataGridView1[0, t].Value != null) //caso a linha não seja aquela que está BRANCA
            {
                //chama a outra tela passando como parâmentro dados do cliente selecionado
                new frmNovoPedido(((Cliente)arr[t]).Clientes, ((Cliente)arr[t]).Bairro, ((Cliente)arr[t]).Endereco).ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Linha inválida!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //new frmNovoPedido(dataGridView1[0, t].Value.ToString(), dataGridView1[1, t].Value.ToString(), dataGridView1[2, t].Value.ToString()).ShowDialog();

            //new Novopedido(usuario, nome, (Cliente)arr[dataGridView1.TabIndex].Nome, (Cliente)arr[dataGridView1.TabIndex].Codigo.ToString()).ShowDialog();
            // new frmNovoPedido(((Cliente)ar[t]).Clientes, ((Cliente)ar[t]).Bairro, ((Cliente)ar[t]).Endereco).ShowDialog();
        }

        private void btnNcliente_Click(object sender, EventArgs e)
        {
            new frmCadastrarcliente().ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
