using MAUINewsApp.Models;
using MAUINewsApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUINewsApp.ViewModels
{
    public class BookmarksViewModel
    {
        public BookmarksViewModel(INewsService news)
        {
            this.Articles = news.GetBookmarkedArticles();

            this.TappedCommand = new Command<Article>((article) =>
            {
                var query = new Dictionary<string, object>()
                {
                    { "article", article }
                };
                Shell.Current.GoToAsync("//bookmarks/article", query);
            });
        }

        public ICollection<Article> Articles { get; set; }

        public Command TappedCommand { get; set; }
    }
}
