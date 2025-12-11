using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp.View;

public partial class ImagesURIPage : ContentPage
{
	public ImagesURIPage()
	{
		InitializeComponent();
		BindingContext = new URIImagesViewModel();
	}
}