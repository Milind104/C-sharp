using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RealEstateApp.Models;
using RealEstateApp.ViewModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.ViewModels
{
    public partial class RealStatePropertyDetailViewModel : BaseViewModel, IRealStatePropertyDetailViewModel, IQueryAttributable
    {
        [ObservableProperty] private RealStateProperty _realStateProperty;

        public RealStatePropertyDetailViewModel()
        {
            
        }


        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            RealStateProperty = query["RealStateProperty"] as RealStateProperty;

        }
        [RelayCommand]
        private async void NavigateToAgentProfile(Agent agentProfile)
        {
            var navigationParameter = new Dictionary<string, object>
            {
                { "AgentProfile", agentProfile }
            };
            await Shell.Current.GoToAsync("AgentProfilePage", navigationParameter);
        }
    }
}
