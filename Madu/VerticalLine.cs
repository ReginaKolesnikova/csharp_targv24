using csharp_targv24.Madu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_targv24.Madu
{
    /* Создаёт вертикальную линию из символов от yUp до yDown на позиции x
     Каждая точка линии добавляется в список pList */
    class VerticalLine : Figure  // наследник класса Figure
    {
        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}