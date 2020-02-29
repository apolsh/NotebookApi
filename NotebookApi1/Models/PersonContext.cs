using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NotebookApi1.Models
{
    public class PersonContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<ContactType> ContactType { get; set; }
    }

}