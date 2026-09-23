using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> words =
            new Dictionary<string, int>();
        while (true)
        {
            Console.Write("Введите слово: ");
            string word = Console.ReadLine();
            if (word == "выход")
            {
                break;
            }
            if (words.ContainsKey(word))
            {
                words[word] = words[word] + 1;
            }
            else
            {
                words.Add(word, 1);
            }
            foreach (var item in words)
            {
                Console.WriteLine(
                    item.Key + ": " + item.Value);
            }
        }
    }
}