using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NotebookApi1.Models
{
    public class Person : BaseEntity
    {
        public Person()
        {
            Contacts = new List<Contact>();
        }

        public Person(string firstname, string secondname, DateTime birthday)
        {
            Contacts = new List<Contact>();
            Firstname = firstname;
            Secondname = secondname;
            BirthDay = birthday;
        }

        public string Firstname { get; set; }
        public string Secondname { get; set; }
        public DateTime BirthDay { get; set; }

        [JsonIgnore]
        public virtual ICollection<Contact> Contacts { get; set; }

    }
}