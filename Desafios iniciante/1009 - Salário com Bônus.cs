using System;

class URI1009
{
    static void Main(string[] args)
    {
        string n;
        double sf, vd, total;

        n = Console.ReadLine();
        sf = double.Parse(Console.ReadLine());
        vd = double.Parse(Console.ReadLine());

        total = (vd*0.15) + sf;

        Console.WriteLine("TOTAL = R$ {0:F2}", total);
    }
}