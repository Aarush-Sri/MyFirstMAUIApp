using MyFirstMAUIApp.ViewModel;
namespace MyFirstMAUIApp.View;

public partial class EmbeddedImagePage : ContentPage
{
	public EmbeddedImagePage()
	{
		InitializeComponent();
		BindingContext = new EmbeddedImageViewModel();
	}
}