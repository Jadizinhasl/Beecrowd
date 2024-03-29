using System;

class URI1014
{
    static void Main(string[] args)
    {
        double medio, l;
        int c;

        c = int.Parse(Console.ReadLine());
        l = double.Parse(Console.ReadLine());

        medio = c / l;

        Console.WriteLine("{0:F3} km/l", medio);
    }
}