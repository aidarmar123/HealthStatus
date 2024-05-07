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

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
