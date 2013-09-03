using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateDemo00
{
   class Program
   {
      static void Main(string[] args)
      {
         Action<string> printReverse = delegate(string text)
         {
            char[] chars = text.ToCharArray();
            Array.Reverse(chars);
            Console.WriteLine(new string(chars));
         };

         Console.WriteLine("=============1. reversing=============");
         printReverse("Test for reversing text.");
         Console.WriteLine("======================================");
         Console.WriteLine();

         Console.WriteLine("=============2. Sqrt==================");
         List<int> integers = new List<int>
         {
            1, 4, 9, 16, 25, 36
         };

         //syntax of .NET 2.0
         //integers.ForEach(delegate(int n)
         //{
         //   Console.WriteLine("Sqrt({0}) = {1}", n, Math.Sqrt(n));
         //});

         //syntax of anonymous function
         integers.ForEach(n => {
            Console.WriteLine("Sqrt({0}) = {1}", n, Math.Sqrt(n));
         });
         Console.WriteLine("======================================");
         Console.WriteLine();

         Console.ReadKey();
      }
   }
}
