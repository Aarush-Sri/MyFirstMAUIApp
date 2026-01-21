
using CommunityToolkit.Mvvm.ComponentModel;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class EntryResultsVM : ObservableObject, IQueryAttributable
    {

        public String Name => "Entry Results Page";

        [ObservableProperty]
        private String text = string.Empty;

        public EntryResultsVM()
        {

        }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            if (query.ContainsKey("entryText"))
            {
                Text = (string)query["entryText"];
            }
        }
        


    }

}
