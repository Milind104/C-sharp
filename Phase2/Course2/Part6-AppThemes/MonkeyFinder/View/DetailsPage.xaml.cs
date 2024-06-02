namespace MonkeyFinder.View;

public partial class DetailsPage : ContentPage
{
	public DetailsPage( ViewModel.MonkeyDetailsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}