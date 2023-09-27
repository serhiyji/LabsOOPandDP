using System;
using System.Collections.Generic;

namespace Lab5
{
    public class PlaneTransformation
    {
        #region Properties
        public float a11 { get; protected set; }
        public float a12 { get; protected set; }
        public float a13 { get; protected set; }
        public float a21 { get; protected set; }
        public float a22 { get; protected set; }
        public float a23 { get; protected set; }
        public float x { get; protected set; }
        public float y { get; protected set; }
        public float X { get; protected set; }
        public float Y { get; protected set; }
        #endregion

        public PlaneTransformation(
            float a11 = 0, float a12 = 0, float a13 = 0,
            float a21 = 0, float a22 = 0, float a23 = 0,
            float x = 0, float y = 0)
        {
            this.a11 = a11;
            this.a12 = a12;
            this.a13 = a13;
            this.a21 = a21;
            this.a23 = a23;
            this.a22 = a22;
            this.x = x;
            this.y = y;
            X = 0;
            Y = 0;
        }
        public PlaneTransformation() : this(1, 2, 3, 4, 5, 6, 7, 8) { }
        public virtual void Calculate()
        {
            this.X = a11 * x + a12 * y + a13;
            this.Y = a21 * x + a22 * y + a23;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine("Info");
            Console.WriteLine($"{a11} {a12} {a13}");
            Console.WriteLine($"{a21} {a22} {a23}");
            Console.WriteLine($"x = {x}, y = {y}");
        }
        public virtual List<float> GetResult()
        {
            return new List<float>() { this.X, this.Y };
        }
    }
    public class SpaceTransformation : PlaneTransformation
    {
        #region Properties
        public float a14 { get; protected set; }
        public float a24 { get; protected set; }
        public float a31 { get; protected set; }
        public float a32 { get; protected set; }
        public float a33 { get; protected set; }
        public float a34 { get; protected set; }
        public float z { get; protected set; }
        public float Z { get; protected set; }
        #endregion

        public SpaceTransformation(
            float a11 = 0, float a12 = 0, float a13 = 0, float a14 = 0,
            float a21 = 0, float a22 = 0, float a23 = 0, float a24 = 0,
            float a31 = 0, float a32 = 0, float a33 = 0, float a34 = 0,
            float x = 0, float y = 0, float z = 0
            ) : base(a11, a12, a13, a21, a22, a23, x, y)
        {
            this.a14 = a14;
            this.a24 = a24;
            this.a31 = a31;
            this.a32 = a32;
            this.a33 = a33;
            this.a34 = a34;
            this.z = z;
            this.Z = 0;
        }
        public SpaceTransformation() : this(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15) { }
        public override void Calculate()
        {
            this.X = a11 * x + a12 * y + a13 * z + a14;
            this.Y = a21 * x + a22 * y + a23 * z + a24;
            this.Z = a31 * x + a32 * y + a33 * z + a34;
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Info");
            Console.WriteLine($"{a11} {a12} {a13} {a14}");
            Console.WriteLine($"{a21} {a22} {a23} {a24}");
            Console.WriteLine($"{a31} {a32} {a33} {a34}");
            Console.WriteLine($"x = {x}, y = {y}, z = {z}");
        }
        public override List<float> GetResult()
        {
            return new List<float>() { this.X, this.Y, this.Z };
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int userSelect;
            PlaneTransformation baseobj = new PlaneTransformation();
            while (true)
            {
                Console.WriteLine("Enter '0' if you want to work with PlaneTransformation and '1' - with SpaceTransformation");
                userSelect = Convert.ToInt32(Console.ReadLine());
                if (userSelect == 0)
                {
                    baseobj = new PlaneTransformation();
                }
                else if (userSelect == 1)
                {
                    baseobj = new SpaceTransformation();
                }
                else
                {
                    return;
                }
                baseobj.PrintInfo();
                baseobj.Calculate();
                Console.WriteLine("Result calc : {0}" , string.Join(", ", baseobj.GetResult()));
            }
        }
    }
}
