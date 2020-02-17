using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ind
{   public class Program
    {  static public double Example(int a, int b)
        {   double r1 = (a + b) / 2;
            Console.WriteLine(r1.ToString());
            return r1;}
        static public double Example1(int a, int b)
        {   double r2 = Math.Sqrt(a * b);
            Console.WriteLine(r2.ToString());
            return r2;}
        static void Main(string[] args)
        {   int a, b;
            Console.WriteLine("Enter a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Example(a, b);
            Example1(a, b);}}}
