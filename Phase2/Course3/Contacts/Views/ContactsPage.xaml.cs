using Contacts.Models;
using Contact = Contacts.Models.Contact;

namespace Contacts.Views;

public partial class ContactsPage : ContentPage
{
	public ContactsPage()
	{
		InitializeComponent();
        
        List<Contact> contacts=ContactRepository.GetContacts();
		listContact.ItemsSource = contacts;
	}
    private async void listContact_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (listContact.SelectedItem != null) 
        {
            //logic
            await Shell.Current.GoToAsync($"{nameof(EditContactPage)}?Id={((Contact)listContact.SelectedItem).ContactId}");
            
        }
        
    }

    private void listContact_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        listContact.SelectedItem = null;
    }
}