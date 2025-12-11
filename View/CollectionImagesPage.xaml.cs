using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp.View;

public partial class CollectionImagesPage : ContentPage
{
	public CollectionImagesPage()
	{
		InitializeComponent();
		BindingContext = new GuardianViewModel();
	}
}