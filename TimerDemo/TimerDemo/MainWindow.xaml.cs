using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TimerDemo
{
   public partial class MainWindow : Window
   {
      private System.Windows.Threading.DispatcherTimer _timer = new System.Windows.Threading.DispatcherTimer();
      public MainWindow()
      {
         InitializeComponent();
         double ticks = 0L;
         System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();

         int frameCount = 0;

         //There is a textbox "txtTicks" which accept a millisecond value
         //And a button "btn", by clicking the button the dispatchertimer & 
         //stopwatcher are started.
         _timer.Tick += (sender, e) =>
         {
            frameCount++;
            //System.Diagnostics.Debug.WriteLine(watch.ElapsedMilliseconds);
            if (watch.ElapsedMilliseconds > 1000)
            {
               _timer.Stop();
               watch.Reset();
               MessageBox.Show(string.Format("Already 1 second! FrameCount: {0}", frameCount));
               frameCount = 0;
            }
         };

         this.btn.Click += (sender, e) =>
         {
            double.TryParse(this.txtTicks.Text, out ticks);
            if (ticks != 0.0)
            {
               _timer.Interval = TimeSpan.FromMilliseconds(ticks);
            }
            _timer.Start();
            watch.Start();
         };
      }
   }
}
