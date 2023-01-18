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

namespace GameStoreAdminWPF
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

		private void btnAddGame_Click(object sender, RoutedEventArgs e)
		{
			//if (ValidateInput())
			//{
			//	string genre = lstGenre.SelectedValue.ToString();
			//	//Add game to system
			//}
		}

		private void OnPreviewMouseWheel(object sender, MouseWheelEventArgs e)
		{
			var scrollViewer = (ScrollViewer)sender;
			scrollViewer.ScrollToVerticalOffset(scrollViewer.VerticalOffset - e.Delta);
			e.Handled = true;
		}

	}
}
