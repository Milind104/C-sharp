using CommunityToolkit.Mvvm.ComponentModel;
using RealEstateApp.Models;
using RealEstateApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.ViewModels
{
    public partial class MainViewModel :ObservableObject
    {
        private readonly IHouseServices _houseServices;

        [ObservableProperty]
        private ObservableCollection<Category> _categories;

        public MainViewModel( IHouseServices houseServices)
        {
            _houseServices = houseServices;
            LoadData();
        }

        private void LoadData()
        {
            Categories = new ObservableCollection<Category>(_houseServices.GetCategories());
        }
    }
}
