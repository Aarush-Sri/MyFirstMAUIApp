namespace MyFirstMAUIApp.View;

public partial class SwitchXAMLPage : ContentPage
{
	public SwitchXAMLPage()
	{
		InitializeComponent();
	}

	private void SwitchToggle(object sender, ToggledEventArgs e)
	{
		label.TextColor = e.Value ? Colors.Blue : Colors.Green;
	}


}