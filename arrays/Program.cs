using System;
using System.Linq;

namespace arrays
{
   class Program
   {
      static void Main(string[] args)
      {
         // arrays are used to store multiple values in a single variable
         // to declare an array, define the variable type with square brackets
         string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

         // access an array element by referring to the index number
         Console.WriteLine(cars[0]);

         // to change the value of a specific element, refer to the index number
         cars[0] = "Opel";
         Console.WriteLine(cars[0]);

         // to find out how many elements an array has, use the Length property
         Console.WriteLine(cars.Length);

         // output all elements in the array
         for(int i = 0; i < cars.Length; ++i)
         {
            Console.WriteLine(cars[i]);
         }

         // the foreach loop is used exclusively to loop through elements in an array
         foreach(string j in cars)
         {
            Console.WriteLine(j);
         }

         // Sort() sorts an array alphabetically or in ascending order
         Array.Sort(cars);
         foreach(string j in cars)
         {
            Console.WriteLine(j);
         }

         int[] myNums = { 5, 1, 8, 9 };
         Array.Sort(myNums);
         foreach(int j in myNums)
         {
            Console.WriteLine(j);
         }

         // other useful array methods, such as Min(), Max(), and Sum(), can be found in the System.Linq namespace
         Console.WriteLine(myNums.Max()); // returns largest value
         Console.WriteLine(myNums.Min()); // returns smallest value
         Console.WriteLine(myNums.Sum()); // returns the sum of elements

         // there are different ways to create an array
         string[] cities = new string[3];
         cities[0] = "Boston";
         cities[1] = "San Francisco";
         cities[2] = "Austin";
         string[] bikes = new string[3] { "Santa Cruz", "Ibis", "Specialized" };
         string[] brands = new string[] { "Adidas", "Under Armour", "Nike" };

         foreach(string j in cities)
         {
            Console.WriteLine(j);
         }

         foreach(string j in bikes)
         {
            Console.WriteLine(j);
         }

         foreach(string j in brands)
         {
            Console.WriteLine(j);
         }
      }
   }
}

