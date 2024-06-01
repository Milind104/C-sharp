namespace MonkeyFinder
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //var NavePage = new NavigationPage(new MainPage());

            MainPage = new AppShell();
        }
    }
}
