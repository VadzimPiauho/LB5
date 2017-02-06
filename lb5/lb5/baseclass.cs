using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb5
{
   abstract class baseclass
    {
        public string name { get; set; }       

        public baseclass(string name)
        {
            this.name = name;
        }
        public abstract void print();
        public virtual void printAll(colorDelegate color)
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

    }
}
