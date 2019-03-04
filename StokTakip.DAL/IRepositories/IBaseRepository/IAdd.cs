using StokTakip.Entity.Model;

namespace StokTakip.DAL.IRepositories.IBaseRepository
{
    public interface IAdd<TEntity> where TEntity:class, IEntity, new() 
    {
        //IEntityden Miras Alan ve class ve newlenebilen classları alabilir.
    }
}