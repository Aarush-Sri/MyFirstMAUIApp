using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp.View;

public partial class StepperPage : ContentPage
{
	public StepperPage()
	{
		InitializeComponent();
		BindingContext = new StepperVM();
	}
}