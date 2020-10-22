using System;

namespace if_else
{
   class Program
   {
      static void Main(string[] args)
      {

         /* C# has the following conditional statements:
          * Use if to specify a block of code to be executed, if the condntion is true
          * Use else to specify a block of code to be executed, if the condition is false
          * Use else if to specify a new condition to test, if the first condition is false
          * Use switch to specify many alternative blocks of code to be executed
          */

         // the if statement specifies a block of C# code to be executed if a condition is true
         int x = 20, y = 18;
         if(x < y)
         {
            Console.WriteLine("x is greater than y");
         }

         // the else statement specifies a block of code to be executed if the condition is false
         int time = 20;
         if(time < 18)
         {
            Console.WriteLine("Good day.");
         }
         else
         {
            Console.WriteLine("Good evening.");
         }

         // use the else if statement to specify a new condition if the first condition is false
         time = 22;
         if(time < 10)
         {
            Console.WriteLine("Good morning.");
         }
         else if(time < 20)
         {
            Console.WriteLine("Good day.");
         }
         else
         {
            Console.WriteLine("Good evening.");
         }

         // the ternary operator can be used to replace multiple lines of code with a single line
         time = 20;
         string result = (time < 18) ? "Good day." : "Good evening.";
         Console.WriteLine(result);
      }
   }
}

