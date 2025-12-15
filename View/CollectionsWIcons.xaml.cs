using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp.View;

public partial class CollectionsWIcons : ContentPage
{
	public CollectionsWIcons(UpdatableCollectionViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}