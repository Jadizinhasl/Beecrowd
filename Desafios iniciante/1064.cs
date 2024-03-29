using System;

class URI1064
{
    static void Main(string[] args)
    {
        double sp = 0;
        double p = 0;

        for (int c = 1; c <= 6; c++)
        {
            double n = double.Parse(Console.ReadLine());

            if (n > 0)
            {
                sp += n;
                p++;
            }
        }

        double media = sp / p;
        Console.WriteLine($"{p} valores positivos");
        Console.WriteLine(Math.Round(media, 1));
    }
}