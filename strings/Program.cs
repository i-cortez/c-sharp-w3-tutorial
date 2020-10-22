using System;

namespace strings
{
   class Program
   {
      static void Main(string[] args)
      {
         // Strings are used for storing text

         string greeting = "Hello";
         Console.WriteLine(greeting);

         // a string in C# is actually an object, which contains properties and methods that can perform certain operations on strings
         // the length of a string can be found with the Length property
         string txt = "abcdefghijklmnopqrstuvwxyz";
         Console.WriteLine("txt length: " + txt.Length);

         txt = "Hello World";

         // ToUpper() and ToLower() return a copy of the string converted to uppercase or lowercase
         Console.WriteLine(txt.ToUpper());
         Console.WriteLine(txt.ToLower());

         // the + operator can be used between strings to combine them
         // this is called concatenation
         string firstName = "John";
         string lastName = "Doe";
         string name = firstName + " " + lastName;
         Console.WriteLine(name);

         // can also use string.Concat() to concatenate two strings
         name = string.Concat(firstName, lastName);
         Console.WriteLine(name);

         // string interpolation substitutes values of variables into placeholders in a string
         // you do not have to worry about spaces, like with concatenation
         name = $"My full name is: {firstName} {lastName}";
         Console.WriteLine(name);

         // you can access the characters in a string by referring to its index number inside square brackets []
         string myStr = "Hello";
         Console.WriteLine(myStr[0]);

         // you can also find the index position of a specific character in a string using IndexOf()
         Console.WriteLine(myStr.IndexOf("l"));

         // Substring() extracts the characters from a string, starting from the specified character index and returns a new string
         name = "John Doe";
         int charPos = name.IndexOf("D");
         lastName = name.Substring(charPos);
         Console.WriteLine(lastName);

         /* The backslash (\) escape character turns special characters into string characters
          * (\') Single quote
          * (\") Double quote
          * (\\) Backslash
          */

         txt = "We are the so-called \"Vikings\" from the north.";
         Console.WriteLine(txt);
      }
   }
}

