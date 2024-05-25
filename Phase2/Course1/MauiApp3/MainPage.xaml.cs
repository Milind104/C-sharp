namespace MauiApp3
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void SLayoutBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StackDemo());
        }
    }

}
