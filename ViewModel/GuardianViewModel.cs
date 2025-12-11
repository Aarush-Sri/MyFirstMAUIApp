using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIApp.Model.Entities;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace MyFirstMAUIApp.ViewModel;

public partial class GuardianViewModel : ObservableObject
{
    private List<GuardianNames> _guardians;
    public string Title => "Collections w/ Images";
    public ObservableCollection<GuardianNames> GuardiansCollection { get; } = new();

    public GuardianViewModel()
    {
        _guardians = GuardianNames.getAllNames();
        LoadMovies();
    }

    private void LoadMovies()
    {
        try
        {
            GuardiansCollection.Clear();
            foreach (var p in _guardians)
            {
                GuardiansCollection.Add(new GuardianNames
                {
                    name = p.name,
                    nickname = p.nickname,
                    image = p.image
                });
                
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
        }
    }
}
