namespace MauiApp3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var Navpage = new NavigationPage(new MainPage());
            Navpage.BarBackground=Colors.Green;
            Navpage.BarTextColor=Colors.White;
            /*MainPage = new DataBinding();*/
            // MainPage = new ModesExample();
            MainPage = new INotifyChanged();



            
        }
    }
}
