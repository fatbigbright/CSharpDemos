using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace RegDemo00
{
   class Program
   {
      static void Main(string[] args)
      {
         try
         {
            string CATEGORY = @"SOFTWARE\Demo";
            string TEST_KEY = @"TestKey";
            RegistryKey reg = null;

            reg = Registry.CurrentUser.OpenSubKey(CATEGORY, true);

            if (reg == null)
            {
               reg = Registry.CurrentUser.CreateSubKey(CATEGORY);
            }

            object regValue = reg.GetValue(TEST_KEY);
            if (regValue != null)
            {
               Console.WriteLine("Reg Value is : {0}", regValue.ToString());
            }

            reg.SetValue(TEST_KEY, DateTime.Now.ToShortTimeString());

            reg.Close();
         }
         catch (Exception ex)
         {
            Console.WriteLine(ex.Message);
         }
      }
   }
}
