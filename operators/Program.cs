using System;

namespace operators
{
   class Program
   {
      static void Main(string[] args)
      {
         // operators are used to perform operations on variables and values
         // use the + operator to add together two values
         int x = 100 + 50;
         Console.WriteLine(x);

         // + can also be used to add together a variable and a value, or a variable and another variable
         int sum1 = 100 + 50;
         int sum2 = sum1 + 250;
         int sum3 = sum2 + sum2;
         Console.WriteLine(sum1);
         Console.WriteLine(sum2);
         Console.WriteLine(sum3);

         /*
          * Arithmetic operators are used to perform common mathematical operations:
          * (+) Addition
          * (-) Subtraction
          * (*) Multiplication
          * (/) Division
          * (%) Modulus
          * (++) Increment
          * (--) Decrement
          */

         /*
          * Assignment operators are used to assign values to variables.
          * A list of all asignment operators:
          * (=)
          * (+=)
          * (-=)
          * (*=)
          * (/=)
          * (%=)
          * (&=)
          * (|=)
          * (^=)
          * (>>=)
          * (<<=)
          */

         int y = 10;
         y += 5;
         Console.WriteLine(y);

         /* Comparison operators are used to compare two values:
          * (==) Equal to
          * (!=) Not equal
          * (>) Greater than
          * (<) Less than
          * (>=) Greater than or equal to
          * (<=) Less than or equal to
          */

         Console.WriteLine(x == y);

         /*
          * Logical operators are used to determine the logic between variables or values
          * (&&) Logical and
          * (||) Logical or
          * (!) Logical not
          */

         Console.WriteLine(x < 5 && y < 10);
      }
   }
}

