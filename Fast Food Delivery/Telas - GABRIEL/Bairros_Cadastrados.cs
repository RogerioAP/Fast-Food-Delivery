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
    public partial class frmBairros_cadastrados : Form
    {

        Bairro bar = new Bairro();
        ArrayList arr = new ArrayList();
        ArrayList ar = new ArrayList();
      
        public frmBairros_cadastrados()
        {
            InitializeComponent();
            arr = bar.listar();
        }
        
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Remove(this.dataGridView1.CurrentRow);
            int l = ((Bairro)ar[this.dataGridView1.CurrentRow.Index]).Idbairro;
            bar.Deletarbairro(l);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            MessageBox.Show(dataGridView1[4, i].Value.ToString());
            new frmEditarbairros(int.Parse(dataGridView1[4, i].Value.ToString())).ShowDialog(); //passa o ID
        }

        private void Bairros_cadastrados_Load(object sender, EventArgs e)
        {
            PopularGrid();
        }

        public void LimparGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
        }

        public void PopularGrid()
        {
            ar = bar.listar(txtBuscar.Text);

            for (int i = 0; i < ar.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1[0, i].Value = (((Bairro)ar[i]).Nome);
                dataGridView1[1, i].Value = (((Bairro)ar[i]).Tempodeentrega);
                dataGridView1[2, i].Value = (((Bairro)ar[i]).Valordeentrega);
                dataGridView1[3, i].Value = (((Bairro)ar[i]).Percentual);
                dataGridView1[4, i].Value = (((Bairro)ar[i]).Idbairro); //ID
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            LimparGrid();
            PopularGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new frmNovobairro().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
