using MAUIFirstMobileApp.ViewModels;
using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp.View;

public partial class AddCollectionPage : ContentPage
{
	public AddCollectionPage()
	{
		InitializeComponent();
		BindingContext = new AddCollectionViewModel();
	}
}