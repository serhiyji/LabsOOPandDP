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
            draw_graph();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            draw_graph();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            draw_graph();
        }
        private void draw_graph()
        {
            graph.Clear(BackColor);

            double start = 2, stop = 7, step = 0.05;

            int width = ClientSize.Width - 50;
            int height = ClientSize.Height - 50;

            double scaleX = width / (stop - start);
            double scaleY = height / (CalculateY(stop) - CalculateY(start));

            Color blue = Color.Blue;
            float penWidth = 2;
            Pen pen = new Pen(blue, penWidth);

            double xPrev = 0;
            double yPrev = CalculateY(start);

            for (double x = start; x <= stop; x += step)
            {
                double y = CalculateY(x);
                int x1 = (int)((xPrev - start) * scaleX) + 50;
                int y1 = height - (int)((yPrev - CalculateY(start)) * scaleY) - 50;
                int x2 = (int)((x - start) * scaleX) + 50;
                int y2 = height - (int)((y - CalculateY(start)) * scaleY) - 50;

                graph.DrawLine(pen, x1, y1, x2, y2);

                xPrev = x;
                yPrev = y;
            }

            Pen axisPen = new Pen(Color.Black, 1);
            int xOffset = 50;
            int yOffset = 50;
            int arrowSize = 5;
            int rightOffset = 50;

            graph.DrawLine(axisPen, xOffset, height - yOffset, width + xOffset - rightOffset, height - yOffset);
            graph.DrawLine(axisPen, xOffset, height - yOffset, xOffset, yOffset);

            //x
            graph.DrawLine(axisPen, width + xOffset - rightOffset - arrowSize, height - yOffset - arrowSize, width + xOffset - rightOffset, height - yOffset);
            graph.DrawLine(axisPen, width + xOffset - rightOffset - arrowSize, height - yOffset + arrowSize, width + xOffset - rightOffset, height - yOffset);

            //y
            graph.DrawLine(axisPen, xOffset - arrowSize, yOffset + arrowSize, xOffset, yOffset);
            graph.DrawLine(axisPen, xOffset + arrowSize, yOffset + arrowSize, xOffset, yOffset);

            //x
            for (int i = 1; i <= 5; i++)
            {
                int xPos = xOffset + i * (width - 2 * xOffset - rightOffset) / 5;
                graph.DrawLine(axisPen, xPos, height - yOffset - 3, xPos, height - yOffset + 3);
                string label = (start + i * step).ToString("F1");
                graph.DrawString(label, Font, Brushes.Black, xPos - 10, height - yOffset + 5);
            }

            for (int i = 1; i <= 5; i++)
            {
                int yPos = height - yOffset - i * (height - 2 * yOffset) / 5;
                graph.DrawLine(axisPen, xOffset - 3, yPos, xOffset + 3, yPos);
                if (i != 5)
                {
                    string label = (CalculateY(start) + i * (CalculateY(stop) - CalculateY(start)) / 5).ToString("F2");
                    graph.DrawString(label, Font, Brushes.Black, xOffset - 30, yPos - 10);
                }
            }

            graph.DrawString("X", Font, Brushes.Black, width + xOffset - rightOffset + 10, height - yOffset + 5);
            graph.DrawString("Y", Font, Brushes.Black, xOffset - 20, yOffset - 20);
        }

        private double CalculateY(double x)
        {
            return 1f / (Math.Pow(Math.Cos(2 * x), 3) - Math.Sqrt(Math.Pow(x, 2) - 4));
        }
    }
}
