using System;

class Program
{
    static void Main(string[] args)
    {
        double a, b, c, area, perimetro;

        string[] valor = Console.ReadLine().Split(' ');
        a = Convert.ToDouble(valor[0]); b = Convert.ToDouble(valor[1]); c = Convert.ToDouble(valor[2]);

        perimetro = a + b + c;
		area = (c * (a + b))/2;

        if(((b+c)>a) && ((a+b)>c) && ((a+c)>b))
        {
            Console.WriteLine("Perimetro = {0:F1}", perimetro);
        }
        else
        {
            Console.WriteLine("Area = {0:F1}", area);
        }
    }
}