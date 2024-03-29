using System;

class URI1078
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        for (int contador = 1; contador <= 10; contador++)
        {
            Console.WriteLine($"{contador} x {N} = {contador*N}");
        }
    }
}