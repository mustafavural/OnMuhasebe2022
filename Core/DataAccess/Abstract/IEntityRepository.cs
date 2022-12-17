using Core.Entities.Abstract;
using System.Linq.Expressions;

namespace Core.DataAccess.Abstract
{
    public interface IEntityRepository<TEntity> where TEntity : class, IEntity, new()
    {
        TEntity Get(Expression<Func<TEntity, bool>> filter);

        List<TEntity> GetList(Expression<Func<TEntity, bool>>? filter = null);

        void Add(TEntity entity);

        void Delete(TEntity entity);

        void Update(TEntity entity);
    }
}