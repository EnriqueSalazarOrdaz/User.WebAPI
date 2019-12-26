using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Schema
{
    public class User : IDBColumns
    {
        
        public string Name { get; set; }
        public List<Address> Address { get; set; }
        

        public Guid ID { get; set; }
        public bool Active { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime DeleteDate { get; set; }
        public Guid CompanyID { get; set; }
        public Guid InstanceID { get; set; }
    }
}
