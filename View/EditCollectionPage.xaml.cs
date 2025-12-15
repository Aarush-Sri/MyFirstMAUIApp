using System;
using System.Collections.Generic;
using Microsoft.Maui.Controls;
using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp.View;

public partial class EditCollectionPage : ContentPage, IQueryAttributable
{
    public EditCollectionPage()
    {
        InitializeComponent();
        BindingContext = new EditCollectionViewModel();
    }

    // ApplyQueryAttributes is part of the IQueryAttributable interface
    // This method is called by Shell when you do GoToAsync(...?movieName=Foo)
    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        // Check for the "movieName" parameter in the query dictionary and set it in the ViewModel
        // Looks in the query dictionary for a parameter named "movieName" and stores its (encoded) value in raw.
        // Encoded version (safe for URLs - e.g. Avengers%3A%20Endgame) and
        // is undone with Uri.UnescapeDataString (e.g. Avengers: Endgame)
        if (query.TryGetValue("movieName", out var raw) && BindingContext is EditCollectionViewModel vm)
        {
            // Undo the URI encoding
            vm.MovieName = Uri.UnescapeDataString(raw as string ?? string.Empty);
        }
    }
}
