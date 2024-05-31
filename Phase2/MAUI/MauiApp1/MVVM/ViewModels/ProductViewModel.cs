using MauiApp1.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.MVVM.ViewModels
{
    public class ProductViewModel
    {
        public Product Product { get; set; }
        public ProductViewModel()
        {
            Product = new Product()
            {
                Title = "Samsung",
                Description = "Samsung S24"
            };
        }
    }
}
