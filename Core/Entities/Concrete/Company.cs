using Core.Entities.Abstract;

namespace Core.Entities.Concrete
{
    public class Company : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public string Year { get; set; }
        public string Detail { get; set; }
    }
}