using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp.View;

public partial class CollectionsPage : ContentPage
{
	public CollectionsPage()
	{
		InitializeComponent();
		BindingContext = new CollectionsViewModel();
	}
}