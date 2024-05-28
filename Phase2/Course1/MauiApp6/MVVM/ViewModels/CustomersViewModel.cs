using MauiApp6.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp6.MVVM.ViewModels
{
    class CustomersViewModel
    {
        public List<Customer> Customers { get; set; } = new List<Customer>();

        public CustomersViewModel() {
            Customers.Add(new Customer()
            {
                Name = "Fred Flintstone",
                Street = "222 Rocky Way",
                City = "Bedrock",
                State = "LA",
                ZipCode = 70777,
                Phone = "800-555-1212",
                BirthDay= new DateTime(2000,2,2),
                ContactTime= new TimeSpan(12,0,0),
                Balance = 0,
                ActiveCustomer = true
            });
            Customers.Add(new Customer()
            {
                Name = "Wilma Flintstone",
                Street = "345 Stonecave Road",
                City = "Bedrock",
                State = "LA",
                ZipCode = 70777,
                Phone = "800-555-1212",
                BirthDay = new DateTime(2000, 2, 2),
                ContactTime = new TimeSpan(12, 0, 0),
                Balance = 0,
                ActiveCustomer = true
            });
            Customers.Add(new Customer()
            {
                Name = "Barney Rubble",
                Street = "142 Boulder Avenue",
                City = "Granitetown",
                State = "LA",
                ZipCode = 70777,
                Phone = "800-555-1212",
                BirthDay = new DateTime(2000, 2, 2),
                ContactTime = new TimeSpan(12, 0, 0),
                Balance = 0,
                ActiveCustomer = true
            });
            Customers.Add(new Customer()
            {
                Name = "Bettie Rubble",
                Street = "142 Boulder Avenue",
                City = "Granitetown",
                State = "LA",
                ZipCode = 70777,
                Phone = "800-555-1212",
                BirthDay = new DateTime(2000, 2, 2),
                ContactTime = new TimeSpan(12, 0, 0),
                Balance = 0,
                ActiveCustomer = true
            });
        }
    }
}
