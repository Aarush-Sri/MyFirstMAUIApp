using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMAUIApp.Model.Titles;
using MyFirstMAUIApp.View;
using System.Threading.Tasks;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class LayoutsAbsoluteViewModel : ObservableObject
    {
        [ObservableProperty]
        private string absolute = TitleLayoutAbsoulte.AbsolutleLayoutTitle;

        //[ObservableProperty]
        //private int xIndex = 25;

        //[ObservableProperty]
        //private int yIndex = 40;


        public LayoutsAbsoluteViewModel()
        {

        }

    }
}