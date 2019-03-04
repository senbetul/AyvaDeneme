using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.Entity.Model;

namespace StokTakip.DAL.IRepositories.IBaseRepository
{
    public interface IGetById<TEntity, TKey> where TEntity:class,IEntity, new()
        //TEntity bir class olmalı ve IEntity Interface inden impliment almalıdır ve instance alınabilir bir class olmalıdır. Abstract classlar olmaz.
    {
        TEntity GetById(TKey id);//TEntity tipinde dönuş yapan be Tkey tipinde parametre alan metot.

        //TEntity yerine kategori entity tipini verdik ve TKey yerine int tipini verdiğimizde metot tanımımız
        //Kategori GetById(int id); olur.
    }
}
