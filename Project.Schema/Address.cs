using Project.Schema.Enums;
using System;

namespace Project.Schema
{
    public class Address : IDBColumns
    {
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public EnumAddressType EnumAddressType { get; set; }
        
        
        public Guid ID { get; set; }
        public bool Active { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime DeleteDate { get; set; }
        public Guid CompanyID { get; set; }
        public Guid InstanceID { get; set; }
    }
}