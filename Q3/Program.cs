using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        double n = double.Parse(Console.ReadLine());
        Console.WriteLine(f(n));
    }

    public static double f(double n){
        if(n>-1&&n<=0){return Math.Sqrt(1-(n*n));}
        if(n>0&&n<=1){return -Math.Sqrt(1-(n*n));}
        if(n<=-1){return f(n+2);}
       return f(n-2);
    }

}