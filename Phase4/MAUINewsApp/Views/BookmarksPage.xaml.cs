using MAUINewsApp.Services;
using MAUINewsApp.ViewModels;

namespace MAUINewsApp.Views;

public partial class BookmarksPage : ContentPage
{
	public BookmarksPage(INewsService news)
	{
		InitializeComponent();
        this.BindingContext = new BookmarksViewModel(news);
    }
}