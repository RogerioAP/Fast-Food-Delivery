using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Telas
{
    public partial class frmTela_Logo : Form
    {
        public frmTela_Logo()
        {
            InitializeComponent();
        }

        private void frmTela_Logo_Load(object sender, EventArgs e)
        {
            //int segundo = int.Parse(DateTime.Now.Second.ToString());
            //int novo = 0;
            //MessageBox.Show(novo.ToString() + " e " + segundo.ToString());
            //for (int i = 0; i == 0; novo = int.Parse(DateTime.Now.Second.ToString()))
            //{
            //    if (novo == segundo + 2)
            //    {
            //        i++;
            //        Close();
            //    }
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //caso o segundo for == 58 || 59 || 60
            int segundo = int.Parse(DateTime.Now.Second.ToString());
            int novo = 0;
            if(segundo == 58 || segundo == 59 || segundo == 60)
            {
                segundo = 0;
            }
            //MessageBox.Show(novo.ToString() + " e " + segundo.ToString());
            for (int i = 0; i == 0; novo = int.Parse(DateTime.Now.Second.ToString()))
            {
                if (novo >= segundo + 3) //após três segundos a tela é fechada
                {
                    i++;
                    break;
                }
            }
            timer1.Stop();
            Close();

            //Opacity -= 0.05;
            //if (Opacity <= 0)
            //{
            //    this.Close();
            //}
        }
    }
}
