using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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
    public partial class MainViewModel : BaseViewModel
    {
        private readonly IRealStatePropertyServices _realStatePropertyServices;
        [ObservableProperty] private ObservableCollection<Category> _categories;
        [ObservableProperty] private ObservableCollection<RealStateProperty> _recommendations;

        public MainViewModel(IRealStatePropertyServices realStatePropertyServices)
        {
            _realStatePropertyServices = realStatePropertyServices;
            LoadData();
        }

        private void LoadData()
        {
            Categories = new ObservableCollection<Category>(_realStatePropertyServices.GetCategories());
            Recommendations = new ObservableCollection<RealStateProperty>(_realStatePropertyServices.GetRealStateProperties());
        }
        [RelayCommand]
        private async Task NavigateToDetail(RealStateProperty property)
        {
            var navigationParameter = new Dictionary<string, object>
            {
                { "RealStateProperty", property }
            };
            await Shell.Current.GoToAsync($"RealStatePropertyDetailPage", navigationParameter);
        }
    }
}
