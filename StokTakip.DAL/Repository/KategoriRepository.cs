using StokTakip.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.Entity.Model;
using System.Linq.Expressions;

namespace StokTakip.DAL.Repository
{
    class KategoriRepository : IKategoriRepository
    {

        //ConnectionString, DB bağlantısı, Context ihtiyacımız olur

        //Add
        //Update
        //Delete
        //DeleteById
        //GetById
        //GetAll
        //Save
        public int Delete(Expression<Func<Kategori, bool>> exp)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int Delete(Kategori entity)
        {
            throw new NotImplementedException();
        }

        public List<Kategori> Get(Expression<Func<Kategori, bool>> exp = null)
        {
            throw new NotImplementedException();
        }

        public Kategori GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Save()
        {
            throw new NotImplementedException();
        }

        public int Update(Kategori entity)
        {
            throw new NotImplementedException();
        }
    }
}
