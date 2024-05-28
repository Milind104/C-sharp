using MauiApp6.MVVM.ViewModels;

namespace MauiApp6.MVVM.Views;

public partial class CalcView : ContentPage
{
	public CalcView()
	{
		InitializeComponent();
		BindingContext = new CalcViewModel();
	}
}