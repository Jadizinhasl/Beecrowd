using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int l = 1; l <= n; l++)
        {
            Console.WriteLine("{0} {1} {2}", l, Math.Pow(l, 2), Math.Pow(l, 3));
        }
    }
}