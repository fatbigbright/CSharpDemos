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
        private double _secondCounter = 0d;
        private TimeSpan _lastRender;
        public MainWindow()
        {
            InitializeComponent();
            CustomInitializeComponent();
        }

        private void CustomInitializeComponent()
        {
            //MediaTimeline.DesiredFrameRateProperty.OverrideMetadata(typeof(MediaTimeline), new FrameworkPropertyMetadata { DefaultValue = 30 });
            _lastRender = new TimeSpan(0, 0, 0, 0, 0);
            CompositionTarget.Rendering += (sender, args) =>
            {
                RenderingEventArgs renderArgs = args as RenderingEventArgs;
                Double deltaTime = (renderArgs.RenderingTime - _lastRender).TotalSeconds;
                //if (deltaTime < 0.022) return;

                _lastRender = renderArgs.RenderingTime;
                _secondCounter += deltaTime;
                _frameCount++;

                long frameRate = (long)(_frameCount / renderArgs.RenderingTime.TotalSeconds);
                if (frameRate > 0)
                {
                    this.lblFPS.Content = frameRate.ToString();
                }
            };
        }
    }
}
