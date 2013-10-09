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

namespace MessagePump
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private class Worker
        {
            public void DoFirstJob()
            {
                Console.WriteLine("First Job!!");
            }
            public void DoSecondJob()
            {
                Console.WriteLine("Second Job!");
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void btnDoStuff_Click(object sender, RoutedEventArgs args)
        {
            string readyText = lblStatus.Content as string;
            btnDoStuff.IsEnabled = false;
            lblStatus.Content = "Doing Stuff";

            Worker worker = new Worker();

            await Task.Run(new Action(worker.DoFirstJob));
            await Task.Run(new Action(worker.DoSecondJob));
            await Task.Delay(4000);

            lblStatus.Content = readyText;
            btnDoStuff.IsEnabled = true;
        }

    }
}
