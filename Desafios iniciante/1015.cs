using System;

class URI1015
{
    public static void Main(string[] args)
    {
        string[] linha1 = Console.ReadLine().Split(' ');
        double x1 = Convert.ToDouble(linha1[0]); double y1 = Convert.ToDouble(linha1[1]);

        string[] linha2 = Console.ReadLine().Split(' ');
        double x2 = Convert.ToDouble(linha2[0]); double y2 = Convert.ToDouble(linha2[1]);

        double d = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

        Console.WriteLine("{0:0.0000}",d);
    }
}