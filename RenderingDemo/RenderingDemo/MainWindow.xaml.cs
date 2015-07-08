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

namespace RenderingDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _frameCount = 0;
        private System.Diagnostics.Stopwatch _stopWatch = new System.Diagnostics.Stopwatch();
        private long _tempElaspedMilliSecond = 0;
        public MainWindow()
        {
            InitializeComponent();
            CustomInitializeComponent();
        }

        private void CustomInitializeComponent()
        {
            CompositionTarget.Rendering += (sender, args) =>
            {
                if (_stopWatch.IsRunning && _stopWatch.ElapsedMilliseconds - _tempElaspedMilliSecond < 22)
                    return;
                /*
                RenderingEventArgs rArgs = args as RenderingEventArgs;
                if (rArgs == null) return;
                */
                if (_frameCount++ == 0)
                {
                    _stopWatch.Start();
                }

                _tempElaspedMilliSecond = _stopWatch.ElapsedMilliseconds;

                long frameRate = (long)(_frameCount / _stopWatch.Elapsed.TotalSeconds);
                if (frameRate > 0)
                {
                    this.lblFPS.Content = frameRate.ToString();
                }
            };
        }
    }
}
