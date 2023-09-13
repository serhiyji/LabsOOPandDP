using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a, b, c;
            try
            {
                a = float.Parse(this.textA.Text);
                b = float.Parse(this.textC.Text);
                c = float.Parse(this.textB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Введено невірні дані");
                return;
            }
            if (a + b < c || b + c < a || a + c < b)
            {
                MessageBox.Show("Трикутник з такими сторонами не можливий");
                return;
            }
            Triangle triangle = new Triangle(a, b, c);
            this.textResult.Text = triangle.GetArea().ToString();
        }
    }
    public class Triangle
    {
        public float A { get; set; }
        public float B { get; set; }
        public float C { get; set; }
        public Triangle(float a = 1, float b = 1, float c = 1)
        {
            A = a;
            B = b;
            C = c;
        }
        public double GetArea()
        {
            float p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
