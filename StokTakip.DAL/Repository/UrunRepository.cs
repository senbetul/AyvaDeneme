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
   class UrunRepository : IUrunRepository
    {
        public int Delete(Expression<Func<Urun, bool>> exp)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int Delete(Urun entity)
        {
            throw new NotImplementedException();
        }

        public List<Urun> Get(Expression<Func<Urun, bool>> exp = null)
        {
            throw new NotImplementedException();
        }

        public Urun GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Save()
        {
            throw new NotImplementedException();
        }

        public int Update(Urun entity)
        {
            throw new NotImplementedException();
        }
    }
}
