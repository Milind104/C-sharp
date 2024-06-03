using Contacts.Views;

namespace Contacts
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(ContactsPage),typeof(ContactsPage));
            Routing.RegisterRoute(nameof(AddContactPage),typeof(AddContactPage));
            Routing.RegisterRoute(nameof(EditContactPage),typeof(EditContactPage));
        }
    }
}
