using Contacts.Models;
using static Microsoft.Maui.ApplicationModel.Permissions;
using System.Net;
using System.Xml.Linq;

namespace Contacts.Views
{
    public partial class AddContactPage : ContentPage
    {
        public AddContactPage()
        {
            InitializeComponent();
        }

        private void btnCancel_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync($"//{nameof(ContactsPage)}");
        }

        private void contactCtrl_OnSave(object sender, EventArgs e)
        {
            ContactRepository.AddCotact(new Models.Contact

            {
                Name = contactCtrl.Name,
                Email = contactCtrl.Email,
                Address = contactCtrl.Address,
                Phone = contactCtrl.Phone,

            });
        }

        private void contactCtrl_OnCancel(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync($"//{nameof(ContactsPage)}");
        }

        private void contactCtrl_OnError(object sender, string e)
        {
            DisplayAlert("Error", e, "OK");
        }
    }
}
