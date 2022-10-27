//1.Haz un programa en c# que calcule la solución de la ecuación de 
//  primer grado. ax+b=0. Hay que controlar cuando la a es cero.

//Declarar variables.
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int A, B, X;

        //Pedir datos
        Console.WriteLine("Escribe el valor para A");
        A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe el valor para B");
        B = Convert.ToInt32(Console.ReadLine());

        //Cálculo

        if (A == 0)
        {
            Console.WriteLine("ERROR");
        }
        else
        {
            X = (X = -B / A);

            Console.WriteLine($"El resultado de la ecuacion es   + {X}");
        }
    }
}