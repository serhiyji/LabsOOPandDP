using System;

namespace Lab3
{
    public class Formula
    {
        public static long Max = 0;
        private float A;
        private float B;
        private float X;
        private decimal[] list;
        public Formula(float a = 1, float b = 1, float x = 1)
        {
            this.A = a;
            this.B = b;
            this.X = x;
            list = new decimal[1000];

        }
        ~Formula()
        {
            Max = Math.Max(Max, GC.GetTotalMemory(true));
        }
        public double Calculate()
        {
            return Math.Sin(A * X + B);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            long d1 = GC.GetTotalMemory(true);
            Console.WriteLine($"Перед виконанням програми {d1}");
            Console.Write("Count >> ");
            int count = int.Parse(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                float a = i;
                float b = random.Next(0, int.MaxValue);
                float x = random.Next(0, int.MaxValue);
                Formula formula = new Formula(a, b, x);
            }
            long d2 = GC.GetTotalMemory(true);
            Console.WriteLine($"Після виконанням програми {d2}");
            Console.WriteLine($"Максимальна кількість памятізайнята програмою {Formula.Max}");
            Console.ReadLine();
        }
    }
}
