using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix2x2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a11, a12, a21, a22, p1, p2, v, q1, q2;
            a11 = (float)Convert.ToDouble(textBox1.Text);
            a12 = (float)Convert.ToDouble(textBox2.Text);
            a21 = (float)Convert.ToDouble(textBox3.Text);
            a22 = (float)Convert.ToDouble(textBox4.Text);

            p1 = (a22 - a21) / (a11 + a22 - (a12 + a21));
            p2 = 1 - p1;
            textBox5.Text = "(" + p1.ToString() + ";" + p2.ToString() + ")";



            v = (a11 * p1) + (a21 * p2);
            textBox6.Text = v.ToString();
            q2 = (a11 - v) / (a11 - a12);
            q1 = 1 - q2;

            textBox7.Text = "(" + q1.ToString() + ";" + q2.ToString() + ")";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }
    }
}
