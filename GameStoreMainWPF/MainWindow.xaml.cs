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
        private int currentImageIndex = 0;
        private string[] imageFiles;

        public MainWindow()
        {
            InitializeComponent();
            imageFiles = Directory.GetFiles("Images");
            ShowNextImage();
        }

        private void ShowNextImage()
        {
            if (currentImageIndex == imageFiles.Length)
                currentImageIndex = 0;
            Image.Source = new BitmapImage(new Uri(imageFiles[currentImageIndex]));
            currentImageIndex++;
        }

        private void ShowPreviousImage()
        {
            if (currentImageIndex == 0)
                currentImageIndex = imageFiles.Length - 1;
            else
                currentImageIndex--;
            Image.Source = new BitmapImage(new Uri(imageFiles[currentImageIndex]));
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            ShowNextImage();
        }

        private void PreviousButton_Click(object sender, RoutedEventArgs e)
        {
            ShowPreviousImage();
        }
    }
}
