using MyFirstMAUIApp.ViewModel;
namespace MyFirstMAUIApp.View;

public partial class LayoutsAbsolutePage : ContentPage
{
	public LayoutsAbsolutePage()
	{
        InitializeComponent();
        this.BindingContext = new LayoutsAbsoluteViewModel();
    }
}