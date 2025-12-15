using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MyFirstMAUIApp.Model.Entities;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using MAUIFirstMobileApp.Models.Messages;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class EditCollectionViewModel : ObservableObject
    {
        // The text bound to the Entry in EditCollectionPage
        [ObservableProperty]
        private string movieName = "TitleLayoutStack.StackLayoutTitle";

        // store the original movie name passed via query so we can locate the original item
        private string originalMovieName = string.Empty;

        // Called by the generated property setter whenever MovieName changes.
        // Capture the original value only once (initial query set).
        partial void OnMovieNameChanged(string value)
        {
            if (string.IsNullOrEmpty(originalMovieName))
            {
                originalMovieName = value ?? string.Empty;
            }
        }

        public EditCollectionViewModel()
        {
        }

        // Command wired up in XAML: Command="{Binding UpdateClickedCommand}"
        [RelayCommand]
        private async Task UpdateClicked()
        {
            // Build minimal movie objects for the message.
            // UpdatableCollectionViewModel finds the item by NameofMovie so Name is sufficient here.
            var oldMovie = new MarvelMovies { NameofMovie = originalMovieName };
            var newMovie = new MarvelMovies { NameofMovie = MovieName ?? string.Empty };

            // Send update message that UpdatableCollectionViewModel is listening for
            WeakReferenceMessenger.Default.Send(new UpdateMovieMessage(oldMovie, newMovie));

            // Navigate back to the previous page
            await Shell.Current.GoToAsync("..");
        }
    }
}