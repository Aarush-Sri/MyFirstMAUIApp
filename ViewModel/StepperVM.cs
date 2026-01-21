using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMAUIApp.View;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class StepperVM : ObservableObject
    {

        public String Title => "Stepper Page";
        public String Xaml => "XAML"; public String Vm => "VM";

        public StepperVM()
        {

        }

        [RelayCommand]
        private async Task StepperXAMLClicked()
        {

            await Shell.Current.GoToAsync(nameof(StepperXAMLPage));
        }

        [RelayCommand]
        private async Task StepperVMClicked()
        {

            await Shell.Current.GoToAsync(nameof(StepperVMPage));
        }


    }

}

