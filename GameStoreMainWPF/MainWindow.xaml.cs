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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ScrollViewer.ScrollToHorizontalOffset(50);
        }

        private void ScrollViewer_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            e.Handled = false;
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            MainScrollViewer.ScrollToVerticalOffset(800);
        }
    }
}
