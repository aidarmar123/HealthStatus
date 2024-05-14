using Microcharts;

namespace HealthStatus.Pages;

public partial class MentalHealthPage : ContentPage
{
	ChartEntry[] entries = new[]
	{
		new ChartEntry(120)
		{
			Label="window"
		},
		new ChartEntry(102)
		{
			Label="App"
		}
	};
	public MentalHealthPage()
	{
		InitializeComponent();
		TestCharts.Chart = new PieChart()
		{
			Entries = entries
		};
	}
}