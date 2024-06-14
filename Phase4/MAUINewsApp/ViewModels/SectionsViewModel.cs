using MAUINewsApp.Models;
using MAUINewsApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUINewsApp.ViewModels
{
    public  class SectionsViewModel
    {
        public SectionsViewModel()
        {
            this.Sections = new List<Category>()
            {
                new Category("Health",MaterialDesignIcons.Spa),
                new Category("Politics",MaterialDesignIcons.AccountBalance),
                new Category("Business",MaterialDesignIcons.Work),
                new Category("Music",MaterialDesignIcons.MusicNote),
                new Category("Marketing",MaterialDesignIcons.Store),
                new Category("Nature",MaterialDesignIcons.LocalFlorist),
                new Category("Arts",MaterialDesignIcons.ColorLens),
                new Category("Travel",MaterialDesignIcons.FlightTakeoff),
                new Category("Food",MaterialDesignIcons.Restaurant),
                new Category("Style",MaterialDesignIcons.Style),

            };
        }

        public List<Category> Sections { get; set; }
    }
}
