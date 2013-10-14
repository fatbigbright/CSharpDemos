using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFWebBrowser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // to make webbrowser compatible with IE, refer to : http://www.xiaocan.me/archives/355
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string currentDir = System.IO.Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + "\\templates\\test.html";
            if (!System.IO.File.Exists(currentDir))
            {
                MessageBox.Show(string.Format("Cannot find the path: '{0}'", currentDir));
                return;
            }
            Uri local = new Uri(currentDir);
            this.webBrowser1.Navigate(local);
        }
    }
}
