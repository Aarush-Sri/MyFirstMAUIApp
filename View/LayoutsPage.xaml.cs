using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp.View;

public partial class LayoutsPage : ContentPage
{
	public LayoutsPage()
	{
		InitializeComponent();
		BindingContext = new LayoutsViewModel();
	}
}