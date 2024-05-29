namespace MauiApp7.MVVM.Views;

public partial class PageThree : ContentPage
{
	public PageThree()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PageTwo());

    }
}