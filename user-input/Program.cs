using System;

namespace user_input
{
   class Program
   {
      static void Main(string[] args)
      {
         // use Console.ReadLine() to get user input
         // type your username and press enter
         Console.WriteLine("Enter username: ");

         // create a string variable and get user input from the keyboard
         string userName = Console.ReadLine();

         // output the obtained value
         Console.WriteLine("Username is: " + userName);

         // you cannot implicitly convert types with Console.ReadLine()
         Console.WriteLine("Enter your age: ");
         int age = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Your age is: " + age);
      }
   }
}
