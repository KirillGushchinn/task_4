//Программа определяющая максимальное число 
using System;

public class Zadanie4
{
    public static void Main(string[] args)
    {
        int a,b,c,max;
        Console.Write ("Введите число a=");
        a=int.Parse(Console.ReadLine());
        
        Console.Write ("Введите число b=");
        b=int.Parse(Console.ReadLine());
        
        Console.Write ("Введите число c=");
        c=int.Parse(Console.ReadLine());
        
        if (a>b) {
            max=a;
        }
        else {
            max=b;
        }
        if (max<c) {
            max=c;
        }
        
         Console.WriteLine ($"max={max}");
    }
}