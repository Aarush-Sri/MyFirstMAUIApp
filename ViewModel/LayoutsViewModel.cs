using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMAUIApp.Model.Titles;
using MyFirstMAUIApp.View;
using System.Threading.Tasks;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class LayoutsViewModel : ObservableObject
    {
        [ObservableProperty]
        private string layout = TitleLayouts.Title;

        [ObservableProperty]
        private string stackLayout = TitleLayouts.StackLayout;

        [ObservableProperty]
        private string verticalStack = TitleLayouts.VerticalStack;

        [ObservableProperty]
        private string horizontalStack = TitleLayouts.HorizontalStack;

        [ObservableProperty]
        private string absoluteLayout = TitleLayouts.AbsoluteLayout;

        [ObservableProperty]
        private string flexLayout = TitleLayouts.FlexLayout;



        public LayoutsViewModel()
        {

        }

        [RelayCommand]
        private async Task StackLayoutClicked()
        {

            await Shell.Current.GoToAsync(nameof(StackLayoutPage));
        }

        [RelayCommand]
        private async Task VerticalStackLayoutClicked()
        {
             await Shell.Current.GoToAsync(nameof(LayoutVerticalStackPage));
        }

        [RelayCommand]
        private async Task HorizontalStackLayoutClicked()
        {
             await Shell.Current.GoToAsync(nameof(LayoutHorizontalStackPage));
        }

        [RelayCommand]
        private async Task AbsoluteLayoutClicked()
        {
             await Shell.Current.GoToAsync(nameof(LayoutsAbsolutePage));
        }

        [RelayCommand]
        private async Task FlexLayoutClicked()
        {
            await Shell.Current.GoToAsync(nameof(LayoutFlexPage));
        }
    }
}