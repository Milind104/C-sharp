using MonkeyFinder.ViewModel;

namespace MonkeyFinder;

public partial class MainPage : ContentPage
{
	public MainPage(MonkeysViewModel monkeysViewModel)
	{
		InitializeComponent();
		BindingContext = monkeysViewModel;

	}

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
		var monkey = ((VisualElement)sender).BindingContext as Model.Monkey;
		if (monkey == null)
			return;

        await Shell.Current.GoToAsync(nameof(View.DetailsPage), true, new Dictionary<string, object>
    {
        {"Monkey", monkey }
    });

    }
}
