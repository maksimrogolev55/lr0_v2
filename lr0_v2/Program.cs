using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr0_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 2.3:
            // Добавил комментарий
            // Задаём переменные через консоль
            Console.Write("x = ");
            float x = Convert.ToSingle(Console.ReadLine());
            Console.Write("y = ");
            float y = Convert.ToSingle(Console.ReadLine());
            // Задаём промежуточные переменные:
            float x1;
            float y1;
            // Задаём условие:
            if (x > y)
            {
                y1 = (x + y) / 2;
                x1 = 2 * x * y;
            }
            else
            {
                x1 = (x + y) / 2;
                y1 = 2 * x * y;
            }
            // Приравниваем переменные промежуточным:
            x = x1;
            y = y1;
            // Выводим результат в консоль:
            Console.WriteLine("x = " + x + "; " + "b = " + y);
            Console.Read();
        }
    }
}