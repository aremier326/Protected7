using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected7
{
    class DemoShape : DemoPoint, IDemo
    {
        protected int z;
        public DemoShape(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }

        public new void Show()
        {
            Console.WriteLine($"Point on Square: ({x}, {y}, {z})");
        }

        public new double Dlina()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }

        public new int this[int i]
        {
            get
            {
                if (i == 0) return x;
                else if (i == 1) return y;
                else if (i == 2) return z;
                else throw new Exception("Out of index!");
            }
            set
            {
                if (i == 0) x = value;
                else if (i == 1) y = value;
                else if (i == 2) z = value;
                else throw new Exception("Out of index!");
            }
        }
    }
}
