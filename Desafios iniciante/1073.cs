using System;

class URI1073
{
    static void Main(string[] args)
    {
        int numero = int.Parse(Console.ReadLine());

        for (int contador = 1; contador <= numero; contador++)
        {
            if (contador % 2 == 0)
            {
                Console.Write($"{contador}^2 = {Math.Pow(contador, 2)}");
            }
        }
    }
}