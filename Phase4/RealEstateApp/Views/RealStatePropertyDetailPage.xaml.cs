using RealEstateApp.ViewModels;

namespace RealEstateApp.Views;

public partial class RealStatePropertyDetailPage : ContentPage
{
	public  RealStatePropertyDetailPage()
	{
		InitializeComponent();
        BindingContext = MauiProgram.GetService<RealStatePropertyDetailViewModel>();
    }
}