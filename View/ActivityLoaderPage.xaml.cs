using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp.View;

public partial class ActivityLoaderPage : ContentPage
{
	public ActivityLoaderPage()
	{
		InitializeComponent();
		BindingContext = new ActivityLoaderViewModel();
	}
}