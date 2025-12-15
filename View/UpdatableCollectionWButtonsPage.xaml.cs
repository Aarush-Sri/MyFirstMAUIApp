using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp.View;

public partial class UpdatableCollectionWButtonsPage : ContentPage
{
	public UpdatableCollectionWButtonsPage(UpdatableCollectionViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}