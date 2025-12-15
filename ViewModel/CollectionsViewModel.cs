using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using MyFirstMAUIApp.Model.Titles;
using MyFirstMAUIApp.View;
using System.Threading.Tasks;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class CollectionsViewModel : ObservableObject
    {
        public string Title => CollectionsModel.Title;

        public string Collection => CollectionsModel.Collection;

        public string CollectionImages => CollectionsModel.CollectionImages;

        public string CollectionButtons => CollectionsModel.CollectionButtons;

        public string CollectionIcons => CollectionsModel.CollectionIcons;


        public CollectionsViewModel()
        {

        }

        [RelayCommand]
        private async Task CollectionClicked()
        {

            await Shell.Current.GoToAsync(nameof(CollectionPage));
        }


        [RelayCommand]
        private async Task CollectionImagesClicked()
        {

            await Shell.Current.GoToAsync(nameof(CollectionImagesPage));
        }

        [RelayCommand]
        private async Task CollectionWButtonsClicked()
        {

            await Shell.Current.GoToAsync(nameof(UpdatableCollectionWButtonsPage));

        }

        [RelayCommand]
        private async Task CollectionWIconsClicked()
        {

            await Shell.Current.GoToAsync(nameof(CollectionsWIcons));

        }

    }
}