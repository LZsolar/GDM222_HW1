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
        f1(n,X1,Y1,X2,Y2);
    }
    static void f1(int n,double X1,double Y1,double X2,double Y2){
        if(n==0){return;}
        
        X2 = X2-(X2-X1)-(X2-X1);
        X1 = (X1-X2)/2;
        Y1 = (Y2-Y1)/2;
        Console.WriteLine(X1);
        Console.WriteLine(Y1);

        f2(n-1,X1,X2,Y1,Y2);
    }
    static void f2(int n,double X1,double Y1,double X2,double Y2){
        if(n==0){return;}
        
        X2 = X2- (X2-X1);
    }
    static void f3(int n,double X1,double Y1,double X2,double Y2){
        if(n==0){return;}
        
        X2 = X2- (X2-X1);
    }
    static void f4(int n,double X1,double Y1,double X2,double Y2){
        if(n==0){return;}
        
        X2 = X2- (X2-X1);
    }
    
}