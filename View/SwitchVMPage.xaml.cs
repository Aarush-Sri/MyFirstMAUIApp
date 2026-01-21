using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp.View;

public partial class SwitchVMPage : ContentPage
{
	public SwitchVMPage()
	{
		InitializeComponent();
		BindingContext = new SwitchVMVM();
	}
}