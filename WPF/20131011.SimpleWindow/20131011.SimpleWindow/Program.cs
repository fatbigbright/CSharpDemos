using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace _20131011.SimpleWindow
{
   class Program
   {
      [STAThread]
      static void Main(string[] args)
      {
         Window mywin = new Window();
         mywin.Title = "Simple Window";
         mywin.Content = "This is a simple window.";
         mywin.Width = 200d;
         mywin.Height = 100d;

         Application myApp = new Application();
         myApp.Run(mywin);
      }
   }
}
