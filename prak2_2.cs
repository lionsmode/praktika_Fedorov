using System;
class Program
{
    static void Main()
    {
        Console.Write("количество студентов:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Количество предметов: ");
        int m = int.Parse(Console.ReadLine());
        int[,] a = new int[n,m];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("студент" + (i + 1));
            for(int j = 0; j < m; j++)
            {
                Console.Write("Введите оценку:");
                a[i, j] = int.Parse(Console.ReadLine());
            }
        }
        for (int i = 0; i < n; i++)
        {
            int sum = 0;
            for(int j = 0; j < m; j++)
            {
                sum = sum + a[i, j];
            }
            double sred  = (double) sum / m;
            Console.WriteLine("Средняя оценка студента" + (i + 1) + ":" + sred );
        }
    }
}