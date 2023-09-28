using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        Graphics graph;
        public Form1()
        {
            InitializeComponent();
            graph = CreateGraphics();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int X = 8;
            Color slateBlue = Color.FromName("SlateBlue");
            float width = 3;
            Pen pen = new Pen(slateBlue, width);
            float y, y2, x;
            float x2 = 2;
            while (x2 <= 7)
            {
                y2 = x2 * x2;
                x = x2;
                y = (float)(1f / (Math.Pow(Math.Cos(2 * x), 3) - Math.Sqrt(Math.Pow(x, 2) - 4)));
                graph.DrawLine(pen, x * X, y * X, x2 * X, y2 * X);
                x2 += 0.05f;
            }
        }
    }
}
