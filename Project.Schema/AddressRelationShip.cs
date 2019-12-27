using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Schema
{
    public class AddressRelationShip : IDBColumns
    {
        public Guid AddressID { get; set; }
        public Guid ExternalTypeID { get; set; }

        public Guid ID { get; set; }
        public bool Active { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Guid CompanyID { get; set; }
        public Guid InstanceID { get; set; }
    }
}
