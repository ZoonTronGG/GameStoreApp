using GameStore.BLL;
using GameStore.DAL.Services;
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
            var rs = new RamService();

            MessageBox.Show(rs.GetItemById(1)!.Info.ToString());
            InitializeComponent();
            // Заполняет базу данными
            //DataPopulator dataPopulator = new DataPopulator();
            //dataPopulator.PopulateData();
        }
    }
}
