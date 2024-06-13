using MAUINewsApp.Views;

namespace MAUINewsApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("article", typeof(ArticlePage));

            this.HomeTab.Icon = ImageSource.FromResource("MAUINewsApp.Resource.Images.home.png",this.GetType().Assembly);
            this.SectionsTab.Icon = ImageSource.FromResource("MAUINewsApp.Resource.Images.categories.png", this.GetType().Assembly);
            this.BookmarksTab.Icon = ImageSource.FromResource("MAUINewsApp.Resource.Images.bookmarks.png", this.GetType().Assembly);
            this.ProfileTab.Icon = ImageSource.FromResource("MAUINewsApp.Resource.Images.profile.png", this.GetType().Assembly);
        }
    }
}
