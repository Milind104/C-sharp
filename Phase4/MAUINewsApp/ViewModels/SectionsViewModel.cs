using MAUINewsApp.Models;
using MAUINewsApp.Services;
using MAUINewsApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUINewsApp.ViewModels
{
    public class SectionsViewModel
    {
        public SectionsViewModel(INewsService news)
        {
            this.Sections = news.GetCategories();
        }

        public ICollection<Category> Sections { get; set; }
    }
}
