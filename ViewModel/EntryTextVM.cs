using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMAUIApp.Model.Titles;
using MyFirstMAUIApp.View;


namespace MyFirstMAUIApp.ViewModel
{
    public partial class EntryTextVM : ObservableObject
    {

        public String Name => "Entry Text Page";

        [ObservableProperty]
        private String text = string.Empty;


        public EntryTextVM()
        {

        }

        [RelayCommand]
        private async Task EntryClicked()
        {

            if (Text == "")
            {
                await Shell.Current.DisplayAlert(ControlsTitles.EntryText, "Entry is Empty. Please Enter text.", "OK");
            }

            else
            {
                await Shell.Current.DisplayAlert(ControlsTitles.EntryText, "You entered " + Text, "OK");


            }

            await Shell.Current.GoToAsync($"{nameof(EntryTextResultsPage)}?entryText={Text}");

        }
    }

}
