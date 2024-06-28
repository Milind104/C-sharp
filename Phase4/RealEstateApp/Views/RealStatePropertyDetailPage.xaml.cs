using RealEstateApp.ViewModels;
using RealEstateApp.ViewModels.Interfaces;

namespace RealEstateApp.Views;

public partial class RealStatePropertyDetailPage : ContentPage
{
    public RealStatePropertyDetailPage(IRealStatePropertyDetailViewModel viewModel)
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(AgentProfilePage), typeof(AgentProfilePage));
        BindingContext = viewModel;
    }

    private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
}
