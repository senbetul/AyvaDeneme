using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.Entity.Model;
using System.Linq.Expressions;

namespace StokTakip.DAL.IRepositories.IBaseRepository
{
    public interface IDeleteByExp<TEntity> where TEntity :class,IEntity,new()
    {
        int Delete(Expression<Func<TEntity,bool>>exp);


    }
}
