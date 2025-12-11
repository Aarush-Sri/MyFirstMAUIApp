using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMAUIApp.Model.Titles;
using MyFirstMAUIApp.View;
using System.Threading.Tasks;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class LayoutsVerticalStackViewModel : ObservableObject
    {
        [ObservableProperty]
        private string verticalStack = TitleLayoutVerticalStack.VerticalStackLayoutTitle;


        public LayoutsVerticalStackViewModel()
        {

        }

    }
}