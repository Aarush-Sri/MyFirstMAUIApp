using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp.View;


public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();

	}
}