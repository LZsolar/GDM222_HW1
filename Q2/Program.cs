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
        int i=0;
        if(X1==X2&&Y2==Y1){i=n+1;}
        else if(X2>=X1&&Y2>=Y1){n+=0; i=1;} //Q1
        else if(X2>=X1&&Y2<=Y1){n+=3;i=4;} //Q2
        else if(X2<=X1&&Y2<=Y1){n+=2;i=3;} //Q3
        else if(X2<=X1&&Y2>=Y1){n+=1;i=2;} //Q4

        for(i=i;i<=n;i++){
            double tempX = Math.Abs(X2-X1),tempY = Math.Abs(Y2-Y1);
            if(i%4==1){
                X2 = X1-tempY;
                Y2 = Y1+tempX;
            } //Q1 -> Q4
            else if(i%4==2){
                X2 = X1-tempY;
                Y2 = Y1-tempX;
            } //Q4 -> Q3
            else if(i%4==3){
                X2 = X1+tempY;
                Y2 = Y1-tempX;
            } //Q3 -> Q2
            else{
                X2 = X1+tempY;
                Y2 = Y1+tempX;
            } //Q2 -> Q1
             
            X1 = (X1+X2)/2;
            Y1 = (Y1+Y2)/2;
        }
        Console.WriteLine(X1);
        Console.WriteLine(Y1);
        Console.WriteLine(X2);
        Console.WriteLine(Y2);
    }
    
}