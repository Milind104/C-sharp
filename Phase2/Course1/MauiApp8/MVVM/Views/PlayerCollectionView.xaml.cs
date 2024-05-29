using MauiApp8.MVVM.ViewModels;

namespace MauiApp8.MVVM.Views;

public partial class PlayerCollectionView : ContentPage
{
	public PlayerCollectionView()
	{
		InitializeComponent();
		BindingContext= new PlayerViewModel();
	}
}