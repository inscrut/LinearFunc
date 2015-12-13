using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            linfunc liner = new linfunc(0, 0, 1, 1);

            if(liner.check(2,2)) System.Console.Write("Belong");
            else System.Console.Write("Not Belong");
        }

        class linfunc
        {
            public float k { get { return kb; } }
            public float b { get { return bb; } }

            float kb, bb;

            public linfunc(int x1, int y1, int x2, int y2)
            {
                kb = (float)(y1 - y2) / (float)(x1 - x2);
                bb = (float)(y1 - kb * x1);
            }

            public bool check(int x, int y) //Belonging to the point function
            {
                // y = kx + b
                if (y == kb * x + bb) return true;
                else return false;
            }
        }
    }
}
