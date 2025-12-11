using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp.View;

public partial class CollectionPage : ContentPage
{
	public CollectionPage()
	{
		InitializeComponent();
		BindingContext = new CollectionViewModel();
	}
}