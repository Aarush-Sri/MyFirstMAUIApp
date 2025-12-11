namespace MyFirstMAUIApp.View;
using MyFirstMAUIApp.ViewModel;


public partial class LayoutFlexPage : ContentPage
{
	public LayoutFlexPage()
	{
		InitializeComponent();
		BindingContext = new LayoutFlexViewModel();

    }
}