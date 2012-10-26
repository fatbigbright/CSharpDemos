using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MutiTheadDemo00
{
   //How to make sure that console output in the form as "ABABAB...." without "AAABBBAA..."
   class Program
   {
      /* Method 1: using Mutex to make current thread to hold resource
      static Mutex mut = new Mutex();
      static void PrintA()
      {
         mut.WaitOne();
         Console.Write("A");
      }

      static void PrintB()
      {
         Console.Write("B");
         mut.ReleaseMutex();
      }
       * */

      // Method 2: using lock
      static object lockObj = new Object();
      static bool allow = false;

      static void PrintA()
      {
         lock (lockObj)
         {
            if (!allow)
            {
               Console.Write("A");
               allow = true;
            }
         }
      }

      static void PrintB()
      {
         lock (lockObj)
         {
            if (allow)
            {
               Console.Write("B");
               allow = false;
            }
         }
      }

      static void Main(string[] args)
      {
         for (var i = 0; i < 10; i++)
         {
            new Thread(() =>
            {
               PrintA();
               PrintB();
            }).Start();
         }
      }
   }
}
