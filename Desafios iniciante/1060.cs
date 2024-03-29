using System;

class Program
{
    static void Main(string[] args)
    {
        int positivos = 0;

        for (int contador = 1; contador <= 6; contador++)
        {
            double n = double.Parse(Console.ReadLine());

            if (n > 0)
            {
                positivos++;
            }
        }
        Console.WriteLine($"{positivos} valores positivos");
    }
}