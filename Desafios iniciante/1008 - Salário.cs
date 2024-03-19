using System;

class URI1008
{
    static void Main(string[] args)
    {
        int n, h;
        double s, salario;

        n = int.Parse(Console.ReadLine());
        h = int.Parse(Console.ReadLine());
        s = double.Parse(Console.ReadLine());

        salario = s * h;

        Console.WriteLine($"NUMBER = {n}");
        Console.WriteLine("SALARY = U$ {0:F2}", salario);
    }
}