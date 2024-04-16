using System;

class URI1067
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for(int i = 1; i <= n; i++)
        {
            if(i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}