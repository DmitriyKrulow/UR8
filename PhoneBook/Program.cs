using System;
using System.Collections.Generic;

namespace PhoneBook
{
    internal class Program
    {
        /// <summary>
        /// Ввод значений пользователем
        /// </summary>
        /// <param name="phoneBook">Справочник</param>
        /// <returns></returns>
        private static Dictionary<string, string> UserInputValues(Dictionary<string, string> phoneBook)
        {
            string phoneNumber;
            while (true)
            {
                Console.WriteLine("Введите номер или пустую строку для выхода:");
                phoneNumber = Console.ReadLine();
                if (phoneNumber == "")
                {
                    Console.WriteLine("Ввод окончен:");
                    break;
                }
                else
                {
                    Console.WriteLine("Введите ФИО аббонента :");
                    phoneBook.Add(phoneNumber, Console.ReadLine());
                }
            }
            return phoneBook;
        }
        /// <summary>
        /// Поиск аббонента по номеру телефону
        /// </summary>
        /// <param name="phoneBook">Список телефонов</param>
        /// <returns></returns>
        private static Dictionary<string, string> SubscriberSearch(Dictionary<string, string> phoneBook)
        {
            Console.WriteLine("Введите номер");
            string phoneNumber;
            string value = "";
            phoneNumber = Console.ReadLine();
            if (phoneBook.TryGetValue(phoneNumber, out value))
            {
                Console.WriteLine("Номер телефона \"{0}\", у абонента {1}.", phoneNumber, value);
            }
            else
            {
                Console.WriteLine("Номер телефона \"{0}\" не найден в сохраненных", phoneNumber);
            }
            return phoneBook;
        }
        static void Main(string[] args)
        {
            Dictionary<string, string> PhoneBook = new Dictionary<string, string>();
            PhoneBook = UserInputValues(PhoneBook);
            SubscriberSearch(PhoneBook);
        }
    }
}
