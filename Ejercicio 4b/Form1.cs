using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_4b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                textBox4.Text = listBox1.SelectedItem.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int operando1 = Convert.ToInt32(textBox1.Text);
            int operando2 = Convert.ToInt32(textBox2.Text);
            int resultado;

            if (textBox4.Text.Equals("+"))
            {
                resultado = operando1 + operando2;
            }
            else {
                resultado = operando1 - operando2;
            }

            textBox3.Text = resultado.ToString();
        }
    }
}
