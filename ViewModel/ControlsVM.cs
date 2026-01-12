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


        public ControlsVM()
        {

        }

        [RelayCommand]
        private async Task SliderClicked()
        {

            await Shell.Current.GoToAsync(nameof(SliderPage));
        }

        


    }
}