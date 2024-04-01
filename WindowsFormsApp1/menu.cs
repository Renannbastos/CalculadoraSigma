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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void calculadoraSIMPLESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 simples = new Form1();
            simples.ShowDialog();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 calculadora = new Form2();
            calculadora.ShowDialog();
        }
    }
}
