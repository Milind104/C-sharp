using MAUINewsApp.Services;
using MAUINewsApp.ViewModels;

namespace MAUINewsApp.Views;

public partial class HomePage : ContentPage
{
	public HomePage(INewsService news)
    {
		InitializeComponent();
        this.BindingContext = new HomeViewModel(news);
    }
}