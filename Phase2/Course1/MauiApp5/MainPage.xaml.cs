using MauiApp5.Models;

namespace MauiApp5;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		var cameron = new Player
		{
			Name = "Cameron Heyward",
			Info = "Five-time Pro Bowler (2018, 2019, 2020, 2021, 2022)"
		};

		
		// Creates the binding
		Binding playerBinding= new Binding();

		// Defines the data source
		playerBinding.Source= cameron;

		// Defines the name of the property that is shared 
		// between the source and control
		playerBinding.Path = "Name";

	    lblName.SetBinding(Label.TextProperty, playerBinding);

		BindingContext = cameron;
	}
}
