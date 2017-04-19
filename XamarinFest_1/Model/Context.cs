using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using XamarinFest_1.Dialogs;

namespace XamarinFest_1.Model
{
    public class Context : DbContext
    {
        public Context() : base("---CONNECTION STRING---")
        {
        }

        public DbSet<Order> Orders { get; set; }
        
    }

    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Company { get; set; }
        public string Role { get; set; }
        public string Contact { get; set; }
        public string Impressions { get; set; }

        public Order() { }
        public Order(MonkeyOrder mo)
        {
            this.Name = mo.Name;
            this.LastName = mo.LastName;
            this.DateOfBirth = mo.DateOfBirth;
            this.Company = mo.Company;
            this.Role = mo.Role.ToString();
            this.Contact = mo.Contact.ToString();
            this.Impressions = mo.Impressions;
        }
    }
}