using DaluiApp.Views;

namespace DaluiApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new GenerationOptionsView();
        }
    }
}
