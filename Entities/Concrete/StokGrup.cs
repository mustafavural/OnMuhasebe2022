using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class StokGrup : IEntity
    {
        public int Id { get; set; }
        public int StokId { get; set; }
        public int StokCategoryId { get; set; }


        public virtual StokCategory? StokCategory { get; set; }
        public virtual Stok? Stok { get; set; }
    }
}