using RealEstateApp.ViewModels;

namespace RealEstateApp.Views
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
            BindingContext = MauiProgram.GetService<MainViewModel>();
        }

       
    }

}
