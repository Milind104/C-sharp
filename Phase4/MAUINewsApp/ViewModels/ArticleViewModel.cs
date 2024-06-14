using MAUINewsApp.Models;
using MAUINewsApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUINewsApp.ViewModels
{
    public class ArticleViewModel
    {
        public ArticleViewModel(INewsService news, Article a)
        {
            this.Title = a.Title;
            this.ImageURL = a.ImageURL;
            this.Body = news.GetArticleBody(a.Id);
        }

        public string Title { get; set; }

        public string ImageURL { get; set; }

        public string Body { get; set; }
    }
}
