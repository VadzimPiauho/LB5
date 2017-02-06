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
            Console.Write($"    *****\n   *******\n  *********\n ***********\n*************\n");
        }
    }
}
