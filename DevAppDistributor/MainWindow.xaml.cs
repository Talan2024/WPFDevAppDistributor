using System;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;


namespace wpfbootstrap
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        string url = "urloftheodownloadlink";
        string zipname = "nameofthezip.zip";
        string filename = "anythingcangohere";

        private void UpdateButton(object sender, RoutedEventArgs e)
        {
            WebClient webClient = new WebClient();
            Directory.Delete(filename, true);
            webClient.DownloadFile(url, zipname);
            ZipFile.ExtractToDirectory(zipname, filename);
            File.Delete(zipname);
            MessageBox.Show("UPDATED");
        }

        private void DownloadButton(object sender, RoutedEventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile(url, zipname);
            ZipFile.ExtractToDirectory(zipname, filename);
            File.Delete(zipname);
            MessageBox.Show("DOWNLOADED");
        }


        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            bool flag = e.ChangedButton == MouseButton.Left;
            if (flag)
            {
                base.DragMove();
            }
        }

        
       

        
    }
}
