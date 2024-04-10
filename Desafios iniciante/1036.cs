using System;

class URI1036
{
    public static void Main(string[] args)
    {
        string[] raizes = Console.ReadLine().Split(' ');
        double a=Convert.ToDouble(raizes[0]); double b=Convert.ToDouble(raizes[1]); double c=Convert.ToDouble(raizes[2]);

        double delta = b*b - 4 * a * c;

        if (a == 0)
        {
	        Console.WriteLine("Impossivel calcular");
	    }
	    else
        {
            if (delta > 0)
            {
			    double x1 = (-b + Math.Pow(delta,0.5))/(2*a);
			    double x2 = (-b - Math.Pow(delta,0.5))/(2*a);
			    Console.WriteLine("R1 = {0:F5}", x1);
			    Console.WriteLine("R2 = {0:F5}", x2);
		    }
		    else
            {
                Console.WriteLine("Impossivel calcular");
		    }
        }
    }
}