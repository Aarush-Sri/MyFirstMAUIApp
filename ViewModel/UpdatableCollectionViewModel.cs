using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MyFirstMAUIApp.Model.Entities;
using MyFirstMAUIApp.Model.Messages;
using Microsoft.Maui.Controls;
using MyFirstMAUIApp.View;
using MyFirstMAUIApp.Model.Titles;
using MAUIFirstMobileApp.Models.Messages;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class UpdatableCollectionViewModel : ObservableObject
    {
        // flag for pull-to-refresh
        [ObservableProperty] private bool isBusy;

        // page title
        [ObservableProperty] private string title = "Update Collection Page";

        // the list bound to CollectionView.ItemsSource
        [ObservableProperty]
        private ObservableCollection<MarvelMovies> movieCollection = new();

        public UpdatableCollectionViewModel()
        {

            // central listener for any UpdateMovieMessage
            WeakReferenceMessenger.Default.Register<UpdateMovieMessage>(this, (r, m) =>
            {
                var oldTitle = m.OldValue.NameofMovie;
                var idx = movieCollection.ToList()
                                         .FindIndex(x => x.NameofMovie == oldTitle);
                if (idx >= 0)
                    movieCollection[idx] = m.NewValue;
            });

            // kick off initial load
            RefreshCommand.Execute(null);
        }

        /// <summary>
        /// Reloads the in-memory list from your static data.
        /// </summary>
        [RelayCommand]
        private async Task Refresh()
        {
            if (isBusy) return;
            isBusy = true;

            // Use Task.Run to perform the CPU-bound work on a background thread
            await Task.Run(() =>
            {
                movieCollection.Clear();
                foreach (var mov in MarvelMovies.GetMovies())
                {
                    // Adding items to the collection
                    movieCollection.Add(mov);
                }
            });

            isBusy = false;
        }

        /// <summary>
        /// Navigate to AddCollectionPage, then await an AddMovieMessage.
        /// </summary>
        [RelayCommand]
        private async Task Add()
        {
            WeakReferenceMessenger.Default.Unregister<AddMovieMessage>(this);

            await Shell.Current.GoToAsync(nameof(AddCollectionPage));

            WeakReferenceMessenger.Default.Register<AddMovieMessage>(this, (r, m) =>
            {
                movieCollection.Add(m.Value);
                WeakReferenceMessenger.Default.Unregister<AddMovieMessage>(this);
            });
        }

        /// <summary>
        /// Navigate to EditCollectionPage with a ?movieName=… query
        /// </summary>
        [RelayCommand]
        private async Task Update(MarvelMovies movie)
        {
            // (No need to register update message here (below), it's already registered in constructor)
            //WeakReferenceMessenger.Default.Unregister<UpdateMovieMessage>(this);
            // Just navigate to the Edit page, encoding the movie name for safe URL transport
            string encodedName = Uri.EscapeDataString(movie.NameofMovie);
            await Shell.Current.GoToAsync($"{nameof(EditCollectionPage)}?movieName={encodedName}");
        }

        /// <summary>
        /// Remove immediately from the list.
        /// </summary>
        [RelayCommand]
        private void Delete(MarvelMovies movie)
        {
            movieCollection.Remove(movie);
        }
    }
}