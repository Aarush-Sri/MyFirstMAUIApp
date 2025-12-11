using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMAUIApp.Model.Messages;

public static class Msgs
{
    public static string NotEmpty { get; } = "Entry can't be empty";

    //Movie constraint messages
    public static string NotEmptyMovie { get; } = "Movie name cannot be empty.";

    //SQLite constraint messages
    public static string NotEmptyCountry { get; } = "Country can't be empty";
    public static string NotEmptyCity { get; } = "City can't be empty";
}
