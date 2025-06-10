using csharp_targv24.Madu;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_targv24.Madu
{
    /* Создаёт горизонтальную линию из символов от xLeft до xRight на высоте y
    Каждая точка линии добавляется в список pList */
    class HorizontalLine : Figure  // наследник класса Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}