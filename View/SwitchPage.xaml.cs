using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp.View;

public partial class SwitchPage : ContentPage
{
	public SwitchPage()
	{
		InitializeComponent();
		BindingContext = new SwitchPageVM();
	}
}