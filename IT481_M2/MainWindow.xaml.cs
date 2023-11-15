using IT481_M2.AppFiles;
using IT481_M2.BusinessLayer;
using Microsoft.Extensions.Options;
using System.Windows;

namespace IT481_M2 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly AppSettings _appSettings;
        public MainWindow(IOptionsMonitor<AppSettings> appSettings)
        {
            InitializeComponent();
            _appSettings = appSettings.CurrentValue;
            var connectionString = _appSettings.NorthwindConnectionString;
            var northwindService = new NorthwindService(connectionString);
            tbCount.Text = northwindService.GetCustomerCount().ToString();
            CustomerGrid.AutoGenerateColumns = false;
            CustomerGrid.ItemsSource = northwindService.GetCustomerNames();
        }
    }
}
