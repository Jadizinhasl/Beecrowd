using System;

class URI1074
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int c = 1; c <= n; c++)
        {
            int x = int.Parse(Console.ReadLine());

            if (x > 0 && x % 2 == 0)
            {
                Console.WriteLine($"EVEN POSITIVE");
            }
            if (x > 0 && x % 2 != 0)
            {
                Console.WriteLine($"ODD POSITIVE");
            }
             if (x < 0 && x % 2 == 0)
            {
                Console.WriteLine($"EVEN NEGATIVE");
            }
            if (x < 0 && x % 2 != 0)
            {
                Console.WriteLine($"ODD NEGATIVE");
            }
            if (x == 0)
            {
                Console.WriteLine($"NULL");
            }
        }
    }
}