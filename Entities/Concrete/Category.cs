using Core.Entities;

namespace Entities.Concrete
{
    //Çıplak class kalmasın
    public class Category : IEntity
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}