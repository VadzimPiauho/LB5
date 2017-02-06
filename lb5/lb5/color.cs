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
        

        public static void setColor(ref bool go_on)
        {
            while (go_on)
            {
                Console.Clear();
                Console.WriteLine("Выберите цвет фигуры");
                Console.WriteLine("**************************************************************");
                Console.WriteLine("1 - получение объема памяти");
                Console.WriteLine("2 - копирование данных (файлов/папок) на устройство");
                Console.WriteLine("3 - получение информации о свободном объеме памяти на устройстве");
                Console.WriteLine("4 - получение общей/полной информации об устройстве");
                Console.WriteLine("0 - Выход из программы");
                Console.WriteLine("**************************************************************");

                switch (_getch())
                {
                    case '1':
                      
                        _getch();
                        break;
                    case '2':
                       
                        _getch();
                        break;
                    case '3':
                      
                        _getch();
                        break;
                    case '4':
                        
                        _getch();
                        break;
                    case '5':

                        _getch();
                        break;
                    case '0':
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
