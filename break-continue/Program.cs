using System;

namespace break_continue
{
   class Program
   {
      static void Main(string[] args)
      {
         // the break statement can be used to jump out of a loop
         for(int j = 0; j < 10; ++j)
         {
            if (j == 4) break;
            Console.WriteLine(j);
         }

         // the continue statement breaks one iteration (in the loop), if a specified condition occurs and continues with the next iteration in the loop
         for(int j = 0; j < 10; ++j)
         {
            if (j == 4) continue;
            Console.WriteLine(j);
         }

         // can also use break and continue in while loops
         int i = 0;
         while(i < 10)
         {
            Console.WriteLine(i);
            ++i;
            if (i == 4) break;
         }

         i = 0;
         while (i < 10)
         {
            if(i == 4)
            {
               ++i;
               continue;
            }
            Console.WriteLine(i);
            ++i;
         }
      }
   }
}

