using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Sehir : IEntity
    {
        public int Id { get; set; }
        public string Ad { get; set; }

        public virtual List<Ilce> Ilceler { get; set; }

        public Sehir()
        {
            Ilceler = new();
        }
    }
}