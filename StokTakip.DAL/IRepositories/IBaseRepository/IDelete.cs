using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.Entity.Model;

namespace StokTakip.DAL.IRepositories.IBaseRepository
{
    public interface IDelete<TEntity> where TEntity:class,IEntity,new()
    {
        int Delete(TEntity entity);
    }
}
