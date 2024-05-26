namespace MauiApp4;

using System.Collections.ObjectModel;

public class PlayerViewModel
{
    public ObservableCollection<ListModel> MyPlayers { get; set; } = new ObservableCollection<ListModel>{
        new ListModel
        {
            Name= "Cameron Heyward", Image="cameron_heyward.png"
        },
        new ListModel
        {
            Name= "George Pickens", Image="george_pickens.png"
        },
        new ListModel
        {
            Name= "Kenny Pickett", Image="kenny_pickett.png"
        },
        new ListModel
        {
            Name= "Minkah Fitzpatrick", Image="minkah_fitzpatrick.png"
        },
        new ListModel
        {
            Name= "Najee Harris", Image="najee_harris.png"
        },
        new ListModel
        {
            Name= "TJ Watt", Image="tj_watt.png"
        },
    };

    public Command<ListModel> DeletePlayer { get; private set; }

    public PlayerViewModel()
    {
        DeletePlayer = new Command<ListModel>(model =>
        {
            MyPlayers.Remove(model);
        });
    }
}