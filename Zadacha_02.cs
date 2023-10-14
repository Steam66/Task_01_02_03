using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_01_02_03
{
    internal class Zadacha_02
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            string? number = Console.ReadLine();

            void CheckingNumber(string number)
            {
                if (number[0] == number[3] || number[1] == number[2])
                {
                    Console.WriteLine($"Ваше число: {number} - палиндром.");
                }
                else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
            }

            if (number!.Length < 5)
            {
                CheckingNumber(number);
            }
            else Console.WriteLine($"Введи правильное число");
        }
    }
}
