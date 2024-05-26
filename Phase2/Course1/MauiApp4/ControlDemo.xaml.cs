namespace MauiApp4;

public partial class ControlDemo : ContentPage
{
    public ControlDemo()
    {
        InitializeComponent();
        BindingContext = new PlayerViewModel();
    }

    private void imgBtn_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Alert", "You clicked the image", "OK");
    }

    private void btn_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Alert", "You clicked the button", "OK");
    }

    private void searchBar_SearchButtonPressed(object sender, EventArgs e)
    {
        infoLabel.Text = $"Searching for {searchBar.Text}";
    }

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        RadioButton sexBtn = sender as RadioButton;
        infoLabel.Text = $"I see you are {sexBtn.Content}";
    }

    private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        infoLabel.Text = $"Clicked Checkbox {e.Value}";
    }

    private void Switch_Toggled(object sender, ToggledEventArgs e)
    {
        infoLabel.Text = $"Clicked Toggle {e.Value}";
    }

    private void SwipeItem_Invoked(object sender, EventArgs e)
    {
        infoLabel.Text = $"Marked as Favorite";
    }

    private void SwipeItem_Invoked_1(object sender, EventArgs e)
    {
        infoLabel.Text = $"Marked as Delete";
    }

    private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        sliderLabel.Text = $"People Attending {Convert.ToInt32(slider.Value)}";
    }

    private void stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        stepperLabel.Text = $"People Paying {Convert.ToInt32(stepper.Value)}";
    }

    private void entry_Completed(object sender, EventArgs e)
    {
        infoLabel.Text = $"Hello {entry.Text}";
    }

    private void Steelers_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        string player = "", playerData = "";

        switch (e.SelectedItem)
        {
            case ListModel m when m.Name.StartsWith("Cameron"):
                player = "Cameron Heyward";
                playerData = "Five-time Pro Bowler (2018, 2019, 2020, 2021, 2022)";
                break;
            case ListModel m when m.Name.StartsWith("George"):
                player = "George Pickens";
                playerData = "A vertical receiver who dominates opponents with size and great hands";
                break;

            case ListModel m when m.Name.StartsWith("Kenny"):
                player = "Kenny Pickett";
                playerData = "Pitt's all-time leader in passing yards (12,303), pass completions (1,045), total offense (13,112), touchdown responsibility (102) and passing touchdowns (81)";
                break;

            case ListModel m when m.Name.StartsWith("Minkah"):
                player = "Minkah Fitzpatrick";
                playerData = "314 tackles (212 solo), 33 passes defensed, 13 interceptions, 5 tackles for loss, 4 fumble recoveries, four forced fumbles, 3 interception returns for TDs";
                break;

            case ListModel m when m.Name.StartsWith("Najee"):
                player = "Najee Harris";
                playerData = "1,200 rushing yards and seven rushing touchdowns on 307 attempts and added 74 catches for 397 receiving yards and three recieving touchdowns as a rookie";
                break;

            case ListModel m when m.Name.StartsWith("TJ"):
                player = "TJ Watt";
                playerData = "Led the NFL with 22.5 sacks (despite missing 2 full games and portions of 4 others), tied with Pro Football Hall of Famer Michael Strahan (22.5 sacks in 2001) for the most in a season";
                break;
        }
        DisplayAlert($"{player}", $"{playerData}", "OK");
    }
}