using System;
using System.Windows.Forms;
using System.Collections;

namespace Telas
{
    public partial class frmProdutoscadastrados : Form
    {
        ArrayList arr = new ArrayList();
        Pedido pe = new Pedido();

        public frmProdutoscadastrados()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmProdutoscadastrados_Load(object sender, EventArgs e)
        {
            PopularGrid();
        }

        public void PopularGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            arr = pe.Produtoss();
            for (int i = 0; i < arr.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1[0, i].Value = (((Pedido)arr[i]).Nome);
                dataGridView1[1, i].Value = (((Pedido)arr[i]).Descricao);
                dataGridView1[2, i].Value = "R$ " + (((Pedido)arr[i]).Preco);
                dataGridView1[3, i].Value = (((Pedido)arr[i]).Quantidade);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = dataGridView1.CurrentRow.Index;
            try
            {
                if(dataGridView1[0, indice].Value != null)
                {
                    new frmProduto((Pedido)arr[indice]).ShowDialog();
                    PopularGrid();
                }
            }
            catch(Exception fr)
            {
                MessageBox.Show("Não foi possível prosseguir!\nMotivo: " + fr.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}
