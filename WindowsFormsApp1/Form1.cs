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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c, ortalama;
            a=Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c= Convert.ToInt32(textBox3.Text);
            ortalama = (a + b + c) / 3;
            if (ortalama>100)
            {
                MessageBox.Show("geçersiz not");
            }
            else if (ortalama<0)
            {
                MessageBox.Show("geçersiz not");

            }


            else if (ortalama<=50)
            {
                MessageBox.Show("ff");
                textBox4.Text = ortalama.ToString();
            }
            else if (ortalama<=60&&ortalama>=50)
            {
                MessageBox.Show("dd");
                textBox4.Text = ortalama.ToString();
            }
            else if (ortalama <= 70&& ortalama>=60)
            {
                MessageBox.Show("cc");
                textBox4.Text = ortalama.ToString();
            }
            else if (ortalama <= 85&& ortalama>=70)
            {
                MessageBox.Show("bb");
                textBox4.Text = ortalama.ToString();
            }
            else
            {
                MessageBox.Show("aa");
                textBox4.Text = ortalama.ToString();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            label1.Text = " ";
        }
    }
}
