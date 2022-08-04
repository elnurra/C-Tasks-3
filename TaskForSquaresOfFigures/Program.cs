using System;

namespace TaskForSquaresOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value for variable a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a value for variable b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a value for variable c: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a value for variable r(radius): ");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Overload 1: The area of a circle: ");
            Console.WriteLine(Area(r));
            Console.WriteLine("Overload 2: The area of a rectangle ");
            Console.WriteLine(Area(a,b));
            Console.WriteLine("Overload 3: The area of a rectangular parallelepiped: ");
            Console.WriteLine(Area(a, b, c));
            Console.WriteLine("Overload 4: The area of a circle of an inscribed triangle: ");
            Console.WriteLine(Area(a, b, c, r));
        }
       static int Area(int r) 
        {
            int pi = 3;
            int S = pi * r * r;
            return S;
        }
        static int Area(int a, int b)
        {

            int S = a * b;
            return S;
        }
        static int Area(int a, int b,int c)
        {

            int S = 2*((a*b)+(a*c)+(b*c));
            return S;
        }
        static int Area(int a, int b, int c, int r)
        {
            int halfper = ((a + b + c) / 2);
            int S = halfper * r;
            return S;
        }
    }
}
