using System;

class URI1010
{
    static void Main(string[] args)
    {
        string[] entrada = Console.ReadLine().Split(' ');
        int n1 = Convert.ToInt32(entrada[0]); int n2 = Convert.ToInt32(entrada[1]); double n3 = Convert.ToDouble(entrada[2]);

        string[] entrada2 = Console.ReadLine().Split(' ');
        int p1 = Convert.ToInt32(entrada2[0]); int p2 = Convert.ToInt32(entrada2[1]); double p3 = Convert.ToDouble(entrada2[2]);

        double valor = (n2*n3) + (p2*p3);

        Console.WriteLine("VALOR A PAGAR: R$ {0:00.00}", valor);
    }
}