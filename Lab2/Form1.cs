using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x;
            if (float.TryParse(this.textX.Text, out x))
            {
                Formula formula = new Formula();
                this.textResult.Text = formula.Get(x).ToString();
            }
            else
            {
                MessageBox.Show("Дані введені невірно");
            }
        }
    }
    public class Formula
    {
        private float a;
        private float b;
        public Formula()
        {
            a = 1;
            b = 2;
        }
        public double Get(float x)
        {
            return Math.Sin(a * x + b);
        }
    }
}
