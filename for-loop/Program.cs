using System;

namespace for_loop
{
   class Program
   {
      static void Main(string[] args)
      {
         // when you know exactly how many times you want to loop through a block of code, use the for loop
         for(int i = 0; i < 5; ++i)
         {
            Console.WriteLine(i);
         }

         // print the even values between 0 and 10
         for (int i = 0; i <= 10; i += 2)
         {
            Console.WriteLine(i);
         }

         // the foreach loop is used exclusively to loop through elements in an array
         string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
         foreach(string i in cars)
         {
            Console.WriteLine(i);
         }
      }
   }
}

