using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected7
{
    class AmountOfWindowsComparer : IComparer<IRoom>
    {
        int IComparer<IRoom>.Compare(IRoom firstRoom, IRoom secondRoom)
        {
            if (firstRoom.AmountOfWindows > secondRoom.AmountOfWindows) return 1;
            if (firstRoom.AmountOfWindows < secondRoom.AmountOfWindows) return -1;
            else return 0;
        }
    }
}
