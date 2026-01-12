    using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMAUIApp.Model.Titles;
using MyFirstMAUIApp.View;
using System.Threading.Tasks;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {


        // Observable properties - use if these need to change at runtime

        [ObservableProperty]
        private string title = TitleMain.Title;

        [ObservableProperty]
        private string layouts = TitleMain.Layouts;

        [ObservableProperty]
        private string images = TitleMain.Images;

        [ObservableProperty]
        private string collections = TitleMain.Collections;

        [ObservableProperty]
        private string controls = TitleMain.Controls;

        [ObservableProperty]
        private string sQLLite = TitleMain.SQLLite;

        public MainViewModel()
        {
            // Constructor can be empty if you're using field initializers above
        }

        [RelayCommand]
        private async Task LayoutsClicked()
        {
            await Shell.Current.GoToAsync(nameof(LayoutsPage));

            //Application.Current.MainPage.Navigation.PushAsync(new LayoutsPage());
        }

        // Add similar commands for other sections
        [RelayCommand]
        private async Task ImagesClicked()
        {
             await Shell.Current.GoToAsync(nameof(ImagesPage));
        }

        [RelayCommand]
        private async Task CollectionsClicked()
        {
             await Shell.Current.GoToAsync(nameof(CollectionsPage));
        }

        [RelayCommand]
        private async Task ControlsClicked()
        {
             await Shell.Current.GoToAsync(nameof(ControlsPage));
        }

        [RelayCommand]
        private async Task SQLLiteClicked()
        {
            // await Shell.Current.GoToAsync(nameof(SQLLitePage));
        }
    }
}