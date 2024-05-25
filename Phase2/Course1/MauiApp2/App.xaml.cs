namespace MauiApp2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var navPage = new NavigationPage(new MainPage());
            navPage.BarBackground = Colors.Purple;
            navPage.BarTextColor = Colors.White;

            MainPage = navPage;
        }
    }
}
