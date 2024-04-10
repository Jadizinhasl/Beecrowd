using System;

class URI1012
{
    public static void Main(string[] args)
    {
        string[] valores = Console.ReadLine().Split(' ');
        double A = Convert.ToDouble(valores[0]); double B = Convert.ToDouble(valores[1]); double C = Convert.ToDouble(valores[2]);

        double triangulo = (A*C) / 2;
        double circulo = 3.14159*Math.Pow(C, 2);
        double trapezio = (A+B)*C / 2;
        double quadrado = Math.Pow(B, 2);
        double retangulo = A*B;

        Console.WriteLine("TRIANGULO: {0:0.000}", triangulo);
        Console.WriteLine("CIRCULO: {0:0.000}", circulo);
        Console.WriteLine("TRAPEZIO: {0:0.000}", trapezio);
        Console.WriteLine("QUADRADO: {0:0.000}", quadrado);
        Console.WriteLine("RETANGULO: {0:0.000}", retangulo);
    }
}