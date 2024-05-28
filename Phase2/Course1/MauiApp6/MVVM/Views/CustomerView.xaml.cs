using MauiApp6.MVVM.ViewModels;

namespace MauiApp6.MVVM.Views;

public partial class CustomerView : ContentPage
{
	public CustomerView()
	{
		InitializeComponent();

		BindingContext = new CustomerViewModel();
	}
}