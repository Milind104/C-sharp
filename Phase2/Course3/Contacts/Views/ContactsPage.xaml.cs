namespace Contacts.Views;

public partial class ContactsPage : ContentPage
{
	public ContactsPage()
	{
		InitializeComponent();

		List<Contact> contacts = new List<Contact>()
		{
			new Contact{Name="Poorav Patel",Email="poorav@gmail.com"},
            new Contact{Name="Krunal Patel",Email="krunal@gmail.com"},
            new Contact{Name="Anurag Ganvit",Email="anurag@gmail.com"},
            new Contact{Name="Gaurang Ganvit",Email="Gaurang@gmail.com"},
        };



		listContact.ItemsSource = contacts;
	}

    public class Contact
    {
		public string Name {  get; set; }
		public string Email { get; set; }
    }

    private void listContact_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (listContact.SelectedItem != null) 
        {
            //logic
            DisplayAlert("Test", "test", "ok");
        }
        
    }

    private void listContact_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        listContact.SelectedItem = null;
    }
}