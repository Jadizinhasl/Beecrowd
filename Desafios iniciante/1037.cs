using System;

class URI1037
{
    static void Main(string[] args)
    {
        double v = double.Parse(Console.ReadLine());

        if (v >= 0 && v <= 25)
        {
            Console.WriteLine($"Intervalo [0,25]");
        }
        else if (v > 25 && v <= 50)
        {
            Console.WriteLine($"Intervalo (25,50]");
        }
        else if (v > 50 && v <= 75)
        {
            Console.WriteLine($"Intervalo (50,75]");
        }
        else if (v > 75 && v <= 100)
        {
            Console.WriteLine($"Intervalo (75,100]");
        }
        else
        {
            Console.WriteLine("Fora de intervalo");
        }
    }
}