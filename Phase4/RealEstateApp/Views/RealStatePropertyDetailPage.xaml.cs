using RealEstateApp.ViewModels;
using RealEstateApp.ViewModels.Interfaces;


namespace RealEstateApp.Views
{
    public partial class RealStatePropertyDetailPage : ContentPage
    {

        public RealStatePropertyDetailPage()
        {
            InitializeComponent();
        }
        public RealStatePropertyDetailPage(IRealStatePropertyDetailViewModel viewModel) : this()
        {
            Routing.RegisterRoute(nameof(AgentProfilePage), typeof(AgentProfilePage));
            BindingContext = viewModel;
        }

        private async void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            try
            {
                await Shell.Current.GoToAsync("..");
            }
            catch (Exception ex)
            {
                // Log the exception or display a message to the user
                Console.WriteLine($"Navigation error: {ex.Message}");
                await DisplayAlert("Error", "Unable to navigate back. Please try again.", "OK");
            }
        }
    }
}
