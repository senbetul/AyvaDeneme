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
    class TedarikciRepostory : ITedarikciRepository
    {
        public int Delete(Expression<Func<Tedarikci, bool>> exp)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int Delete(Tedarikci entity)
        {
            throw new NotImplementedException();
        }

        public List<Tedarikci> Get(Expression<Func<Tedarikci, bool>> exp = null)
        {
            throw new NotImplementedException();
        }

        public Tedarikci GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Save()
        {
            throw new NotImplementedException();
        }

        public int Update(Tedarikci entity)
        {
            throw new NotImplementedException();
        }
    }
}
