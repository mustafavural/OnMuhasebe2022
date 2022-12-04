using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Kasa : IEntity
    {
        public int Id { get; set; }
        public string Ad { get; set; }
    }
}