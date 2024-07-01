using E_CommerceApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceApp.ViewModel
{
    public class HomePageViewModel : BaseViewModel
    {

        public ObservableCollection<CategoriesModel> _CategoriesDataList = new ObservableCollection<CategoriesModel>();
        public ObservableCollection<CategoriesModel> CategoriesDataList
        {
            get
            {
                return _CategoriesDataList;
            }
            set
            {
                _CategoriesDataList = value;
                OnPropertyChanged("CategoriesDataList");
            }
        }
        public HomePageViewModel()
        {
            PopulateData();
        }

        void PopulateData()
        {
            CategoriesDataList.Clear();
            CategoriesDataList.Add(new CategoriesModel() { CategoryID = 1, CategoryName = "Men", Icon = "\ufb22" });
            CategoriesDataList.Add(new CategoriesModel() { CategoryID = 2, CategoryName = "Women", Icon = "\ufb23" });
            CategoriesDataList.Add(new CategoriesModel() { CategoryID = 2, CategoryName = "Devices", Icon = "\uf322" });
            CategoriesDataList.Add(new CategoriesModel() { CategoryID = 2, CategoryName = "Gadgets", Icon = "\uf2cb" });
            CategoriesDataList.Add(new CategoriesModel() { CategoryID = 2, CategoryName = "Games", Icon = "\uf5ba" });
        }
    }
}