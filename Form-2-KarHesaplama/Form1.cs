using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_2_KarHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numbers1=Convert.ToDouble(textBox1.Text);
            double numbers2=Convert.ToDouble(textBox2.Text);
            double numbers3 = numbers2 + (numbers1* numbers2 / 100);
            textBox3.Text = numbers3.ToString();
        }
    }
}
