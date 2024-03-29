using System;

class Program
{
    static void Main(string[] args)
    {
        int pares = 0;

        for (int contador = 1; contador <= 5; contador++)
        {
            double n = double.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                pares++;
            }
        }
        Console.WriteLine($"{pares} valores pares");
    }
}