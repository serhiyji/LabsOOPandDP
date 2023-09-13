using System;
using System.Runtime.CompilerServices;

namespace Lab3
{
    public class Formula
    {
        private float A;
        private float B;
        private float X;
        public Formula(float a = 1, float b = 1, float x = 1)
        {
            this.A = a;
            this.B = b;
            this.X = x;
            Console.WriteLine($"Ctor : {A}, {B}, {X}");
        }
        ~Formula()
        {
            Console.WriteLine($"Dtor : {A}, {B}, {X}");
        }
        public double Calculate()
        {
            return Math.Sin(A * X + B);
        }
    }
    internal class Program
    {
        private static void Task1()
        {
            Console.Write("Count >> ");
            int count = int.Parse(Console.ReadLine());
            Formula[] formulas = new Formula[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Enter parametrs {i + 1}");

                Console.Write("a >> ");
                float a = float.Parse(Console.ReadLine());
                Console.Write("b >> ");
                float b = float.Parse(Console.ReadLine());
                Console.Write("x >> ");
                float x = float.Parse(Console.ReadLine());

                formulas[i] = new Formula(a, b, x);
            }
            Console.WriteLine("--------");
            for (int i = 0; i < formulas.Length; i++)
            {
                Console.WriteLine($"{i + 1} : {formulas[i].Calculate()}");
            }
        }
        static void Main(string[] args)
        {
            Task1();
            GC.Collect();
            Console.ReadLine();
        }
    }
}
