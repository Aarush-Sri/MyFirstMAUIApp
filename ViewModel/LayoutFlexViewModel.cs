using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIApp.Model.Titles;


namespace MyFirstMAUIApp.ViewModel
{
    public partial class LayoutFlexViewModel : ObservableObject
    {
        [ObservableProperty]
        private string flex = TitleLayoutFlex.FlexLayoutTitle;

        public LayoutFlexViewModel()
        {

        }

    }
}