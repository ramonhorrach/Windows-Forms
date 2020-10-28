using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string colours = "Choosen Colour: ";
            string colour1;
            string colour2;
            string colour3;

            if (radioButton1.Checked == true) {
                colour1 = radioButton1.Text;
                colours = colours + " " + colour1;
            }

            if (radioButton2.Checked == true)
            {
                colour2 = radioButton2.Text;
                colours = colours + " " + colour2;
            }

            if (radioButton3.Checked == true)
            {
                colour3 = radioButton3.Text;
                colours = colours + " " + colour3;
            }

            textBox1.Text = colours;

        }
    }
}
