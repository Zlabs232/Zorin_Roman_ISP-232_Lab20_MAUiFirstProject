namespace Zorin_Roman_ISP_232_Lab20_MAUiFirstProject;

public partial class AboutPage : ContentPage
{
	private async void LearnMore_Clicked(object sender, EventArgs e)
	{
		await Launcher.Default.OpenAsync("https://aka.ms/maui");
	}
	public AboutPage()
	{
		InitializeComponent();
	}
}