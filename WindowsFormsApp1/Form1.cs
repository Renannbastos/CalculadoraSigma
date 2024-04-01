using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btad_Click(object sender, EventArgs e)
        {
            lblresultado.Text = (float.Parse(num1.Text) + float.Parse(num2.Text)).ToString();
            lblsinal.Text = ("+");
        }

        private void btsb_Click(object sender, EventArgs e)
        {
            lblresultado.Text = (float.Parse(num1.Text) - float.Parse(num2.Text)).ToString();
            lblsinal.Text = ("-");
        }

        private void btmt_Click(object sender, EventArgs e)
        {
            lblresultado.Text = (float.Parse(num1.Text) * float.Parse(num2.Text)).ToString();
            lblsinal.Text = ("x");
        }

        private void btdv_Click(object sender, EventArgs e)
        {
            lblresultado.Text = (float.Parse(num1.Text) / float.Parse(num2.Text)).ToString();
            lblsinal.Text = ("/");
        }

        private void btpt_Click(object sender, EventArgs e)
        {
            lblresultado.Text = Math.Pow(float.Parse(num1.Text), float.Parse(num2.Text)).ToString();
            lblsinal.Text = ("^");
        }

        private void btcomp_Click(object sender, EventArgs e)
        {
            string n1 = num1.Text;
            string n2 = num2.Text;

            lblsinal.Text = (" ");

            if (float.Parse(num1.Text) > float.Parse(num2.Text))
            {
                lblresultado.Text = (n1+ " é o maior número");
            }
            else if (float.Parse(num1.Text) < float.Parse(num2.Text))
            {
                lblresultado.Text = (n2+ " é o maior número");
            }
            else
            {
                lblresultado.Text = ("Os números são iguais");
            }
                
            
        }

        private void btpar_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(num1.Text);
            int n2 = Convert.ToInt32(num2.Text);

            lblsinal.Text = (" ");

            int n3 = n1 + n2;

            if(n3 % 2 == 0)
            {
                lblresultado.Text = ("A soma dos dois números resulta em um PAR");
            }
            else
            {
                lblresultado.Text = ("A soma dos dois números resulta em um ÍMPAR");
            }
        }
    }
}
