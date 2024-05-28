using MauiApp6.MVVM.ViewModels;

namespace MauiApp6.MVVM.Views;

public partial class CustomersView : ContentPage
{
	public CustomersView()
	{
		InitializeComponent();
        BindingContext = new CustomersViewModel();
    }
}