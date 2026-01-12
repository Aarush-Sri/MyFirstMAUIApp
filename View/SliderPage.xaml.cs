using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp.View;

public partial class SliderPage : ContentPage
{
	public SliderPage()
	{
		InitializeComponent();
		BindingContext = new SliderVM();

		//UpdateVisuals(MySlider.Value);

		//SetPlatformPadding();

	}

}