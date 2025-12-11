using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp.View;

public partial class LayoutVerticalStackPage : ContentPage
{
	public LayoutVerticalStackPage()
	{
		InitializeComponent();
        BindingContext = new LayoutsVerticalStackViewModel();

    }
}