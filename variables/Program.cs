using System;

namespace variables
{
   class Program
   {
      static void Main(string[] args)
      {
         // to create a variable, you must specify the type and assign it a value
         string firstName = "John";
         Console.WriteLine(firstName);

         // you can add the const keyword if you don't want to overwrite existing values
         // this makes the variable read-only
         // a const field requires a value to be provided
         int myNum = 15;
         myNum = 20;
         Console.WriteLine(myNum);

         // to combine both text and a variable, use the + character
         Console.WriteLine("Hello " + firstName);

         // you can also use the + character to add a variable to another variable
         string lastName = "Doe";
         string fullName = firstName + lastName;
         Console.WriteLine(fullName);

         // for numeric values, the + character works as a mathematical operator
         // to declare more than one variable of the same type, use a comma-separated list
         int x = 5, y = 6;
         Console.WriteLine(x + y);

         /*
          * The general rules for constructing names for variables (unique identifiers):
          * Names can contain letters, digits and the underscore character
          * Names must begin with a letter
          * Names should start with a lowercase letter and it cannot contain whitespace
          * Names are case sensitive
          * Reserved words cannot be used as names
          */
      }
   }
}

