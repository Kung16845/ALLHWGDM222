using System;
class Program
{
    public static void Main(string[] args)
    {
        double Cx = double.Parse(Console.ReadLine());
        double Cy = double.Parse(Console.ReadLine());
        double Px = double.Parse(Console.ReadLine());
        double Py = double.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        double r = Math.Sqrt(Math.Pow(Px-Cx,2)+Math.Pow(Py-Cy,2));
        double a = Math.PI/4;
        for (int i = 1 ; i <= n;i++)
        {             
            a += Math.PI/2; 
            Px = r*Math.Cos(a)/Math.Pow(2,i-1) + Cx;
            Py = r*Math.Sin(a)/Math.Pow(2,i-1) + Cy;
            Cx = r*Math.Cos(a)/Math.Pow(2,i) + Cx;
            Cy = r*Math.Sin(a)/Math.Pow(2,i) + Cy;         
        }
        Console.WriteLine(Cx);
        Console.WriteLine(Cy);
        Console.WriteLine(Px);
        Console.WriteLine(Py);
    }
}
