
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMAUIApp.Model.Titles;
using MyFirstMAUIApp.View;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class ImagesViewModel : ObservableObject
    {
        [ObservableProperty]
        private string images = TitleImages.Title;
        
        [ObservableProperty]
        private string uriImages = TitleImages.uriImages;

        [ObservableProperty]
        private string embeddedImages = TitleImages.embeddedImages;

        [ObservableProperty]
        private string activityLoader = TitleImages.activityLoader;

        public ImagesViewModel()
        {

        }

        [RelayCommand]
        private async Task URIImagesClicked()
        {

            await Shell.Current.GoToAsync(nameof(ImagesURIPage));
        }

        [RelayCommand]
        private async Task EmbeddedImageClicked()
        {

            await Shell.Current.GoToAsync(nameof(EmbeddedImagePage));
        }

        [RelayCommand]
        private async Task ActivityLoaderClicked()
        {

            await Shell.Current.GoToAsync(nameof(ActivityLoaderPage));
        }


    }
}