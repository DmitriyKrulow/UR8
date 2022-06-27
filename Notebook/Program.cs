using System;
using System.IO;
using System.Xml.Linq;

namespace Notebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FileName = @"Person.xml";
            Console.WriteLine("Введите ФИО");
            XElement Contacts = new XElement("Person", new XAttribute("name", Console.ReadLine()));
            XElement Adress = new XElement("Address");
            Console.WriteLine("Введите улицу");
            XElement Street = new XElement("Street", Console.ReadLine());
            Console.WriteLine("Введите номер дома");
            XElement HouseNumber = new XElement("HouseNumber", Console.ReadLine());
            Console.WriteLine("Введите номер квартиры");
            XElement FlatNumber = new XElement("FlatNumber", Console.ReadLine());
            Adress.Add(Street, HouseNumber, FlatNumber);
            XElement Phones = new XElement("Phones");
            Console.WriteLine("Введите номер мобильного телефона");
            XElement MobilePhone = new XElement("MobilePhone", Console.ReadLine());
            Console.WriteLine("Введите номер домашнего телефона");
            XElement FlatPhone = new XElement("FlatPhone", Console.ReadLine());
            Phones.Add(MobilePhone, FlatPhone);
            Contacts.Add(Adress, Phones);
            File.WriteAllText(FileName, Contacts.ToString());
            Console.WriteLine(Contacts);
            Console.ReadLine();
        }
    }
}
