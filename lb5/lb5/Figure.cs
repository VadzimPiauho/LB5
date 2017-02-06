using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lb5
{
    class Figure : baseclass
    {
        public List<baseclass> list { get; set; }

        public Figure( ) : base("Выбранные фигуры")
        {
            list = new List<baseclass>();
        }

        public override void printAll(colorDelegate color)
        {
            Console.Clear();
            if (list.Count== 0)
            {
                Console.WriteLine("Вы не добавили фигуры для отображения. Нажмите любую клавишу");
                Thread.Sleep(2000);
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"Выберите цвет для {list[i].name}");
                color();
                //ConsoleColor color = ConsoleColor.Green;
                //Console.ForegroundColor = color; 
                Console.WriteLine();
                list[i].print();
                Console.WriteLine();
                Console.ResetColor();
                if (i == list.Count-1)
                {
                    Console.WriteLine("Фигуры отображены. Нажмите любую клавишу");
                }
            }
        }

        public override void print()
        {
            throw new NotImplementedException();
        }
    }
}
