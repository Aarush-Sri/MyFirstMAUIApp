using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp.View;

public partial class ImagesPage : ContentPage
{
	public ImagesPage()
	{
		InitializeComponent();
		BindingContext = new ImagesViewModel();
	}
}