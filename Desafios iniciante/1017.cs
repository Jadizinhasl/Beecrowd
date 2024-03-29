using System;

class URI1017
{
    static void Main(string[] args)
    {
        double g, h, v;

        h = double.Parse(Console.ReadLine());
        v = double.Parse(Console.ReadLine());

        g =  h * v / 12;

        Console.WriteLine("{0:F3}", g);
    }
}