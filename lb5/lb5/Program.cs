using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb5
{
    class Program
    {
        static void Main(string[] args)
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




        }
    }
}
