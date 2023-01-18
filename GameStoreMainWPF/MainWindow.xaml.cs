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
using static System.Net.Mime.MediaTypeNames;


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
            BitmapImage[,] imageArray = new BitmapImage[2, 5];
            string[,] imagePaths = new string[2, 5] {

             {"MainImg/MainImgForzaHorizon5.png", "MainImg/MainRecurceForzaHorizon5.png",
                "MainImg/MainRecurceForzaHorizon5.1.png", "MainImg/MainRecurceForzaHorizon5.2.png", "MainImg/MainRecurceForzaHorizon5.3.png"},
             {"MainImg/MainImgCallOfDuty.png", "MainImg/MainRecurceCallOfDuty.png",
                "MainImg/MainRecurceCallOfDuty.1.png", "MainImg/MainRecurceCallOfDuty.2.png", "MainImg/MainRecurceCallOfDuty.3.png"}

    };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    imageArray[i, j] = new BitmapImage(new Uri(imagePaths[i, j]));
                }
            }
            Random random = new Random();
            int group = random.Next(0, imageArray.Length -1);
            OnMainPageImg0.Source = imageArray[group, 0];
            OnMainPageImg1.Source = imageArray[group, 1];
            OnMainPageImg2.Source = imageArray[group,2];
            OnMainPageImg3.Source = imageArray[group,3];
            OnMainPageImg4.Source = imageArray[group,4];
            



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
        string originalsource;
        private void OnMainPageImg1_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Controls.Image img = sender as System.Windows.Controls.Image;
            originalsource = OnMainPageImg0.Source.ToString();
            OnMainPageImg0.Source = img.Source;
            
        }

        private void OnMainPageImg1_MouseLeave(object sender, MouseEventArgs e)
        {
            OnMainPageImg0.Source = new BitmapImage(new Uri(originalsource));
        }
    }
}
