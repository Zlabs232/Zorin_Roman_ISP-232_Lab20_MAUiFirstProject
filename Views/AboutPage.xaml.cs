namespace Zorin_Roman_ISP_232_Lab20_MAUiFirstProject.Views;

public partial class AboutPage : ContentPage
{
	private async void LearnMore_Clicked(object sender, EventArgs e)
	{
		if(BindingContext is Models.About about)
		{
			await Launcher.Default.OpenAsync(about.MoreInfoUrl);
		}
	}
	public AboutPage()
	{
		InitializeComponent();
	}
}