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

        private void SLayoutBtn_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HStackDemo());

        }
        private void GridBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GridDemo());
        }

        private void CalcBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CalcDemo());
        }

        private void FlexBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FlexDemo());
        }

        private void AbsoluteBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AbsoluteDemo());
        }
    }

}
