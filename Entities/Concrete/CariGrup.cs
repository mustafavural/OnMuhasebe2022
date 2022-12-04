using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class CariGrup : IEntity
    {
        public int Id { get; set; }
        public int CariId { get; set; }
        public int CariCategoryId { get; set; }


        public virtual CariCategory? CariCategory { get; set; }
        public virtual Cari? Cari { get; set; }
    }
}