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

namespace AnimationDemo
{
    using debug = System.Diagnostics.Debug;
    using sandbox = ArraySandBox.ArraySandBox;
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int[,] matrix;

        private const int MAX_LINE = 10;
        private const int MAX_COL = 10;
        private readonly double T_WIDTH = 30d;
        private readonly double T_HEIGHT = 30d;

        private System.Windows.Threading.DispatcherTimer _timer = new System.Windows.Threading.DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            InitializeMatrix();
            InitializeTimer();
        }
        private void InitializeMatrix()
        {
            matrix = new int[MAX_LINE, MAX_COL];
            debug.WriteLine("Max Line: {0}, Max column: {1}", matrix.GetLength(0), matrix.GetLength(1));
            RandomSetupMatrix();
        }

        private void RandomSetupMatrix()
        {
            matrix = sandbox.CalculateRandomly(matrix);
        }
        private void SetupGameOfLife()
        {
            matrix = sandbox.GetGameOfLifeNextStep(matrix);
        }

        private void RenderCanvas()
        {
            for (int line = 0; line < MAX_LINE; line++)
            {
                for (int column = 0; column < MAX_COL; column++)
                {
                    Rectangle rec = canvas.Children[line * MAX_COL + column] as Rectangle;
                    SolidColorBrush fillBrush = rec.Fill as SolidColorBrush;
                    SolidColorBrush strokeBrush = rec.Stroke as SolidColorBrush;
                    if (matrix[line, column] == 1)
                    {
                        fillBrush.Color = Colors.Blue;
                        strokeBrush.Color = Colors.DarkGreen;
                    }
                    else
                    {
                        fillBrush.Color = Colors.Transparent;
                        strokeBrush.Color = Colors.Transparent;
                    }
                }
            }
        }
        private void InitializeTimer()
        {
            _timer.Tick += delegate(object sender, EventArgs e)
            {
                //RandomSetupMatrix();
                SetupGameOfLife();
                RenderCanvas();
            };
            _timer.Interval = new TimeSpan(0, 0, 1);
            _timer.Start();
        }

        private void Canvas_Loaded(object sender, RoutedEventArgs e)
        {
            Canvas can = sender as Canvas;

            if (can.Children.Count == 0)
            {
                for (int line = 0; line < MAX_LINE; line++)
                {
                    for (int column = 0; column < MAX_COL; column++)
                    {
                        Rectangle rec = new Rectangle();
                        rec.Width = T_WIDTH;
                        rec.Height = T_HEIGHT;
                        if (matrix[line, column] == 1)
                        {
                            rec.Fill = new SolidColorBrush(Colors.Blue);
                            rec.Stroke = new SolidColorBrush(Colors.DarkGreen);
                        }
                        else
                        {
                            rec.Fill = new SolidColorBrush(Colors.Transparent);
                            rec.Stroke = new SolidColorBrush(Colors.Transparent);
                        }

                        can.Children.Insert(line * MAX_COL + column,rec);

                        Canvas.SetLeft(rec, column * T_WIDTH);
                        Canvas.SetTop(rec, line * T_HEIGHT);
                    }
                }
            }
        }

        
    }
}
