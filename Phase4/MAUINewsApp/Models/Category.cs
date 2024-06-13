using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUINewsApp.Models
{
    public class Category
    {
        public string Name { get; set; }

        public string MaterialIcon { get; set; }

        public Category(string name, string icon)
        {
            this.Name = name;
            this.MaterialIcon = icon;
        }
    }
}
