using System;
using System.Collections.Generic;

namespace CheckingRepetitions
{
    internal class Program
    {
        /// <summary>
        /// Дабавление чисел и проверка на повторы
        /// </summary>
        /// <param name="verifiableNumbers"></param>
        /// <returns></returns>
        private static HashSet<int> CheckingRepetitions(HashSet<int> verifiableNumbers)
        {
            string userNumber;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введите число для дабавления\n" +
                    "Что бы выйти просто введите пустую строку");
                userNumber = Console.ReadLine();
                if (userNumber == "") { break; }
                else
                {
                    int.TryParse(userNumber, out int rezult);
                    if (verifiableNumbers.Add(rezult))
                    {
                        Console.WriteLine("Число добавлено.");
                        Console.ReadKey();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Число уже вводилось ранее.");
                        Console.ReadKey();
                        continue;
                    }
                }
            }
            return verifiableNumbers;
        }
        /// <summary>
        /// Отображение дабавленных чисел
        /// </summary>
        /// <param name="verifiableNumbers"></param>
        private static void PrintHashSet(HashSet<int> verifiableNumbers)
        {
            Console.Write("{");
            foreach (int i in verifiableNumbers)
            {
                Console.Write(" {0}", i);
            }
            Console.WriteLine(" }");
        }
        static void Main(string[] args)
        {
            HashSet<int> VerifiableNumbers = new HashSet<int>();
            CheckingRepetitions(VerifiableNumbers);
            PrintHashSet(VerifiableNumbers);
        }
    }
}
