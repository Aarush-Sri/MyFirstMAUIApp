using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMAUIApp.Model.Titles;
using MyFirstMAUIApp.View;
using System.Threading.Tasks;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class ControlsVM : ObservableObject
    {
        public string Title => ControlsTitles.Title;
      
        public string Slider => ControlsTitles.Slider;

        public string Stepper => ControlsTitles.Stepper;

        public string Switch => ControlsTitles.Switch;

        public string EntryText => ControlsTitles.EntryText;





        public ControlsVM()
        {

        }

        [RelayCommand]
        private async Task SliderClicked()
        {

            await Shell.Current.GoToAsync(nameof(SliderPage));
        }

        [RelayCommand]
        private async Task StepperClicked()
        {

            await Shell.Current.GoToAsync(nameof(StepperPage));
        }

        [RelayCommand]
        private async Task SwitchClicked()
        {

            await Shell.Current.GoToAsync(nameof(SwitchPage));
        }


        [RelayCommand]
        private async Task EntryTextClicked()
        {

            await Shell.Current.GoToAsync(nameof(EntryPage));
        }




    }
}