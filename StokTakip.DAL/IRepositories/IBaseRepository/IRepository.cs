using StokTakip.DAL.IRepositories.IBaseRepository;
using StokTakip.Entity.Model;

namespace StokTakip.DAL.IRepositories.IBaseRepository
{
    internal interface IRepository<TEntity,TKey>:IAdd<TEntity>,
        IDelete<TEntity>,
        IDeleteById<TKey>,
        IDeleteByExp<TEntity>,
        IGetById<TEntity,TKey>,
        IGetExp<TEntity>,
        ISave,
        IUpdate<TEntity> where TEntity:class,IEntity,new()
    {
    }
}