using System;

class URI1020
{
    static void Main(string[] args)
    {
        int id = int.Parse(Console.ReadLine());

        int a = id / 365;
        int r = id % 365;
        int m = r / 30;
        int d = r % 30;

        Console.WriteLine($"{a} ano(s)");
        Console.WriteLine($"{m} mes(es)");
        Console.WriteLine($"{d} dia(s)");
    }
}