
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
        var emEvil = new Emoji(ImageSource.FromFile("evil.svg"));
        var emMad = new Emoji(ImageSource.FromFile("mad.svg"));
        var emDeffoult = new Emoji(ImageSource.FromFile("deffoult.svg"));
        var emSmile = new Emoji(ImageSource.FromFile("smile.svg"));
        var emHappy = new Emoji(ImageSource.FromFile("dotnet_bot.png"));
        emojis.Add(emEvil);
        emojis.Add(emMad);
        emojis.Add(emDeffoult);
        emojis.Add(emSmile);
        emojis.Add(emHappy);
        CVItems.ItemsSource = emojis;
    }

    private void CVItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}