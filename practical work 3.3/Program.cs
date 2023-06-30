using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_work_3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Наименьший элемент в последовательности

            Console.WriteLine("Введите длину последовательности");
            int a = int.Parse(Console.ReadLine());
            int value = int.MaxValue;
            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine($"Введите число под номером: {i}");
                int b = int.Parse(Console.ReadLine());
                if (b < value) value = b;

            }
            Console.Write($"Наименьшее число {value}");
            Console.ReadKey();
        }
    }
}
