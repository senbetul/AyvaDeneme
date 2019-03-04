using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.Entity.Model;

namespace StokTakip.DAL.IRepositories.IBaseRepository
{
    public interface IUpdate<TEntity> where TEntity:class,IEntity,new()
    {

        int Update(TEntity entity);

    }
}
