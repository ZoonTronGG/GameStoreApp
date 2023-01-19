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
using System.Windows.Shapes;

namespace GameStoreMainWPF
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();

            mainWindow.Show();
            this.Close();
        }

        private void Hyperlink_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();

            mainWindow.Show();
            this.Close();


        }
        private int currentGridIndex = 1;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VampireSurvivor.Visibility = Visibility.Collapsed;
            DeadByDaylight.Visibility = Visibility.Collapsed;
            TotalWarWarhammer3.Visibility = Visibility.Collapsed;

            if (currentGridIndex == 2)
                VampireSurvivor.Visibility = Visibility.Visible;
            else if (currentGridIndex == 1)
                DeadByDaylight.Visibility = Visibility.Visible;
            else if (currentGridIndex == 3)
                TotalWarWarhammer3.Visibility = Visibility.Visible;


            currentGridIndex--;
            if (currentGridIndex < 1)
                currentGridIndex = 3;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            VampireSurvivor.Visibility = Visibility.Collapsed;
            DeadByDaylight.Visibility = Visibility.Collapsed;
            TotalWarWarhammer3.Visibility = Visibility.Collapsed;

            if (currentGridIndex == 2)
                VampireSurvivor.Visibility = Visibility.Visible;
            else if (currentGridIndex == 1)
                DeadByDaylight.Visibility = Visibility.Visible;
            else if (currentGridIndex == 3)
                TotalWarWarhammer3.Visibility = Visibility.Visible;

            currentGridIndex++;
            if (currentGridIndex > 3)
                currentGridIndex = 1;
        }
    }
}
