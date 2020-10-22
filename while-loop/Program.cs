using System;

namespace while_loop
{
   class Program
   {
      static void Main(string[] args)
      {
         // loops can execute a block of code as long as a specified condition is reached
         // the while loop loops through a block of code as long as a specified condition is true
         int i = 0;
         while(i < 5)
         {
            Console.WriteLine(i);
            ++i; // do not forget to increase the variable used in the condition
         }

         // the do while loop will execute the code block once, before checking if the condition is true, then it will repeat the loop as long as the condition is true
         i = 0;
         do
         {
            Console.WriteLine(i);
            ++i;
         }
         while (i < 5);
      }
   }
}

