using GameStore.BLL.DTO;
using GameStore.BLL.Services;
using System.Threading.Tasks;
using System.Windows;

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
            // Заполняет базу данными



            //RamService ramService = new RamService();
            TestAsync();


        }

        public async Task TestAsync()
        {
            RamService ramService = new RamService();
            RamDto ram = await ramService.GetItemByIdAsync(1);
            
            MessageBox.Show(ram.Info);
        }
    }
}
