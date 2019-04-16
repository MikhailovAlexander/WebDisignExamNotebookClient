using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace NotebookAPI.Models
{
    public class Person : BaseEntity
    {
        public Person()
        {
            Contacts = new List<Contact>();
        }

        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public DateTime BirthDay { get; set; }

        [JsonIgnore]
        public virtual ICollection<Contact> Contacts { get; set; }

    }
}