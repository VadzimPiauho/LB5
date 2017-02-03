using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb5
{
    class diamond : baseclass
    {
        public diamond( ) : base("diamond")
        {
        }

        public override void print()
        {
            int i, j, N = 11;
            int center = N / 2;
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    if (i <= center)
                    {
                        // Верхняя половина ромба
                        if (j >= center - i && j <= center + i)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    else
                    {
                        // Нижняя половина ромба
                        if (j >= center + i - N + 1 && j <= center - i + N - 1)
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
