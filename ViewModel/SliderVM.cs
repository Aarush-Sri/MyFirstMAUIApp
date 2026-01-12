using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMAUIApp.View;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class SliderVM : ObservableObject
    {

        public String Title => "Slider Page";
        public String Xaml => "XAML"; public String Vm => "VM";

        public SliderVM()
        {

        }

        [RelayCommand]
        private async Task SliderXAMLClicked()
        {

            await Shell.Current.GoToAsync(nameof(SliderPageXAML));
        }

        [RelayCommand]
        private async Task SliderVMClicked()
        {

            await Shell.Current.GoToAsync(nameof(SLiderPageVM));
        }


    }

}

