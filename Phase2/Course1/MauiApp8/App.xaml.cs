using MauiApp8.MVVM.Views;

namespace MauiApp8;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new PlayerCollectionView();
    }
}