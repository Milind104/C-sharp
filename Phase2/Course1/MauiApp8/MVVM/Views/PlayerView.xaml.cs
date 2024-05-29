using MauiApp8.MVVM.ViewModels;

namespace MauiApp8.MVVM.Views;

public partial class PlayerView : ContentPage
{
	public PlayerView()
	{
		InitializeComponent();
		BindingContext = new PlayerViewModel();
	}
}