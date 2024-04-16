using System;

class URI1080
{
    public static void Main(string[] args)
    {
        int maior = 0;
        int posicao = 0;

        for(int i = 1; i <= 100; i++)
        {
            int n = int.Parse(Console.ReadLine());

            if(n > maior)
            {
                maior = n;
                posicao = i;
            }
        }

        Console.WriteLine(maior);
        Console.WriteLine(posicao);
    }
}