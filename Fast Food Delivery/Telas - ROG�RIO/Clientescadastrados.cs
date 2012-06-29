using System;
using System.Collections;
using System.Windows.Forms;

namespace Telas
{
    public partial class frmClientescadastrados : Form
    {
        Cliente cl = new Cliente();
        ArrayList arr = new ArrayList();
        public static int venda = 0; //testa pra diferenciar se é pra editar ou selecionando na venda

        public frmClientescadastrados()
        {
            InitializeComponent();
        }

        private void frmVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmClientescadastrados_Load(object sender, EventArgs e)
        {
            PopularGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //esse aqui fica criado não pra quê?
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indice = dataGridView1.CurrentRow.Index;

                if (dataGridView1[0, indice].Value != null)  //0 é coluna e indice é linha
                {
                    new frmCadastrarcliente((Cliente)arr[indice]).ShowDialog();
                    PopularGrid();
                }
            }
            catch(Exception gt)
            {
                MessageBox.Show("Não foi possível prosseguir!\nMotivo: " + gt.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PopularGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            arr = cl.Clientess();
            for (int i = 0; i < arr.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1[0, i].Value = (((Cliente)arr[i]).Clientes);
                dataGridView1[1, i].Value = (((Cliente)arr[i]).Endereco);
                dataGridView1[2, i].Value = (((Cliente)arr[i]).Bairro);
                dataGridView1[3, i].Value = (((Cliente)arr[i]).Telefone);
                dataGridView1[4, i].Value = (((Cliente)arr[i]).Cpf);
            }
        }
    }
}
