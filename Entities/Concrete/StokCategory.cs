using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class StokCategory : IEntity
    {
        public int Id { get; set; }
        public string Ad { get; set; }


        public virtual List<StokGrup>? StokGruplar { get; set; }

        public StokCategory()
        {
            StokGruplar = new();
        }
    }
}