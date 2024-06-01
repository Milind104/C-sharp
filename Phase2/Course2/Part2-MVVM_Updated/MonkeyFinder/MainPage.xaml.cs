using MonkeyFinder.ViewModel;

namespace MonkeyFinder;

public partial class MainPage : ContentPage
{
	public MainPage(MonkeysViewModel monkeysViewModel)
	{
		InitializeComponent();
		BindingContext = monkeysViewModel;

	}
}
