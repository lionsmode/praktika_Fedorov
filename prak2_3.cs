using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<int> a = new List<int>();
        while(true)
        {
            Console.Write("Введите число:");
            int x = int.Parse(Console.ReadLine());
            if (a.Contains(x))
            {
                break;
            }
            a.Add(x);
        }
        for(int i = 0; i < a.Count; i++)
        {
            Console.Write(a[i] + " ");
        }
    }
}