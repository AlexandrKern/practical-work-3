using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_task_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Проверка простого числа
            Console.WriteLine("Введите целое число");
            int N = int.Parse(Console.ReadLine());
            bool primeNumber = false;
            int i = 2;
            while (i<=N-1) 
            { 
                
                if (N%i==0) 
                {
                    primeNumber = true;
                    break;
                }
                i++;
            }
            if (primeNumber)
            {

                Console.WriteLine("Число не простое!");

            }
            else
            {
                Console.WriteLine("Число простое!");
            }
            Console.ReadKey();
        }
    }
}
