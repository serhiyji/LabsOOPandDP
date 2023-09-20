using System;

namespace Lab4
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
        public float x { get; protected set;}
        public float y { get; protected set;}
        public float X { get; protected set;}
        public float Y { get; protected set;}
        #endregion

        public PlaneTransformation(
            float a11_ = 0, float a12_ = 0, float a13_ = 0, 
            float a21_ = 0, float a22_ = 0, float a23_ = 0, 
            float x_ = 0, float y_ = 0)
        {
            this.a11 = a11_;
            this.a12 = a12_;
            this.a13 = a13_;
            this.a21 = a21_;
            this.a22 = a22_;
            this.a23 = a23_;
            this.x = x_;
            this.y = y_;
            X = 0;
            Y = 0;
        }
        public PlaneTransformation() : this(0, 0, 0, 0, 0, 0, 0, 0) { }
        public virtual void Calculate()
        {
            this.X = a11 * x + a12 * y + a13;
            this.Y = a21 * x + a22 * y + a23;
        }
        public (float x, float y) GetResult()
        {
            return (this.X, this.Y);
        }
    }
    public class SpaceTransformation : PlaneTransformation
    {
        #region Properties
        public float a14 { get; protected set;}
        public float a24 { get; protected set;}
        public float a31 { get; protected set;}
        public float a32 { get; protected set;}
        public float a33 { get; protected set;}
        public float a34 { get; protected set;}
        public float z { get; protected set;}
        public float Z { get; protected set;}
        #endregion

        public SpaceTransformation(
            float a11_ = 0, float a12_ = 0, float a13_ = 0, float a14_ = 0,
            float a21_ = 0, float a22_ = 0, float a23_ = 0, float a24_ = 0,
            float a31_ = 0, float a32_ = 0, float a33_ = 0, float a34_ = 0,
            float x_ = 0, float y_ = 0, float z_ = 0
            ) : base(a11_, a12_, a13_, a21_, a22_, a23_, x_, y_)
        {
            this.a14 = a14_;
            this.a24 = a24_;
            this.a31 = a31_;
            this.a32 = a32_;
            this.a33 = a33_;
            this.a34 = a34_;
            this.z = z_;
            this.Z = 0;
        }
        public SpaceTransformation() : this(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) { }
        public override void Calculate()
        {
            this.X = a11 * x + a12 * y + a13 * z + a14;
            this.Y = a21 * x + a22 * y + a23 * z + a24;
            this.Z = a31 * x + a32 * y + a33 * z + a34;
        }
        public (float x, float y, float z) GetResult()
        {
            return (this.X, this.Y, this.Z);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PlaneTransformation");
            PlaneTransformation planeTransformation = new PlaneTransformation(1, 2, 3, 4, 5, 6, 7, 8);
            planeTransformation.Calculate();
            Console.WriteLine(planeTransformation.GetResult());

            Console.WriteLine("SpaceTransformation");
            SpaceTransformation spaceTransformation = new SpaceTransformation(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);
            spaceTransformation.Calculate();
            Console.WriteLine(spaceTransformation.GetResult());

        }
    }
}
