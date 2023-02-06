using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        double X1 = double.Parse(Console.ReadLine());
        double Y1 = double.Parse(Console.ReadLine());
        double X2 = double.Parse(Console.ReadLine());
        double Y2 = double.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        for(int i=1;i<=n;i++){
            if(i%4==1){X2 = X2-(2*Math.Abs(X2-X1));}
            else if(i%4==2){Y2 = Y2-(2*Math.Abs(Y2-Y1));}
            else if(i%4==3){X2 = X2+(2*Math.Abs(X2-X1));}
            else{Y2 = Y2+(2*Math.Abs(Y2-Y1));}
             
            X1 = (X1+X2)/2;
            Y1 = (Y1+Y2)/2;
        }
        Console.WriteLine(X1);
        Console.WriteLine(Y1);
        Console.WriteLine(X2);
        Console.WriteLine(Y2);
    }
    
}