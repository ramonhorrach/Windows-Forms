using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string colour1;
            string colour2;
            string colour3;

            if (radioButton1.Checked == true) {
                colour1 = radioButton1.Text.ToString();

                textBox1.Text = "Choosen Colour: " + colour1;
            }

            if (radioButton2.Checked == true)
            {
                colour2 = radioButton2.Text.ToString();

                textBox1.Text = "Choosen Colour: " + colour2;
            }

            if (radioButton3.Checked == true)
            {
                colour3 = radioButton3.Text.ToString();

                textBox1.Text = "Choosen Colour: " + colour3;
            }
        }
    }
}
