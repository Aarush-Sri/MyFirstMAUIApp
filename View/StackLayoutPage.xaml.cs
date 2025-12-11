using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp.View;

public partial class StackLayoutPage : ContentPage
{
	public StackLayoutPage()
	{
		InitializeComponent();
        BindingContext = new LayoutsStackViewModel();
    }
}