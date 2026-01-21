namespace MyFirstMAUIApp.View;

public partial class StepperVMPage : ContentPage
{
	public StepperVMPage()
	{
		InitializeComponent();
		BindingContext = new ViewModel.StepperVMVM();
    }
}