using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int num;

            do
            {
                num = random.Next(1, 11);
            } while (num % 2 != 0);


            comboBox1.Items.Add("Nº " + num);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedItem.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int num;

            do
            {
                num = random.Next(1, 11);
            } while (num % 2 == 0);


            comboBox1.Items.Add("Nº " + num);
        }
    }
}
