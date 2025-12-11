using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIApp.Model.Titles;
using Microsoft.Maui.Controls;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class ActivityLoaderViewModel : ObservableObject
    {
        public string Title => ActivityLoaderModel.Title;

        [ObservableProperty]
        private bool isLoading = true;

        [ObservableProperty]
        private bool isImageVisible = false;

        [ObservableProperty]
        private ImageSource loadedImage;
            

        public ActivityLoaderViewModel()
        {
            _ = LoadImageAsync();   
        }

        private async Task LoadImageAsync()
        {
            try
            {
                using var client = new HttpClient();
                var response = await client.GetAsync(TitleURIImages.ImageURL);

                if (response.IsSuccessStatusCode)
                {
                    var stream = await response.Content.ReadAsStreamAsync();
                    LoadedImage = ImageSource.FromStream(() => stream);
                    IsImageVisible = true;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);  
            }

            finally
            {
                IsLoading = false;
            }
        }
    }
}
