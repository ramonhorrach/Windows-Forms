using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string student1 = "Joan";
            string student2 = "Pep";
            string student3 = "Tomeu";

            listBox1.Items.Add(student1);
            listBox1.Items.Add(student2);
            listBox1.Items.Add(student3);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string student = listBox1.SelectedItem.ToString();

            textBox1.Text = student;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string student4 = "Maria";
            string student5 = "Eloi";
            string student6 = "Ramon";

            listBox1.Items.Add(student4);
            listBox1.Items.Add(student5);
            listBox1.Items.Add(student6);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
