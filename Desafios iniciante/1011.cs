using System;

class URI1011
{
    static void Main(string[] args)
    {
        double pi = 3.14159;

        double n = double.Parse(Console.ReadLine());

        double r = Math.Pow(n, 3);
        double v = 4 / 3.0 * pi * r;

        Console.WriteLine("VOLUME = {0:F3}", v);
    }
}