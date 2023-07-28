using System;

namespace Lab3Q1
{
    class Point3D
    {
        public int X;
        public int Y;
        public int Z;

        public Point3D() : this(1, 2, 3)
        {
            //X = 1;
            //Y = 2;
            //Z = 3;
        }
        public Point3D(int x) : this(x, 2, 3)
        {
            //X = x;
            //Y = 2;
            //Z = 3;
        }
        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public void Display()
        {
            Console.WriteLine($"X Coordinate:{X}, Y Coordinate:{Y}, Z Coordinate:{Z}");
        }

        public static void Display(Point3D[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].Display();
            }
        }

        public void ChangeCoordinates(int newX, int newY, int newZ)
        {
            X = newX;
            Y = newY;
            Z = newZ;
        }

        public override string ToString()
        {
            return $"X Coordinate:{X}, Y Coordinate:{Y}, Z Coordinate:{Z}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Point3D point)
            {
                if (this.X == point.X && this.Y == point.Y && this.Z == point.Z)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Point3D p1 = new Point3D(1);
            Point3D p2 = new Point3D(1, 2, 3);
            Console.Write("p1:  ");
            p1.Display();
            Console.Write("p2:  ");
            p2.Display();


            Console.WriteLine($"\nusing == operator: ");
            if (p1 == p2)
                Console.WriteLine("p1 and p2 are references to the same object");
            else
                Console.WriteLine("p1 and p2 are references to different objects");


            Console.WriteLine($"\nusing Equals overriding function: ");
            if (p1.Equals(p2))
                Console.WriteLine($"p1 and p2 are equal");
            else
                Console.WriteLine($"p1 and p2 are not equal");

            p1.ChangeCoordinates(4, 5, 6);
            Console.WriteLine("\n\nAfter changing p1:");
            Console.Write("p1:  ");
            p1.Display();
            Console.Write("p2:  ");
            p2.Display();
            p2 = p1;
            Console.WriteLine("\n\nAfter writing p2 = p1 ");
            Console.Write("p1:  ");
            p1.Display();
            Console.Write("p2:  ");
            p2.Display();

            Console.WriteLine($"\nusing == operator: ");
            if (p1 == p2)
                Console.WriteLine("p1 and p2 are references to the same object");
            else
                Console.WriteLine("p1 and p2 are references to different objects");


            Point3D[] points = new Point3D[3] { new Point3D(7, 8, 9), new Point3D(10, 11, 12), new Point3D(13, 14, 15) };
            Console.WriteLine($"\nDisplaying an array of points: ");
            Point3D.Display(points);

            Console.WriteLine($"\nTesting the ToString overriding function on points[3]: ");
            Console.WriteLine(points[2].ToString());
        }
    }
}