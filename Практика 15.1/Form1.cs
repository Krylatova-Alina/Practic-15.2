using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_15._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "")
                    throw new Exception("Нет значения");
                double a = Convert.ToDouble(textBox2.Text);
                if (a < 0)
                    throw new Exception("Значение меньше нуля");
                textBox1.Text = Convert.ToString(a * 1.61);
            } 
            catch (Exception ex)
            {
                textBox1.Text = "Exception: \"" + ex.Message + "\"";
            }
        }
    }
}
