using HealthStatus.Pages;

namespace HealthStatus
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new EntryPage());
           
        }
    }
}
