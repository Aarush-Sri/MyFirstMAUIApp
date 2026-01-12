using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp.View;

public partial class SLiderPageVM : ContentPage
{
	public SLiderPageVM()
	{
		InitializeComponent();
		BindingContext = new SliderPageVMVM();
	}
}