using System;

class URI1071
{
    static void Main(string[] args)
    {
        int soma = 0;
		int n1 = int.Parse(Console.ReadLine());
		int n2 = int.Parse(Console.ReadLine());

		if (n1 < n2) 
        {
			for (int i = n1 + 1; i < n2; i++) 
            {
				if (i % 2 != 0) {
					soma += i;
				}
			}
		} 
        else 
        {
			for (int i = n2 + 1; i < n1; i++) 
            {
				if (i % 2 != 0) {
					soma += i;
				}
			}
		}
		Console.WriteLine(soma);
    }
}