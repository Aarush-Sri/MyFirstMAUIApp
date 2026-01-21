using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp.View;

public partial class EntryPage : ContentPage
{
	public EntryPage()
	{
		InitializeComponent();
		BindingContext = new EntryTextVM();
	}
}