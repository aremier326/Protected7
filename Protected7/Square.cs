using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected7
{
    public interface IMeasurable
    {
        double Perimeter();
        double Area();
    }

    public interface ICircumcircleIncircle
    {
        double R { get; }
        double SmallR { get; }
    }

    public class Square : DemoPoint, IMeasurable, IComparable<Square>
    {         
        public Square(int x, int y) : base(x, y){}

        public double Perimeter() => X * 2 + Y * 2;
        public double Area() => Math.Pow(X + Y, 2);

        int IComparable<Square>.CompareTo(Square someSquare)
        {
            return Perimeter().CompareTo(someSquare.Perimeter());
        }

        //static void Main()
        //{
        //    Square[] squares = new Square[5]
        //    {
        //        new Square(5, 10),
        //        new Square(4, 12),
        //        new Square(20, 5),
        //        new Square(7, 2),
        //        new Square(3, 3)
        //    };

        //    Console.WriteLine("Unsorted array:\n");
        //    foreach (var element in squares)
        //    {
        //        Console.WriteLine($"The perimeter is {element.Perimeter()}");
        //    }

        //    Array.Sort<Square>(squares);

        //    Console.WriteLine("\nNew sorted array:\n");
        //    foreach (var element in squares)
        //    {
        //        Console.WriteLine($"The perimeter is {element.Perimeter()}");
        //    }

        //    Console.ReadLine();
        //}
    }    
}
