using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_1_YuzdeHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numbers1 =Convert.ToDouble(textBox1.Text);
            double numbers2 = Convert.ToDouble(textBox2.Text);
            double result= numbers1 * numbers2 / 100;
            double result2 = numbers1 - result ;
            textBox3.Text = result.ToString();
            textBox4.Text = result2.ToString();
        }
    }
}
