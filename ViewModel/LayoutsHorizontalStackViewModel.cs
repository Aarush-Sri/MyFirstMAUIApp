using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMAUIApp.Model.Titles;
using MyFirstMAUIApp.View;
using System.Threading.Tasks;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class LayoutsHorizontalStackViewModel : ObservableObject
    {
        [ObservableProperty]
        private string horizontalStack = TitleLayoutHorizontalStack.HorizontalStackLayoutTitle;


        public LayoutsHorizontalStackViewModel()
        {

        }

    }
}