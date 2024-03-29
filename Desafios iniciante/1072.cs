using System;

class URI1072
{
    static void Main(string[] args)
    {
        int iN = 0;
        int ouT = 0;
        int n = int.Parse(Console.ReadLine());

        for (int c = 1; c <= n; c++)
        {
            int x = int.Parse(Console.ReadLine());

            if (x >= 10 && x <= 20)
            {
                iN++;
            }
            else 
            {
                ouT++;
            }
        }
        Console.WriteLine($"{iN} in");
        Console.WriteLine($"{ouT} out");
    }
}