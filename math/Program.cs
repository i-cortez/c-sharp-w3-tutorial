using System;

namespace math
{
   class Program
   {
      static void Main(string[] args)
      {
         // The C# Math class has many methods that allows you to perform mathematical tasks on numbers

         int x = 5, y = 10;

         // the Math.Max(x, y) method can be used to find the highest value of x and y
         Console.WriteLine(Math.Max(x, y));

         // the Math.Min(x, y) method can be used to find the lowest value of x and y
         Console.WriteLine(Math.Min(x, y));

         x = 64;

         // the Math.Sqrt(x) method returns the square root of x
         Console.WriteLine(Math.Sqrt(64));

         x = -5;

         // the Math.Abs(x) method returns the absolute (positive) value of x
         Console.WriteLine(Math.Abs(x));

         // Math.Round() rounds a number to the nearest whole number
         float a = 9.99F;
         Console.WriteLine(Math.Round(a));
      }
   }
}

