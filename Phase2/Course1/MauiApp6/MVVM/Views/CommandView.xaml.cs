using MauiApp6.MVVM.ViewModels;

namespace MauiApp6.MVVM.Views;

public partial class CommandView : ContentPage
{
	public CommandView()
	{
		InitializeComponent();
		BindingContext = new CommandViewModel();
	}
}