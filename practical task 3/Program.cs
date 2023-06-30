using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Приложение по определению чётного или нечётного числа

            Console.WriteLine("Введите целое число");
            int integer = int.Parse(Console.ReadLine());
            if (integer % 2 == 0) Console.WriteLine("Вы ввели четное число!");
            else Console.WriteLine("Вы ввели не четное число!");
            Console.ReadKey();
            

        }
    }
}
