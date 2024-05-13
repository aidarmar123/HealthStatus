using HealthStatus.Services;

namespace HealthStatus.Pages;

public partial class HomePage : ContentPage
{
    LocalDbService database;
	public HomePage()
	{
		InitializeComponent();
        database = App.db;
	}

    private async void BChat_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ChatWithMinday());
    }

    private void BCoach_Clicked(object sender, EventArgs e)
    {

    }
}