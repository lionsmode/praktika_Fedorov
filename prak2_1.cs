using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        int sum = 0;
        for(int i = 0; i < n; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
            sum += a[i];
        }
        double sr = (double) sum / n;
        for(int i = n - 1; i >= 0; i--)
        Console.Write(a[i] + " ");
        int b =a[0];
        for(int i = 1; i < n; i++)
        if(Math.Abs(a[i] - sr) < Math.Abs(b - sr))
        b = a[i];
        Console.WriteLine("\nБлижайшее:" + b);
    }
}