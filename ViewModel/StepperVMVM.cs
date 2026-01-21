using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class StepperVMVM : ObservableObject
    {

        public String Name => "Stepper VM";

        [ObservableProperty]
        public double step = 0;
        public String Text => $"The Stepper Value is {Step:F0}";
        public StepperVMVM()
        {

        }

        partial void OnStepChanged(double val)
        {
            OnPropertyChanged(nameof(Text));
        }




    }
}

