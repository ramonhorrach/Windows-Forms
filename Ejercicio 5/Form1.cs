using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string animales = "Choosen animals: ";
            string animal1;
            string animal2;
            string animal3;

            if (checkBox1.Checked == true)
            {
                animal1 = checkBox1.Text;

                animales = animales + " " + animal1;
            }
            if (checkBox2.Checked == true)
            {
                animal2 = checkBox2.Text;

                animales = animales + " " + animal2;
            }
            if (checkBox3.Checked == true)
            {
                animal3 = checkBox3.Text;

                animales = animales + " " + animal3;
            }
            if(animales.Equals("Choosen animals: ")) {
                animales = animales + "No ha seleccionado ningún animal";
            }

            textBox1.Text = animales;
        }
    }
}
