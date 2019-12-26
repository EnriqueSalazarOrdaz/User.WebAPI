using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Schema
{
    public interface IDBColumns
    {
        Guid ID { get; set; }
        bool Active { get; set; }
        DateTime CreationDate { get; set; }
        DateTime DeleteDate { get; set; }
        Guid CompanyID { get; set; }
        Guid InstanceID { get; set; }
    }
}
