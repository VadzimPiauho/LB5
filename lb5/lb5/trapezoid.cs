using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb5
{
    class trapezoid : baseclass
    {
        public trapezoid( ) : base("trapezoid")
        {
        }

        public override void print()
        {
            int i, j, N = 11;
            int center = N / 2;
            for (i = 0; i <= N / 2; i++)
            {
                for (j = 0; j <= N / 2; j++)
                {
                    if (i <= center)
                    {
                        // Верхняя половина ромба
                        if (j >= center - i && j <= center + i)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
