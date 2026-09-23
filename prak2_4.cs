using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> phone =
            new Dictionary<string, string>();
        while (true)
        {
            Console.WriteLine("1 - Добавить");
            Console.WriteLine("2 - Найти");
            Console.WriteLine("3 - Показать все");
            Console.WriteLine("4 - Выход");
            Console.Write("Выберите: ");
            string vib = Console.ReadLine();
            if (vib == "4")
            {
                break;
            }
            if (vib == "1")
            {
                Console.Write("Имя: ");
                string name = Console.ReadLine();
                Console.Write("Телефон: ");
                string number = Console.ReadLine();
                phone[name] = number;
                Console.WriteLine("Добавлено!");
            }
            if (vib == "2")
            {
                Console.Write("Введите имя: ");
                string name = Console.ReadLine();
                if (phone.ContainsKey(name))
                {
                    Console.WriteLine(phone[name]);
                }
                else
                {
                    Console.WriteLine("Не найдено");
                }
            }
            if (vib == "3")
            {
                foreach (var item in phone)
                {
                    Console.WriteLine(
                        item.Key + ": " + item.Value);
                }
            }
        }
    }
}