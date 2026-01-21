namespace MyFirstMAUIApp.View;

public partial class StepperXAMLPage : ContentPage
{
	public StepperXAMLPage()
	{
		InitializeComponent();
	}

	private void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
	{
		UpdateUI(e.NewValue);
	}

	private void UpdateUI(double value)
	{
		label.Rotation = value;
		DisplayLabel.Text = $"The Stepper Value is {value:F0}";
	}
}