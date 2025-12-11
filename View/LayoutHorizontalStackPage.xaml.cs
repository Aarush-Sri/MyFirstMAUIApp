using MyFirstMAUIApp.ViewModel;
namespace MyFirstMAUIApp.View;

//using View.LayoutsHorizontalStackViewModel;
public partial class LayoutHorizontalStackPage : ContentPage
{
	public LayoutHorizontalStackPage()
	{
		InitializeComponent();
		BindingContext = new LayoutsHorizontalStackViewModel();
    }
}