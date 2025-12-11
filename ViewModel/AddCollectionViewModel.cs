using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MAUIFirstMobileApp.Models.Messages;
using MyFirstMAUIApp.Model.Entities;
using MyFirstMAUIApp.Model.Messages;
using MyFirstMAUIApp.Model.Titles;

namespace MAUIFirstMobileApp.ViewModels
{
    public partial class AddCollectionViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title = "Add Page Collection Page";

        [ObservableProperty]
        private string movieName = string.Empty;

        [RelayCommand]
        private async Task SaveBtnClicked()
        {
            // Ensure the MovieName is not empty
            if (string.IsNullOrWhiteSpace(MovieName))
            {
                // Display Error Message to the user
                await Shell.Current.DisplayAlert(
                    Title,             // <-- Uses your generated Title property
                    Msgs.NotEmpty,     // <-- Msgs class located in Models/Messages/Msgs.cs
                    "Ok");             // <-- Button text
                return;
            }

            // Create a new MarvelMovies object
            var movie = new MarvelMovies { NameofMovie = MovieName };

            // Wrap in your Message so the subscriber sees it
            WeakReferenceMessenger.Default.Send(new AddMovieMessage(movie));

            // 🏷 Under Shell, pop with Shell.Current.GoToAsync("..") -> go back one page
            // //similar to Navigation.PopAsync()
            await Shell.Current.GoToAsync("..");
        }
    }
}
