namespace MauiApp7.MVVM.Views;

public partial class PageTwo : ContentPage
{
	public PageTwo()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PageOne());
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PageThree());
    }
}