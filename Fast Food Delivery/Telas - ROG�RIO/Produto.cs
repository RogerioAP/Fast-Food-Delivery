using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;

namespace Telas
{
    public partial class frmProduto : Form
    {
        Pedido pe = new Pedido();
        ArrayList arr = new ArrayList();
        int Codigo;

        public frmProduto()
        {
            InitializeComponent();
        }

        public frmProduto(Pedido ped)
        {
            InitializeComponent();

            Codigo = ped.Idprodutos;
            txtProduto.Text = ped.Nome;
            txtPreco.Text = ped.Preco;
            txtQuantidade.Text = ped.Quantidade.ToString();
            txtDescricao.Text = ped.Descricao;
            btnExcluir.Enabled = true;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Verificacampos()
        {
            lblProduto.ForeColor = Color.Red;
            lblPreco.ForeColor = Color.Red;
            lblQuantidade.ForeColor = Color.Red;
            lblDescricao.ForeColor = Color.Red;

            lblProduto.Text = "Produto *";
            lblPreco.Text = "Preço R$*";
            lblQuantidade.Text = "Quantidade *";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtProduto.Text == null || txtPreco.Text == null || txtQuantidade.Text == null)
            {
                MessageBox.Show("Os campos com * não podem ser nulos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Verificacampos();
            }
            else
            {
                try
                {
                    pe.Nome = txtProduto.Text;
                    pe.Descricao = txtDescricao.Text;
                    pe.Preco = txtPreco.Text;
                    pe.Quantidade = int.Parse(txtQuantidade.Text);

                    if (Codigo == 0)
                    {
                        pe.Salvar();
                        MessageBox.Show("Produto adicionado com sucesso!", "Concluído!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Limpar();
                    }
                    else if(Codigo != 0)
                    {
                        pe.Alteracaoproduto(Codigo);
                        MessageBox.Show("Alteração realizada com sucesso!", "Concluído!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Limpar();
                        Close();
                    }
                }
                catch (Exception ec)
                {
                    MessageBox.Show("Não foi possível concluir!\nMotivo: " + ec.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpar();
                }
            }
        }

        public void Limpar()
        {
            txtProduto.Text = null;
            txtDescricao.Text = null;
            txtPreco.Text = null;
            txtQuantidade.Text = null;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                pe.Excluirproduto(Codigo);
                MessageBox.Show("Produto excluído com sucesso!", "Concluído!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Close();
            }
            catch(Exception sd)
            {
                MessageBox.Show("Não foi possível excluir o produto!\nMotivo: " + sd.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            System.Diagnostics.Process.Start("calc");
            Cursor = Cursors.Default;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblProduto_Click(object sender, EventArgs e)
        {

        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPreco_Click(object sender, EventArgs e)
        {

        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblQuantidade_Click(object sender, EventArgs e)
        {

        }

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
