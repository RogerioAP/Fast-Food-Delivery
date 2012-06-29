using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;

namespace Telas
{
    public partial class frmCadastrarcliente : Form
    {
        Cliente cl = new Cliente();
        ArrayList arr = new ArrayList();
        Bairro bai = new Bairro();

        int Codigo;

        public frmCadastrarcliente()
        {
            InitializeComponent();
        }

        public frmCadastrarcliente(Cliente cli) //construtor para alterar ou excluir
        {
            InitializeComponent();

            Codigo = cli.Idclientes;
            txtNome.Text = cli.Clientes;
            txtEndereco.Text = cli.Endereco;
            cbxBairro.Text = cli.Bairro;
            txtTelefone.Text = cli.Telefone;
            txtCpf.Text = cli.Cpf;
            txtCpf.Enabled = false;
            btnExcluir.Enabled = true;
        }

        public void Verificarcampos() //altera campos em caso de algum está nulo
        {
            lblNome.ForeColor = Color.Red;
            lblEndereco.ForeColor = Color.Red;
            lblBairro.ForeColor = Color.Red;
            lblTelefone.ForeColor = Color.Red;
            lblCpf.ForeColor = Color.Red;

            lblNome.Text = "Nome *";
            lblEndereco.Text = "Endereço *";
            lblBairro.Text = "Bairro *";
            lblTelefone.Text = "Telefone *";
            lblCpf.Text = "CPF *";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int conta = 0;
            if (txtNome.Text == string.Empty || txtEndereco.Text == string.Empty || cbxBairro.Text == string.Empty || txtCpf.Text == string.Empty)
            {
                MessageBox.Show("Os campos * não podem ser nulos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Verificarcampos();
            }
            else
            {
                if (btnExcluir.Enabled == true) //alteração o cliente
                {
                    try
                    {
                        cl.Clientes = txtNome.Text;
                        cl.Endereco = txtEndereco.Text;
                        cl.Bairro = cbxBairro.Text;
                        cl.Telefone = txtTelefone.Text;
                        cl.Cpf = txtCpf.Text;

                        cl.Alterarcliente(txtCpf.Text);
                        MessageBox.Show("Alteração realizada com sucesso!", "Concluído!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Verificarbairro();
                    }
                    catch (Exception l)
                    {
                        MessageBox.Show("Não foi possível realizar a alteração!\nMotivo: " + l.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                else if (btnExcluir.Enabled == false) //cadastra normalmente
                {
                    arr = cl.Clientess();
                    for (int i = 0; i < arr.Count; i++)
                    {
                        if (txtNome.Text == (((Cliente)arr[i]).Clientes))
                        {
                            conta++; //cliente EXISTE
                            MessageBox.Show("O usuário já existe!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }

                    if (conta == 0) //se o cliente não existir
                    {
                        try
                        {
                            cl.Clientes = txtNome.Text;
                            cl.Endereco = txtEndereco.Text;
                            cl.Bairro = cbxBairro.Text;
                            cl.Telefone = txtTelefone.Text;
                            cl.Cpf = txtCpf.Text;
                            cl.Salvar();
                            MessageBox.Show("Cliente cadastrado com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            Verificarbairro();
                        }
                        catch (Exception x)
                        {
                            MessageBox.Show("Não foi possível concluir.\nMotivo: " + x.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

        }


        public void Verificarbairro()
        {
            arr = bai.listar(); //verifica se o bairro já existe
            int cont = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                if (cbxBairro.Text ==  (((Bairro)arr[i]).Nome)) // (((Bairro)arr[i]).Nome))
                {
                    cont++;
                }
            }
            if (cont == 0) //se não existir, pergunta se quer cadastrar
            {
                DialogResult dialogo = MessageBox.Show("O bairro declarado NÃO EXISTE,\ndeseja cadastrar o bairro agora?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.Yes) //clicou em SIM
                {
                    new frmNovobairro(cbxBairro.Text).ShowDialog();
                }
            }
            Limpar();
            Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Limpar()
        {
            txtNome.Text = null;
            txtEndereco.Text = null;
            cbxBairro.Text = null;
            txtTelefone.Text = null;
            txtCpf.Text = null;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty || txtEndereco.Text == string.Empty || cbxBairro.Text == string.Empty || txtCpf.Text == string.Empty)
            {
                MessageBox.Show("Os campos não podem ser nulos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    cl.Deletar(txtNome.Text);
                    MessageBox.Show("Cliente excluído com sucesso!", "Concluído!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Close();
                }
                catch(Exception xd)
                {
                    MessageBox.Show("Não foi possível excluir o cliente!\nMotivo: " + xd.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void frmCliente_Load(object sender, EventArgs e)
        {
            arr = bai.listar(); //listar os bairros cadastrados
            cbxBairro.Items.Clear();
            for (int i = 0; i < arr.Count; i++)
            {
                cbxBairro.Items.Add(((Bairro)arr[i]).Nome);
            }
        }

        private void frmCadastrarcliente_Load(object sender, EventArgs e)
        {

        }
    }
}
