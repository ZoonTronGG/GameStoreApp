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

namespace GameStoreMainWPF
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
        private void svLineUp(object sender, RoutedEventArgs e)
        {
            MainScrollViewer.ScrollToVerticalOffset(200);
        }


        private void ScrollViewer_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            e.Handled = false;
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            MainScrollViewer.ScrollToVerticalOffset(800);
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ScrollContentBar.ScrollToHorizontalOffset(0);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ScrollContentBar.ScrollToHorizontalOffset(120);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ScrollContentBar.ScrollToHorizontalOffset(240);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ScrollContentBar.ScrollToHorizontalOffset(360);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ScrollContentBar.ScrollToHorizontalOffset(480);
        }

        private void Hyperlink_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();

            window1.Show();
            this.Close();
        }

        private void Hyperlink_Click_2(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();

            window2.Show();
            this.Close();
        }
        private void Hyperlink_Click_3(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();

            window3.Show();
            this.Close();
        }
        private void Hyperlink_Click_4(object sender, RoutedEventArgs e)
        {
            Window4 window4 = new Window4();

            window4.Show();
            this.Close();
        }
        private void Hyperlink_Click_5(object sender, RoutedEventArgs e)
        {
            Window5 window5 = new Window5();

            window5.Show();
            this.Close();
        }
    }
}
