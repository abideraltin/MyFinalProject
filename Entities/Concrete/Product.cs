using Core.Entities;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}