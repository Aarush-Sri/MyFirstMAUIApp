namespace MyFirstMAUIApp.Model.Entities;

public class GuardianNames
{
    public string name { get; set; }
    public string nickname { get; set; }
    public string image { get; set; }


    public GuardianNames()
    {

    }

    public GuardianNames(string name, string nickname, string image) {

        this.name = name;
        this.nickname = nickname;
        this.image = image;
    }

    public static List<GuardianNames> getAllNames() => new List<GuardianNames>
    {
        new GuardianNames("Chris Pratt", "Starlord", "chris.png"),
        new GuardianNames("Zoe Seldena", "Gamora", "gamora.jpeg"),
        new GuardianNames("Vin Diesel", "Groot", "groot.webp"),
        new GuardianNames("Bradlet Cooper", "Rocket", "rocket.png"),
        new GuardianNames("Karen Gillan", "Nebula", "nebula.png")
     };
}
