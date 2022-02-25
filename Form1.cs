using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBoxX.Text);
            double y = double.Parse(textBoxY.Text);
            double z = double.Parse(textBoxZ.Text);
            textBox4.Text += Environment.NewLine + "x =" + x.ToString() + Environment.NewLine + "y =" + y.ToString() + Environment.NewLine + "z =" + z.ToString();
            double f = Math.Abs(Math.Pow(x, y / x) - Math.Pow((y / x), 1.0 / 3)) + (y - x) * (Math.Cos(y) - (z / (y - x))) / (1 + Math.Pow((y - x), 2));
            textBox4.Text += Environment.NewLine + "F =" + f.ToString() + Environment.NewLine;
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxX.Text) || String.IsNullOrEmpty(textBoxY.Text) || String.IsNullOrEmpty(textBoxZ.Text))
                button1.Enabled = false;
            else button1.Enabled = true;
        }
    }
}
