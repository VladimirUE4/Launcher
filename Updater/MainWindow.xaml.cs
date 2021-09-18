using System;
using System.Net;
using System.Windows;
using System.Diagnostics;


namespace Updater
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            WebClient client = new WebClient();

            try
            {
                client.DownloadFile("http://localhost/Dofus/bones345.d2p", @"C:\Users\jocel\Desktop\Test\bones345.d2p");
                Console.WriteLine("Download");
            }

            catch (Exception)
            {
                Console.WriteLine("Erreur");
                Environment.Exit(0);
            }
            client.Dispose();


            Environment.Exit(0);

        }
    }
}
