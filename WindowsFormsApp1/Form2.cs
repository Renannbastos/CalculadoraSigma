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
    public partial class Form2 : Form
    {
        decimal calculo;
        bool adicao = false, subtracao = false, divisao = false, multiplicacao = false, resultado = false;

        public Form2()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            lblresultado.Text += ("1");
            lblconta.Text += ("1");
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            lblresultado.Text += ("2");
            lblconta.Text += ("2");
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            lblresultado.Text += ("3");
            lblconta.Text += ("3");
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            lblresultado.Text += ("4");
            lblconta.Text += ("4");
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            lblresultado.Text += ("0");
            lblconta.Text += ("0");
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            lblresultado.Text += ("5");
            lblconta.Text += ("5");
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            lblresultado.Text += ("6");
            lblconta.Text += ("6");
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            lblresultado.Text += ("7");
            lblconta.Text += ("7");
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            lblresultado.Text += ("8");
            lblconta.Text += ("8");
        }

        private void btigual_Click(object sender, EventArgs e)
        {
            resultado = true;

            lblconta.Text += ("=");

            if (adicao == true)
            {
                lblresultado.Text = Convert.ToString(Convert.ToDecimal(lblresultado.Text) + calculo);
            }
            if (subtracao == true)
            {
                lblresultado.Text = Convert.ToString(calculo - Convert.ToDecimal(lblresultado.Text));
            }
            if (divisao == true)
            {
                decimal tomas, result;
                if (lblresultado.Text != "0")
                {
                    result = Convert.ToDecimal(lblresultado.Text);
                    tomas = result / calculo;
                }

                else
                {
                    MessageBox.Show("Não é possível dividir por 0");
                }
            }
            if (multiplicacao == true)
            {
                lblresultado.Text = Convert.ToString(Convert.ToDecimal(lblresultado.Text) * calculo);
            }
        }


        private void btdiv_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal(lblresultado.Text);

            lblconta.Text += ("/");
            lblresultado.Text = ("");

            adicao = false;
            subtracao = false;
            divisao = true;
            multiplicacao = false;
        }

        private void btvirgula_Click(object sender, EventArgs e)
        {
            lblresultado.Text += (",");
            lblconta.Text += (",");
        }

        private void btlimpa_Click(object sender, EventArgs e)
        {
            try
            {
                string apagar = lblresultado.Text;
                apagar = apagar.Remove(apagar.Length - 1);

                lblresultado.Text = apagar;
                lblconta.Text = apagar;
            }
            catch(Exception)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal tomas,result;
            result = Convert.ToDecimal(lblresultado.Text);
            tomas = result * -1;
            lblresultado.Text = Convert.ToString(tomas);
            lblconta.Text = Convert.ToString(tomas);
        }

        private void lblconta_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form2_KeyDown);
        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private bool keyPressed = false;

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (!keyPressed)
            {
                keyPressed = true;
                switch (e.KeyCode)
                {
                    case Keys.D0:
                        bt0_Click(null, null);
                        break;
                    case Keys.D1:
                        bt1_Click(null, null);
                        break;
                    case Keys.D2:
                        bt2_Click(null, null);
                        break;
                    case Keys.D3:
                        bt3_Click(null, null);
                        break;
                    case Keys.D4:
                        bt4_Click(null, null);
                        break;
                    case Keys.D5:
                        bt5_Click(null, null);
                        break;
                    case Keys.D6:
                        bt6_Click(null, null);
                        break;
                    case Keys.D7:
                        bt7_Click(null, null);
                        break;
                    case Keys.D8:
                        bt8_Click(null, null);
                        break;
                    case Keys.D9:
                        bt9_Click(null, null);
                        break;
                    case Keys.Add:
                        btmais_Click(null, null);
                        break;
                    case Keys.Subtract:
                        btmenos_Click(null, null);
                        break;
                    case Keys.Divide:
                        btdiv_Click(null, null);
                        break;
                    case Keys.Multiply:
                        btmulti_Click(null, null);
                        break;
                    case Keys.Back:
                        btlimpa_Click(null, null);
                        break;
                }
            }
        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            keyPressed = false;
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            lblresultado.Text += ("9");
            lblconta.Text += ("9");
        }

        private void btmais_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal(lblresultado.Text);

            lblconta.Text += ("+");
            lblresultado.Text = ("");

            adicao = true;
            subtracao = false;
            divisao = false;
            multiplicacao = false;
        }

        private void btmenos_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal(lblresultado.Text);
            
            lblconta.Text += ("-");
            lblresultado.Text = ("");

            adicao = false;
            subtracao = true;
            divisao = false;
            multiplicacao = false;
        }

        private void btmulti_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal(lblresultado.Text);

            lblconta.Text += ("x");
            lblresultado.Text = ("");

            adicao = false;
            subtracao = false;
            divisao = false;
            multiplicacao = true;
        }
    }
}
