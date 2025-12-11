using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIApp.Model.Titles;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class EmbeddedImageViewModel : ObservableObject
    {
        
        public string title => EmbeddedImageModel.Title;

        [ObservableProperty]
        private ImageSource imageSource = "dotnet_bot.png";

        public EmbeddedImageViewModel()
        {
          
        }

    }
}
