using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Maui.Graphics.Text;

namespace MyFirstMAUIApp.ViewModel;

public partial class SwitchVMVM : ObservableObject
{

	public String Title => "Switch VM Page";

	[ObservableProperty]
	private bool toggle = true;

    [ObservableProperty]
    private Color textColor = Colors.Blue;


    public SwitchVMVM()
	{
		
	}

	partial void OnToggleChanged(bool value)
	{
		Toggle = !Toggle;

		TextColor = Toggle ? Colors.Blue : Colors.Green;

    }



}