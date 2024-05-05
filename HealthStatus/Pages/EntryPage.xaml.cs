
using HealthStatus.Models;

namespace HealthStatus.Pages;

public partial class EntryPage : ContentPage
{
	List<Emoji> emojis = new List<Emoji>();
	public EntryPage()
	{
		InitializeComponent();
        Refresh();
		
	}

    private void Refresh()
    {
    
        var emEvil = new Emoji(ImageSource.FromFile("evil.png"));
        var emMad = new Emoji(ImageSource.FromFile("mad.png"));
        var emDeffoult = new Emoji(ImageSource.FromFile("deffoult.png"));
        var emSmile = new Emoji(ImageSource.FromFile("smile.png"));
        var emHappy = new Emoji(ImageSource.FromFile("happy.png"));
        emojis.Add(emEvil);
        emojis.Add(emMad);
        emojis.Add(emDeffoult);
        emojis.Add(emSmile);
        emojis.Add(emHappy);
        CVItems.ItemsSource = emojis;
    }

    private async void CVItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        await Navigation.PushAsync(new AppShell());
    }
}