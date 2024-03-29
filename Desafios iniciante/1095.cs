using System;

class URI1095
{
    static void Main(string[] args)
    {
        int r = 60;
        for (int c = 1; c < 40; c+= 3)
        {
            Console.WriteLine($"I={c} J={r}");
            r-= 5;
        }
    }
}