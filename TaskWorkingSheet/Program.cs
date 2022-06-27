using System;
using System.Collections.Generic;

namespace TaskWorkingSheet
{

    internal class Program
    {
        /// <summary>
        /// Заполнение случайными числами
        /// </summary>
        /// <param name="intList">Список для заполнения</param>
        /// <param name="numberRandomElements">количество элементов</param>
        private static List<int> FillList(List<int> intList, int numberRandomElements, int minvValue, int maxValue)
        {
            Random randomIntNumber = new Random();
            for (int i = 0; i < numberRandomElements; i++)
            {
                intList.Add(randomIntNumber.Next(minvValue, maxValue + 1));
            }
            return intList;
        }
        /// <summary>
        /// Вывод в консоль колекции чисел.
        /// </summary>
        /// <param name="intList">Выводимая коллекция</param>
        private static void PrinFulltList(List<int> intList)
        {
            foreach (var item in intList)
            {
                Console.Write($"{item} ");
            }
        }
        /// <summary>
        /// Удаление чисел из диапазона
        /// </summary>
        /// <param name="intList">Коллекция чисел</param>
        /// <param name="minvValue">Минимальная граница диапазона</param>
        /// <param name="maxValue">Максимальная граница диапазона</param>
        /// <returns></returns>
        private static List<int> RemovingNumbersRange(List<int> intList, int minvValue, int maxValue)
        {
            for (int i = 0; i < intList.Count; i++)
            {
                if ((intList[i] > minvValue) && (intList[i] < maxValue))
                {
                    //Console.Write($" {intList[i]} <<<\n");
                    intList.RemoveAt(i);
                    i--;//Так как произошло смещение списка на -1 по индексу снова делаем итерацию
                }
            }
            return intList;
        }
        static void Main(string[] args)
        {
            int NumberRandomElements = 100;
            List<int> IntegersList = new List<int>();
            IntegersList = FillList(IntegersList, NumberRandomElements, 0, 100);
            Console.WriteLine("Созданный список");
            PrinFulltList(IntegersList);
            Console.ReadLine();
            Console.WriteLine("Удаляем.");
            IntegersList = RemovingNumbersRange(IntegersList, 25, 50);
            Console.WriteLine("\nОтредактированный список.");
            PrinFulltList(IntegersList);
            Console.ReadLine();
        }
    }
}
