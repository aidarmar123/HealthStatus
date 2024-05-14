using HealthStatus.Models.DBModels;

namespace HealthStatus.Pages;

public partial class ChatWithMinday : ContentPage
{
	
	public ChatWithMinday()
	{
		InitializeComponent();

		Refresh();
	}

    private async void Refresh()
    {
		LVMsg.ItemsSource = await App.db.GetMessage();
		EMsg.Text = "";
    }

    private async void BSend_Clicked(object sender, EventArgs e)
    {
		if(!string.IsNullOrEmpty(EMsg.Text))
		{
			var msg = new Message();
			msg.Text = EMsg.Text;
			msg.Avtor = true;
			await App.db.SaveMessage(msg);	
		}
		Refresh();
    }
}