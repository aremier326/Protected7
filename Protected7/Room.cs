using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected7
{
    // Partial Program class.
    partial class Program
    {
        static void Main()
        {
            IRoom[] rooms = new IRoom[3]
            {
                new ClassRoom(10, 20, 14),
                new MyRoom(4, 10, 7),
                new ClassRoom(11, 15, 14)
            };

            Console.WriteLine("Unsorted collection of rooms:\n");
            foreach (var room in rooms)
            {
                Console.WriteLine($"Amount of windows: {room.AmountOfWindows}");
                Console.WriteLine($"Here is room square: {room.RoomSquare()}");
            }

            //Sorting with the IComparable interface.
            Array.Sort<IRoom>(rooms);

            // Sorting with the IComparer interface.
            //Array.Sort<IRoom>(rooms, new AmountOfWindowsComparer());

            Console.WriteLine("Sorted collection of rooms:\n");
            foreach (var room in rooms)
            {
                Console.WriteLine($"Amount of windows: {room.AmountOfWindows}");
                Console.WriteLine($"Here is room square: {room.RoomSquare()}");
            }

            Console.ReadLine();
        }
    }

    // Class room class. Inherits class 'Square' and interface 'IRoom'.
    public class ClassRoom : Square, IRoom
    {
        public ClassRoom(int amountOfWindows, int length, int width): base(length, width)
        {
            AmountOfWindows = amountOfWindows;
        }

        public int AmountOfWindows { get; set; }

        public int RoomSquare() => (int)Area();

        public int CompareTo(IRoom someRoom)
        {
            return this.RoomSquare().CompareTo(someRoom.RoomSquare());
        }

    }

    // My room class. Inherits class 'Square' and interface 'IRoom'.
    public class MyRoom : Square, IRoom
    {
        public MyRoom(int amountOfWindows, int length, int width) : base(length, width)
        {
            AmountOfWindows = amountOfWindows;
        }

        public int AmountOfWindows { get; set; }

        public int RoomSquare() => (int)Area();

        public int CompareTo(IRoom someRoom)
        {
            return this.RoomSquare().CompareTo(someRoom.RoomSquare());
        }
    }
}
