using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UowDesignPattern.DataAccessLayer.Abstract;

namespace UowDesignPattern.DataAccessLayer.UnitOfWork.Abstract
{
    public interface IUowDal
    {
        public ICustomerDal customerDal { get; set; }
        void Save();
    }
}
