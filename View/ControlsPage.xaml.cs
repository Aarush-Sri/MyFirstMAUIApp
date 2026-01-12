using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp.View;

public partial class ControlsPage : ContentPage
{
	public ControlsPage()
	{
		InitializeComponent();
		BindingContext = new ControlsVM();
	}
}