using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected7
{
    // Interface which has property and abstract method. Also inherits from IComparable interface.
    public interface IRoom : IComparable<IRoom>
    {
        int AmountOfWindows { get; set; }
        int RoomSquare();
    }
}
