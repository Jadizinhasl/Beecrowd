using System;

class URI1002
{
    static void Main(string[] args)
    {
        double n = 3.14159;

        double raio = double.Parse(Console.ReadLine());

        double area = n * (raio * raio);
        Console.WriteLine("A={0:F4}", area);
    }
}