using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Input your number : ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(funtionMath(num));
    }
    static double sum = 0;
    static double funtionMath(int n)
    {
        if(Math.Pow(n,2) > 4)
        {
            sum = sum + 1+funtionMath(n-(4*Math.Abs(n)/n));
        }
        else 
        {
            sum = sum+2;
        }
        return sum;
    }
}