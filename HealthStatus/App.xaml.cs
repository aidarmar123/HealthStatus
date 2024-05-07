using HealthStatus.Pages;
using HealthStatus.Services;

namespace HealthStatus
{
    public partial class App : Application
    {
        public static LocalDbService db = new LocalDbService();
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new EntryPage());
            
        }
    }
}
