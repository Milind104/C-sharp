using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Models
{
    public static class ContactRepository
    {
        public static List<Contact> _contacts = new List<Contact>()
        {
            new Contact{ContactId=1, Name="Poorav Patel",Email="poorav@gmail.com"},
            new Contact{ ContactId=2,Name="Krunal Patel",Email="krunal@gmail.com"},
            new Contact{ContactId=3,Name="Anurag Ganvit",Email="anurag@gmail.com"},
            new Contact{ContactId = 4, Name="Gaurang Ganvit",Email="Gaurang@gmail.com"},
        };

        public static List <Contact> GetContacts() => _contacts;

        public static Contact GetContactById(int contactId)
        {

            return _contacts.FirstOrDefault(x=>x.ContactId==contactId); 
        }
    

    }
}
