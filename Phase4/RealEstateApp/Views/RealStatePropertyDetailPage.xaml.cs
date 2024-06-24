using RealEstateApp.ViewModels;

namespace RealEstateApp.Views;

public partial class RealStatePropertyDetailPage : ContentPage
{
	public  RealStatePropertyDetailPage()
	{
		InitializeComponent();
        BindingContext = MauiProgram.GetService<RealStatePropertyDetailViewModel>();
    }
    private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
}