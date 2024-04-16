using System;

class URI1044
{
    static void Main(string[] args)
    {
        string[] valores = Console.ReadLine().Split(' ');
        int a = Convert.ToInt32(valores[0]); int b = Convert.ToInt32(valores[1]);

        if(a % b == 0 || b % a == 0)
        {
            Console.WriteLine("Sao Multiplos");
        }
        else
        {
            Console.WriteLine("Nao sao Multiplos");
        }
    }
}