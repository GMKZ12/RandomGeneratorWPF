using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

namespace RandomGenerater
{
    
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public string filePath;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GenerateRandomNumber(object sender, RoutedEventArgs e)
        {
  
            int start;
            int end;
            int n;
            
            Random random = new Random();
            start = int.Parse(RandomStart.Text);
            end = int.Parse(RandomEnd.Text);
            n=random.Next(Math.Min(start,end),Math.Max(start,end)+1);
            RandomText.Text = n.ToString();
            
            
        }

        private void openSelectFile(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            
            dialog.ShowDialog();
            filePath = dialog.FileName;
            filepathtext.Text = filePath;
            Generate2.IsEnabled = true;
        }
        private void Generate2Click(object sender, RoutedEventArgs e)
        {
            
            StreamReader sr = new StreamReader(filePath, Encoding.UTF8);
            string line = "";
            int start;
            int end;
            int n;
            Random random = new Random();
            start = int.Parse(RandomStart.Text);
            end = int.Parse(RandomEnd.Text);
            n = random.Next(Math.Min(start, end), Math.Max(start, end) + 1);
            for (int i = 0; i <= n-1; i++)
            {
                line = sr.ReadLine();
            }
            RandomText.Text = n.ToString();
            NameText.Text = line;
        }
    }
}
