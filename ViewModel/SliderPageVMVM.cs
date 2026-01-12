using CommunityToolkit.Mvvm.ComponentModel;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class SliderPageVMVM : ObservableObject
    {
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




    }
}

