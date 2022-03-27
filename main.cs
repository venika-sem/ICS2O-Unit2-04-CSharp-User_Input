// Created by: Venika Sem
// Created on: Mar 2022
//
// This program does calculations

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function calculates the area of a triangle
        int baseOfTriangle;
        int heightOfTriangle;

        Console.WriteLine("This program finds the area of a triangle.");
        Console.WriteLine("");

        Console.Write("Enter the base (cm): ");
        baseOfTriangle = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the height (cm): ");
        heightOfTriangle = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine("The area is: " + (baseOfTriangle * heightOfTriangle) / 2 + " " + "cm².");

        Console.WriteLine("\nDone.");
    }
}