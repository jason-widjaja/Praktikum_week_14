using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum_Week_14
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (input.Text == "")
            {
                MessageBox.Show("Tolong Isi Textbox Terlebih Dahulu");
            }
            else
            {
                string a = input.Text;
                char[] b = a.ToCharArray();
                Array.Sort(b);
                string c = new string(b);
                hasil.Text = c;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void reverse_Click(object sender, EventArgs e)
        {
            if (input.Text == "")
            {
                MessageBox.Show("Tolong Isi Textbox Terlebih Dahulu");
            }
            else
            {
                string a = input.Text;
                char[] b = a.ToCharArray();
                Array.Reverse(b);
                string c = new string(b);
                hasil.Text = c;
            }
        }
    }
}