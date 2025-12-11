using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIApp.Model.Entities;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace MyFirstMAUIApp.ViewModel;

public partial class CollectionViewModel : ObservableObject
{
    private List<MarvelMovies> _marvelmovies;
    public string title => "Marvel Movies";
    public ObservableCollection<MarvelMovies> MarvelMoviesCollection { get; } = new();

    public CollectionViewModel()
    {
        _marvelmovies = MarvelMovies.GetMovies();
        LoadMovies();
    }

    private void LoadMovies()
    {
        try
        {
            MarvelMoviesCollection.Clear();
            foreach (var p in _marvelmovies)
            {
                MarvelMoviesCollection.Add(new MarvelMovies { NameofMovie = p.NameofMovie });
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
        }
    }
}
