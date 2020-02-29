using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NotebookApi1.Models
{
    public class Contact : BaseEntity
    {
        /*
        Contact()
        {
            Person = new Person();
            ContactType = new ContactType();
        }

        public Contact(string value, int? personId, int? contactTypeId)
        {
            Value = value;
            PersonId = personId;
            Person = new Person();
            ContactTypeId = contactTypeId;
            ContactType = new ContactType();
        }*/

        public string Value { get; set; }

        public int? PersonId { get; set; }
        [JsonIgnore]
        public virtual Person Person { get; set; }

        public int? ContactTypeId { get; set; }
        [JsonIgnore]
        public virtual ContactType ContactType { get; set; }
    }
}