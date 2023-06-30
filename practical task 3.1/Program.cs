using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_task_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Программа подсчёта суммы карт в игре «21»

            Console.WriteLine("Приветствую. Сколько карт у вас на руках?");
            byte numberОfСards = byte.Parse(Console.ReadLine());
            byte sum = 0;
            for (int i = 0; i < numberОfСards; i++)
            {
               Console.WriteLine("Введите номинал карты!");
               string a = Console.ReadLine();
                switch (a)
                {
                    case "J":
                    case "Q":
                    case "K":
                    case "T":
                        sum += 10;
                        break;
                    default:
                        byte b = Convert.ToByte(a);
                        sum += b; 
                        break;
                }
                
            }
            Console.WriteLine($"Сумма ваших карт: {sum}") ;
            Console.ReadKey();
        }
    }
}
