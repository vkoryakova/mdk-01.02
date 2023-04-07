/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        double a = 3.14;
        double b = (a * (Math.PI)) / 180;
        Console.WriteLine(Math.Sin(b));
        double x =Convert.ToDouble(Console.ReadLine());
        double y =(x*(Math.PI))/180;
        Console.WriteLine(Math.Sin(y));
        
    }
}