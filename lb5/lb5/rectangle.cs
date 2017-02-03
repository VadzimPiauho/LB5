using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb5
{
    class rectangle : baseclass
    {
        public rectangle() : base("rectangle")
        {
        }

        public override void print()
        {
            int lenght = 15, width = 5;
            for (int j = 0; j < width; j++)
            {
                for (int i = 0; i < lenght; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //int lenght = 10, width = 5;
            //for (int j = 0; j < width; j++)
            //{
            //    for (int i = 0; i < lenght; i++)
            //    {
            //        if (j == 0 || j == width - 1) Console.Write("*");
            //        else if (i == 0 || i == lenght - 1) Console.Write("*");
            //        else Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}


        }
    }
}
