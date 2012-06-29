using System;
using System.Windows.Forms;

namespace Telas
{
    public partial class frmLabirinto : Form
    {
        public frmLabirinto()
        {
            InitializeComponent();
        }
        int x = 0;

        private void lblChegada_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
            if(lblContagem.Text == "0") { MessageBox.Show("Você trapasseou!", "Que vergonha hei!", MessageBoxButtons.OK, MessageBoxIcon.Error); x = 0; }
            else if (x > 0) { MessageBox.Show("Você ganhou! Com o tempo de " + lblContagem.Text + ".", "Parabéns!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); x = 0; }
            else { MessageBox.Show("Você trapasseou!", "Que vergonha hei!", MessageBoxButtons.OK, MessageBoxIcon.Error); x = 0; }
            lblContagem.Text = "0";
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Errou. Recomece na \"Saída\".", "Que pena...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            x = 0;
            lblContagem.Text = "0";
        }

        int soma=0;
        private int Soma()
        {
            soma = soma + 1;
            return soma;
        }

        public void lblPonto1_MouseEnter(object sender, EventArgs e)
        {
            x = Soma();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int r = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            r = int.Parse(lblContagem.Text);
            r++;
            lblContagem.Text = r.ToString();
        }

        private void lblSaida_MouseEnter(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
