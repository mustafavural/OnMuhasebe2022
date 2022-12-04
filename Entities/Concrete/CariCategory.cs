using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class CariCategory : IEntity
    {
        public int Id { get; set; }
        public string Ad { get; set; }


        public virtual List<CariGrup>? CariGruplar { get; set; }

        public CariCategory()
        {
            CariGruplar = new();
        }
    }
}