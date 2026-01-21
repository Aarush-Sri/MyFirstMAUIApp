using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMAUIApp.View;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class SwitchPageVM : ObservableObject
    {

        public String Title => "Switch Page";
        public String Xaml => "XAML"; public String Vm => "VM";

        public SwitchPageVM()
        {

        }

        [RelayCommand]
        private async Task SwitchXAMLClicked()
        {

            await Shell.Current.GoToAsync(nameof(SwitchXAMLPage));
        }

        [RelayCommand]
        private async Task SwitchVMClicked()
        {

            await Shell.Current.GoToAsync(nameof(SwitchVMPage));
        }


    }

}

