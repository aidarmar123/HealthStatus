using HealthStatus.Pages;

namespace HealthStatus
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new EntryPage();
        }
    }
}
