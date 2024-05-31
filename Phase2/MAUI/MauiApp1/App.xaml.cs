using MauiApp1.MVVM.Views;

namespace MauiApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var NavPage= new NavigationPage(new MainPage());
            NavPage.BarBackground = Colors.Brown;
            NavPage.BarTextColor= Colors.GreenYellow;
            //MainPage= new DemoPage();
            //MainPage = new FlyoutPageDemo();
            //MainPage= new TabbedPageDemo();
            //MainPage= new StackLayoutPageDemo();
            //MainPage =new GridPageDemo();
            //MainPage=new AbsoluteLayoutDemo();
            // MainPage=new ResourcesExample();
            //MainPage = new DataBinding();
            //MainPage = new ModesExample();
            MainPage = new ProductPage();
        }
    }
}
