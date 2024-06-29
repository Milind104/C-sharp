using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RealEstateApp.Models;
using RealEstateApp.Services;
using RealEstateApp.ViewModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.ViewModels
{
    public partial class AgentProfileViewModel : BaseViewModel, IAgentProfileViewModel, IQueryAttributable
    {
        private readonly IRealStatePropertyServices _realStatePropertyServices;
        [ObservableProperty] private Agent _agentProfile;
        [ObservableProperty] private ObservableCollection<RealStateProperty> _agentListings;

        public AgentProfileViewModel(IRealStatePropertyServices realStatePropertyServices)
        {
            _realStatePropertyServices = realStatePropertyServices;

        }
        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            AgentProfile = query["AgentProfile"] as Agent;
            LoadData();
        }

        private void LoadData()
        {
            AgentListings = new ObservableCollection<RealStateProperty>(_realStatePropertyServices.GetAgentProperties(AgentProfile.Id));
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