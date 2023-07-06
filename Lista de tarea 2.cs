using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_de_tarea_2
{
    public partial class Form1 : Form
    {
        List<int> Milista = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            n = int.Parse(textBox1.Text);
            Milista.Add(n);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int n, pos;
            n = int.Parse(textBox1.Text);
            pos = int.Parse(textBox2.Text);
            Milista.Insert(pos, n);
            textBox1.Clear();
            textBox1.Focus();
            textBox2.Clear();
            textBox2.Focus();


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int pos;
            pos = int.Parse(textBox2.Text);
            textBox2.Clear();
            textBox2.Focus();
            Milista.RemoveAt(pos);



        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n;
            n = int.Parse(textBox1.Text);
            Milista.Remove(n);
            textBox1.Clear();
            textBox1.Focus();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            int i;
            listBox1.Items.Clear();
            for (i = 0; i<= Milista.Count - 1; i++)
            {
                listBox1.Items.Add(Milista.ElementAt(i));
               
            }
             
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
