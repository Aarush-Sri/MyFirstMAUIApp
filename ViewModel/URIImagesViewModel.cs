using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIApp.Model.Titles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class URIImagesViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title = TitleURIImages.URIImagesTitle;

        [ObservableProperty]
        private ImageSource imageSourceURL;

        public URIImagesViewModel()
        {
            imageSourceURL = new UriImageSource
            {
                Uri = new Uri(TitleURIImages.ImageURL),
                CachingEnabled = true,
                CacheValidity = TimeSpan.FromDays(1)
            };

        }

    }
}
