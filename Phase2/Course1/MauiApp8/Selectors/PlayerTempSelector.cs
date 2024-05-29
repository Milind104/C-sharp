using MauiApp8.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp8.Selectors
{
    public class PlayerTempSelector : DataTemplateSelector
    {
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var player = item as Player;
            if (!player.InProBowl) {
                Application
                    .Current
                    .Resources
                    .TryGetValue("PlayerCarouselStyle", out var playerStyle);
                return playerStyle as DataTemplate;
            } else
            {
                Application
                    .Current
                    .Resources
                    .TryGetValue("ProBowlCarouselStyle", out var proBowlStyle);
                return proBowlStyle as DataTemplate;
            }
        } 
    }
}
