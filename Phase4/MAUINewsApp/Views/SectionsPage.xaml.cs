using MAUINewsApp.ViewModels;

namespace MAUINewsApp.Views;

public partial class SectionsPage : ContentPage
{
	public SectionsPage()
	{
		InitializeComponent();
        this.BindingContext = new SectionsViewModel();
    }
}