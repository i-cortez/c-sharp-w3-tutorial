using System;

namespace switch_statements
{
   class Program
   {
      static void Main(string[] args)
      {
         // the switch statement selects one of many code blocks to be executed
         int day = 4;
         switch(day)
         {
            case 1:
               Console.WriteLine("Monday");
               break;
            case 2:
               Console.WriteLine("Tuesday");
               break;
            case 3:
               Console.WriteLine("Wednesday");
               break;
            case 4:
               Console.WriteLine("Thursday");
               break;
            case 5:
               Console.WriteLine("Friday");
               break;
            case 6:
               Console.WriteLine("Saturday");
               break;
            case 7:
               Console.WriteLine("Sunday");
               break;
            default:
               Console.WriteLine("Something is very wrong");
               break;
               // the default keyword is optional and specifies some code to run if there is no case match
         }
      }
   }
}

