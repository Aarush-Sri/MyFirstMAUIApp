using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp.View;

public partial class SliderPageXAML : ContentPage
{
    public SliderPageXAML()
    {
        InitializeComponent();
        BindingContext = new SliderVM();

        UpdateVisuals(MySlider.Value);

        SetPlatformPadding();

    }

    private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
    {
        UpdateVisuals(e.NewValue);
    }

    private void UpdateVisuals(double value)
    {
        MyBox.Opacity = value;
        ValueLabel.Text = $"Opacity: {value:F2}";
        InfoLabel.Opacity = value;

    }

    private void SetPlatformPadding()
    {
        if (DeviceInfo.Platform == DevicePlatform.iOS || DeviceInfo.Platform == DevicePlatform.Android)
        {
            Padding = new Thickness(25);
        }

        else
        {
            Padding = Thickness.Zero;
        }

    }

}