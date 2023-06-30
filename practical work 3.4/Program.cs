using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_work_3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Игра «Угадай число»

            Console.Write("Введите максимальное целое число диапазона от 0 до ");
            int maxValue = int.Parse(Console.ReadLine());
            Random random = new Random();
            int a = random.Next(0,maxValue);
            Console.WriteLine("Угадай число! Если устал играть жми пробел.");
            while (true) 
            { 
                string q = Console.ReadLine();
                if (q == " ") 
                {
                    Console.WriteLine($"Загаданное число: {a}");
                    break;
                }
                else
                {
                    int value = Convert.ToInt32(q);
                    if (value > a) Console.WriteLine("Число больше загаданного!!!");
                    if (value < a) Console.WriteLine("Число меньше загаданного!!!");
                    if (value == a)
                    {
                        Console.WriteLine("Поздравляю вы угадали!!!");
                        break;
                    }
                }

            }
            Console.ReadKey();
        }
    }
}
