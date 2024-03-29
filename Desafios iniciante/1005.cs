using System;

class URI1005
{
    static void Main(string[] args)
    {
        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());

        double MEDIA = ((A*3.5) + (B*7.5)) / 11;

        Console.WriteLine("MEDIA = {0:F5}", MEDIA);
    }
}