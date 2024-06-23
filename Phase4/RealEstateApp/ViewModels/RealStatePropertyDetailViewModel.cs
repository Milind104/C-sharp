using CommunityToolkit.Mvvm.ComponentModel;
using RealEstateApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.ViewModels
{
    public partial class RealStatePropertyDetailViewModel : BaseViewModel, IQueryAttributable
    {
        [ObservableProperty] private RealStateProperty _realStateProperty;

        public RealStatePropertyDetailViewModel()
        {
            var a = 0;
        }


        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            RealStateProperty = query["RealStateProperty"] as RealStateProperty;

        }
    }
}
