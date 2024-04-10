using System;

class URI1035
{
    public static void Main(string[] args)
    {
        string[] valores = Console.ReadLine().Split(' ');
        int A = Convert.ToInt32(valores[0]); int B = Convert.ToInt32(valores[1]); int C = Convert.ToInt32(valores[2]); int D = Convert.ToInt32(valores[3]);

        if(B > C && D > A && D+C > A+B && C > 0 && D > 0 && A % 2 == 0)
        {
            Console.WriteLine("Valores aceitos");
        }
        else
        {
            Console.WriteLine("Valores nao aceitos");
        }
    }
}