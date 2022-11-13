using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UowDesignPattern.DataAccessLayer.Abstract;
using UowDesignPattern.DataAccessLayer.Concrete;
using UowDesignPattern.DataAccessLayer.UnitOfWork.Abstract;

namespace UowDesignPattern.DataAccessLayer.UnitOfWork.Concrete
{
    public class UowDal : IUowDal
    {
        private readonly Context _context;
        public UowDal(Context context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
