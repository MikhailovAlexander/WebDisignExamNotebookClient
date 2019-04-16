using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NotebookAPI.Models
{
    public class Contact : BaseEntity
    {
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
        public int ContactTypeId { get; set; }
        public virtual ContactType ContactType { get; set; }
        public string Value { get; set; }
    }
}