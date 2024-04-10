using System;

class URI1013
{
    public static void Main(string[] args)
    {
        string[] valores = Console.ReadLine().Split(' ');
        int v1 =Convert.ToInt32(valores[0]); int v2 =Convert.ToInt32(valores[1]); int v3 =Convert.ToInt32(valores[2]);

        if(v1 > v2 && v1 > v3)
        {
            Console.WriteLine($"{v1} eh o maior");
        }
        else  if(v2 > v3)
        {
            Console.WriteLine($"{v2} eh o maior");
        }
        else
        {
            Console.WriteLine($"{v3} eh o maior");
        }
    }
}