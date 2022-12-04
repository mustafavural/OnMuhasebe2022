using Core.Entities.Abstract;

namespace Core.Entities.Concrete
{
    public class UserCompany : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CompanyId { get; set; }
    }
}
