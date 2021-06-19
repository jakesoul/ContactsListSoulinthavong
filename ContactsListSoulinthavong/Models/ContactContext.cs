using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsListSoulinthavong.Models
{
    public class ContactContext : DbContext

    {
        public ContactContext(DbContextOptions<ContactContext> options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactId = 1,
                    FirstName = "Iridian",
                    LastName = "Lopez",
                    PhoneNumber = 5151234567,
                    EmailAddress = "imarquezlopez@bankerstrust.com"
                },
                new Contact
                {
                    ContactId = 2,
                    FirstName = "Jason",
                    LastName = "Soulinthavong",
                    PhoneNumber = 5159876543,
                    EmailAddress = "jsoulinthavong@yahoo.com"
                },
                new Contact
                {
                    ContactId = 3,
                    FirstName = "Penelope",
                    LastName = "Soulinthavong",
                    PhoneNumber = 5150001111,
                    EmailAddress = "nellie.soul@gmail.com"
                }
            );
        }
    }
}
