using System;

class URI1066
{
    public static void Main(string[] args)
    {
        int pares = 0;
        int impares = 0;
        int positivos = 0;
        int negativos = 0;

        for(int i = 1; i <= 5; i++)
        {
            int n = int.Parse(Console.ReadLine());

            if(n > 0)
            {
                positivos++;
            }
            if(n < 0)
            {
                negativos++;
            }
            if(n % 2 == 0)
            {
                pares++;
            }
            if(n % 2 != 0)
            {
                impares++;
            }
        }
        Console.WriteLine($"{pares} valor(es) par(es)");
        Console.WriteLine($"{impares} valor(es) impar(es)");
        Console.WriteLine($"{positivos} valor(es) positivo(s)");
        Console.WriteLine($"{negativos} valor(es) negativo(s)");
    }
}