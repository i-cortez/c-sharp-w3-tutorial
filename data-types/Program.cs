using System;

namespace data_types
{
   class Program
   {
      static void Main(string[] args)
      {
         int myNum = 5; // integer
         double myDoubleNum = 5.99D; // floating point number
         char myChar = 'D'; // character
         bool myBool = true; // boolean
         string myText = "Hello"; // string
         Console.WriteLine(myNum);
         Console.WriteLine(myDoubleNum);
         Console.WriteLine(myChar);
         Console.WriteLine(myBool);
         Console.WriteLine(myText);

         /*
          * A data type specifies the size and type of variable values
          * The most common data types are:
          * int 4 bytes
          * long 8 bytes
          * float 4 bytes
          * double 8 bytes
          * bool 1 bit
          * char 2 bytes
          * string 2 bytes per character
          */

         /*
          * Number types are divided into two groups:
          * Integer types stores whole numbers, posotive or negative, without decimals
          * Floating point types represents numbers with a fractional part, containing one or more decimals
          */

         int myIntNum = 100000;
         Console.WriteLine(myIntNum);

         // you should end a long value with an L
         long myLongNum = 150000000L;
         Console.WriteLine(myLongNum);

         // you should end a float value with an F
         float myFloatNum = 5.75F;
         Console.WriteLine(myFloatNum);

         double myDouble = 19.99;
         Console.WriteLine(myDouble);

         /*
          * The precision of a floating point value indicates how many digits the value can have
          * after the decimal point. The precision of float is only six of seven decimal digits, while
          * double variables have a precision of about 15 digits. It is safer to use double for most
          * calculations
          */

         // a floating point number can also be a scientific number with an "e" to indicate the power of 10
         float f1 = 35e3F;
         double d1 = 12e4D;
         Console.WriteLine(f1);
         Console.WriteLine(d1);

         // a boolean data type can only take the values true or false
         bool isCSharpFun = true;
         bool isFishTasty = false;
         Console.WriteLine(isCSharpFun);
         Console.WriteLine(isFishTasty);

         // the char data type is used to store a single character
         // the character must be surronded by single quotes
         char myGrade = 'A';
         Console.WriteLine(myGrade);

         // the string data type is used to store a sequence of characters
         // string values must be surrounded by double quotes
         string greeting = "Hello World";
         Console.WriteLine(greeting);
      }
   }
}

