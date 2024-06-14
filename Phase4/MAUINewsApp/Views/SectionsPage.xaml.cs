using MAUINewsApp.Services;
using MAUINewsApp.ViewModels;

namespace MAUINewsApp.Views;

public partial class SectionsPage : ContentPage
{
	public SectionsPage(INewsService news)
    {
		InitializeComponent();
        this.BindingContext = new SectionsViewModel(news);
    }
}