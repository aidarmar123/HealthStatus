using HealthStatus.Models.DBModels;

namespace HealthStatus.Pages;

public partial class ChatWithMinday : ContentPage
{
	public string ContextText { get; set; }
	public ChatWithMinday()
	{
		InitializeComponent();
		Refresh();
	}

    private async void Refresh()
    {
		HLSend.BindingContext = this;
		LVMsg.ItemsSource = await App.db.GetMessage();
    }

    private async void BSend_Clicked(object sender, EventArgs e)
    {
		if(!string.IsNullOrEmpty(ContextText))
		{
			await App.db.SaveMessage(new Message(ContextText));
			ContextText.DefaultIfEmpty();
		}
		Refresh();
    }
}