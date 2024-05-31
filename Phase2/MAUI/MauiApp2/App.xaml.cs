namespace MauiApp2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var NavPage = new NavigationPage(new MainPage());
            NavPage.BarBackground = Colors.Brown;
            NavPage.BarTextColor = Colors.GreenYellow;
            //MainPage= new DemoPage();

            MainPage = new CollectionControl();
        }
    }
}
