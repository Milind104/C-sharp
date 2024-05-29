using MauiApp7.MVVM.ViewModels;

namespace MauiApp7.MVVM.Views;

public partial class PageOne : ContentPage
{
	public PageOne()
	{
		InitializeComponent();

		BindingContext = new PageOneViewModel();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		//Navigation.PushAsync(new PageTwo());
		var theData =((PageOneViewModel)BindingContext).Data;

		Navigation.PushAsync(new PageTwo
		{
			BindingContext = new PageTwoViewModel { Data= theData},
		});

    }
}