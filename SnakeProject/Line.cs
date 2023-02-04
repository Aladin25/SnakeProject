using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProject
{
    internal class Line
    {
        public void HorizontalLine(int left,int top,char symbol,int lenght)
        {
            for (int i = left; i < lenght; i++)
            {
                //Console.SetCursorPosition(i,top);
                //Console.Write(symbol);
                Drow(i, top, symbol);
            }
        }
        public void VerticalLine(int left, int top, char symbol, int lenght)
        {
            for (int i = top; i < lenght; i++)
            {
                //Console.SetCursorPosition(left, i);
                //Console.Write(symbol);
                Drow(left, i, symbol);
            }
        }
        public void Drow(int left,int top ,char symbol)
        {
            Console.SetCursorPosition(left, top);
            Console.Write(symbol);
        }
    }
}
