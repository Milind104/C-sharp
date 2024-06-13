using MAUINewsApp.ViewModels;

namespace MAUINewsApp.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
		this.BindingContext = new HomeViewModel();
	}
}