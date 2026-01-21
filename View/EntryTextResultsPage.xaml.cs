namespace MyFirstMAUIApp.View;

public partial class EntryTextResultsPage : ContentPage
{
	public EntryTextResultsPage()
	{
		InitializeComponent();
		BindingContext = new ViewModel.EntryResultsVM();
    }
}