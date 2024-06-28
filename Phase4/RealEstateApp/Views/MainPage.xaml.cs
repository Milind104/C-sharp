using RealEstateApp.ViewModels;
using RealEstateApp.ViewModels.Interfaces;

namespace RealEstateApp.Views
{
    public partial class MainPage : ContentPage
    {

        public MainPage(IMainViewModel viewModel)
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(RealStatePropertyDetailPage), typeof(RealStatePropertyDetailPage));
            BindingContext = viewModel;
        }

        private void CollectionView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is CollectionView collectionView) collectionView.SelectedItem = null;
        }
    }
}
    