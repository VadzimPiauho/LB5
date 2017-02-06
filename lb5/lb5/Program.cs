using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lb5
{
    public delegate void colorDelegate();

    partial class Program
    {
        [DllImport("msvcrt")]
        static extern int _getch();
        static void Main(string[] args)
        {

            Figure figure = new Figure();
            bool go_on = true;
            colorDelegate color = setColor;
            
            try
            {
                while (go_on)
                {
                    Console.Clear();
                    Console.WriteLine("Выберите фигуры для отображения в консоли");
                    Console.WriteLine("*******************************");
                    Console.WriteLine("1 - прямоугольник");
                    Console.WriteLine("2 - ромб");
                    Console.WriteLine("3 - треугольник");
                    Console.WriteLine("4 - трапеция");
                    Console.WriteLine("5 - многоугольник");
                    Console.WriteLine("6 - отобразить выбранные фигуры");
                    Console.WriteLine("0 - Выход из программы");
                    Console.WriteLine("*******************************");

                    switch (_getch())
                    {
                        case '1':
                            figure.list.Add(new rectangle());
                            Console.WriteLine("Прямоугольник добавлен");
                            Thread.Sleep(1000);
                            break;
                        case '2':
                            figure.list.Add(new diamond());
                            Console.WriteLine("ромб добавлен");
                            Thread.Sleep(1000);
                            break;
                        case '3':
                            figure.list.Add(new triangle());
                            Console.WriteLine("треугольник добавлен");
                            Thread.Sleep(1000);
                            break;
                        case '4':
                            figure.list.Add(new trapezoid());
                            Console.WriteLine("трапеция добавлена");
                            Thread.Sleep(1000);
                            break;
                        case '5':
                            figure.list.Add(new polygon());
                            Console.WriteLine("многоугольник добавлен");
                            Thread.Sleep(1000);
                            break;
                        case '6':
                            figure.printAll(color);
                            //_getch();
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
            catch (Exception)
            {
                Console.WriteLine("Неверный ввод Завершение программы");
                Environment.Exit(0);
            }
        }
    }
}
