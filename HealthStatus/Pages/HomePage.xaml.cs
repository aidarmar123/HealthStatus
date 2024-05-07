using HealthStatus.Services;

namespace HealthStatus.Pages;

public partial class HomePage : ContentPage
{
    LocalDbService database;
	public HomePage(LocalDbService db)
	{
		InitializeComponent();
        database = db;
	}

    private void BChat_Clicked(object sender, EventArgs e)
    {

    }

    private void BCoach_Clicked(object sender, EventArgs e)
    {

    }
}