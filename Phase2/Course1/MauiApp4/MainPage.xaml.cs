namespace MauiApp4
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private void ControlBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ControlDemo());
        }
    }

}
