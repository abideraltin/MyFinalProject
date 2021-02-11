using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Order :IEntity
    {
        public int OrdeId { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipCity { get; set; }

    }
}
