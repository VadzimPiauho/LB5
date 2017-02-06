using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace lb5
{
   partial class Program
    {                   

        public static void setColor()
        {
            bool go_on = true;
            while (go_on)
            {
                //Console.Clear();
                Console.WriteLine("Выберите цвет фигуры и нажмите нарисовать");
                Console.WriteLine("**************************************************************");
                Console.ForegroundColor=ConsoleColor.Blue;
                Console.WriteLine("1 - цвет Blue");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("2 - цвет Cyan");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("3 - цвет Red");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("4 - цвет Yellow");
                Console.WriteLine("**************************************************************");

                switch (_getch())
                {
                    case '1':
                        Console.ForegroundColor = ConsoleColor.Blue;
                        //_getch();
                        go_on = false;
                        break;
                    case '2':
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        //_getch();
                        go_on = false;
                        break;
                    case '3':
                        Console.ForegroundColor = ConsoleColor.Red;
                        //_getch();
                        go_on = false;
                        break;
                    case '4':
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        //_getch();
                        go_on = false;
                        break;
                    default:
                        Console.WriteLine("Неверный выбор");
                        Thread.Sleep(1000);
                        break;
                }
            }

        }

    }   
}
