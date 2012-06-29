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
    public partial class frmUsuarios_cadastrados : Form
    {
        string conta;
        string loginusuario;
        string id_usuario;

        Usuario us = new Usuario();
        ArrayList arr = new ArrayList();
        ArrayList ar = new ArrayList();
        
        public frmUsuarios_cadastrados()
        {
            InitializeComponent();
        }

        private void Usuarios_cadastrados_Load(object sender, EventArgs e)
        {
            arr = us.Usuarios();

            for (int i = 0; i < arr.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1[0, i].Value = (((Usuario)arr[i]).Nomecompleto);
                dataGridView1[1, i].Value = (((Usuario)arr[i]).Tipodeconta);
                dataGridView1[2, i].Value = (((Usuario)arr[i]).Email);
                dataGridView1[3, i].Value = (((Usuario)arr[i]).Codigo);
            }
        }

        private void btnExcluircliente_Click(object sender, EventArgs e)
        {
            int indice = dataGridView1.CurrentRow.Index;
            
            int t=0;
            arr = us.Usuarios(); //lista os usuários
            for(int i = 0; i<arr.Count; i++)
            {
                if (((Usuario)arr[i]).Tipodeconta == "administrador")
                //if (dataGridView1[1, i].Value == "administrador")
                {
                    t++;
                }
            }            

            //if (Usuario.status == "gerente")
            //{
            if (t > 1)  //caso tenha mais de 1 ADMINISTRADOR
            {
                us.Deletar(((Usuario)arr[indice]).Codigo);  //o parametro é o ID
                this.dataGridView1.Rows.Remove(this.dataGridView1.CurrentRow);
                MessageBox.Show("Usuário excluído com sucesso!", "Concluído!", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);

                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                arr = us.Usuarios();

                for (int i = 0; i < arr.Count; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1[0, i].Value = (((Usuario)arr[i]).Nomecompleto);
                    dataGridView1[1, i].Value = (((Usuario)arr[i]).Tipodeconta);
                    dataGridView1[2, i].Value = (((Usuario)arr[i]).Email);
                    dataGridView1[3, i].Value = (((Usuario)arr[i]).Codigo);
                }
                //int l = ((Usuario)arr[this.dataGridView1.CurrentRow.Index]).Codigo;
                // us.de
            }
            else
            {
                MessageBox.Show("O numero mínimo de administradore é 1!", "Erro!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            //}
        }

        private void btnEditarcliente_Click(object sender, EventArgs e)
        {
            int indice = dataGridView1.CurrentRow.Index;
            new Editarusuario(int.Parse(dataGridView1[3, indice].Value.ToString())).ShowDialog(); //passa o ID
            //new Editarusuario(((Usuario)ar[this.dataGridView1.CurrentRow.Index]).Codigo).ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == null)
            {
                MessageBox.Show("O campo está vazio!", "Erro!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                ar = us.listar(txtBuscar.Text);
                dataGridView1.DataSource = ar;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovocliente_Click(object sender, EventArgs e)
        {
            new frmNovo_usuario().ShowDialog();
        }
    }
}
