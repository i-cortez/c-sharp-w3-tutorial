using System;

namespace type_casting
{
   class Program
   {
      static void Main(string[] args)
      {
         /*
          * Type casting is when you assign a value of one data type to another type
          * In C#, there are two types of casting:
          * Implicit Casting (automatically) - converting a smaller type to a larger type size
          * Explicit Casting (manually) - converting a larger type to a smaller size type
          */

         // implicit casting is done automatically when passing a smaller size type to a larger size type
         int myInt = 9;
         double myDouble = myInt; // automatic casting
         Console.WriteLine(myInt);
         Console.WriteLine(myDouble);

         // explicit casting must be done manually by placing the type in parentheses in front of the value
         double d1 = 9.78;
         int i1 = (int)d1; // manual casting
         Console.WriteLine(d1);
         Console.WriteLine(i1);

         // it is also possible to convert data types explicitly by using built-in methods
         int i2 = 10;
         double d2 = 5.25;
         bool myBool = true;
         Console.WriteLine(Convert.ToString(i2)); // convert int to string
         Console.WriteLine(Convert.ToDouble(i2)); // convert int to double
         Console.WriteLine(Convert.ToInt32(d2)); // convert double to int
         Console.WriteLine(Convert.ToString(myBool)); // convert bool to string
      }
   }
}
