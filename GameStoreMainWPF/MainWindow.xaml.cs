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
            UIElement firstChild = GridCategory.Children[0];
            GridCategory.Children.RemoveAt(0);
            GridCategory.Children.Add(firstChild);
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UIElement lastChild = GridCategory.Children[GridCategory.Children.Count - 1];
            GridCategory.Children.RemoveAt(GridCategory.Children.Count - 1);
            GridCategory.Children.Insert(0, lastChild);
        }

        private void Button_Click_newAndRec(object sender, RoutedEventArgs e)
        {
            UIElement firstChild = GridNewAndRec.Children[0];
            GridNewAndRec.Children.RemoveAt(0);
            GridNewAndRec.Children.Add(firstChild);
        }

        private void Button_Click_newAndRec1(object sender, RoutedEventArgs e)
        {
            UIElement lastChild = GridNewAndRec.Children[GridNewAndRec.Children.Count - 1];
            GridNewAndRec.Children.RemoveAt(GridNewAndRec.Children.Count - 1);
            GridNewAndRec.Children.Insert(0, lastChild);
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
        private void Hyperlink_Click_6(object sender, RoutedEventArgs e)
        {
            Window6 window6 = new Window6();

            window6.Show();
            this.Close();
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (SaerchBox.Text == "")
            {
                SaerchBox.Text = "Поиск";
            }
        }

        private void SaerchBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (SaerchBox.Text == "Поиск")
            {
                SaerchBox.Text = "";
            }
        }
    }
}
