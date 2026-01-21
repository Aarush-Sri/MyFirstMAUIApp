using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class SliderPageVMVM : ObservableObject
    {

        public String Name => "Slider VM";

        [ObservableProperty]
        public double opacity = 1;
        public String Text => $"Opacity: {Opacity:F2}";
        public SliderPageVMVM()
        {

        }

        partial void OnOpacityChanged(double val)
        {
            OnPropertyChanged(nameof(Text));
        }

        [RelayCommand]
        private async Task Set()
        {
            Opacity = 0.5;
        }





    }
}

