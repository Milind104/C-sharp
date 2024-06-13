using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUINewsApp.Models
{
    public class Article
    {
        

        public string Title { get; }

        public string Subtitle { get; }

        public string ImageURL { get; }

        public string Category { get; }

        public string Time { get; }

        public Article( string title, string subtitle, string imageUrl, string category, string time)
        {
            
            this.Title = title;
            this.Subtitle = subtitle;
            this.ImageURL = imageUrl;
            this.Category = category;
            this.Time = time;
        }
    }
}
