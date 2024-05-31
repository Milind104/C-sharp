using MauiApp1.MVVM.Models;
using MauiApp1.MVVM.ViewModels;

namespace MauiApp1.MVVM.Views;

public partial class ProductPage : ContentPage
{
	public ProductPage()
	{
		InitializeComponent();


		BindingContext = new ProductViewModel();
	}
}