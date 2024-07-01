using E_CommerceApp.ViewModel;

namespace E_CommerceApp.VIews;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
        BindingContext = new HomePageViewModel();
    }
}