using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp6.MVVM.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDay { get; set; }
        public TimeSpan ContactTime { get; set;}
        public double Balance { get; set; }
        public bool ActiveCustomer { get; set; }
    }
}
