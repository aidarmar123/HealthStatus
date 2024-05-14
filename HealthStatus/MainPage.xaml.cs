using HealthStatus.Services;

namespace HealthStatus
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage(LocalDbService database)
        {
            InitializeComponent();
           // db = database;
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.MentalHealthPage());
        }
    }

}
