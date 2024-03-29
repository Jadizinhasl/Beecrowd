using System;

class URI1019
{
    static void Main(string[] args)
    {
        int seg, hr, r, m, s; 

        seg = int.Parse(Console.ReadLine());

        hr = seg / 3600;
        r = seg % 3600;
        m = r / 60;
        s = r % 60;

        Console.WriteLine($"{hr}:{m}:{s}");
    }
}