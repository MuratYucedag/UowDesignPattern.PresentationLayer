using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UowDesignPattern.BusinessLayer.Abstract;
using UowDesignPattern.DataAccessLayer.Abstract;
using UowDesignPattern.DataAccessLayer.UnitOfWork.Abstract;
using UowDesignPattern.EntityLayer.Concrete;

namespace UowDesignPattern.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        IUowDal _uowDal;

        public CustomerManager(ICustomerDal customerDal, IUowDal uowDal)
        {
            _customerDal = customerDal;
            _uowDal = uowDal;
        }

        public void TDelete(Customer t)
        {
            throw new NotImplementedException();
        }

        public Customer TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(Customer t)
        {
            _customerDal.Insert(t);
            _uowDal.Save();
        }

        public void TUpdate(Customer t)
        {
            _customerDal.Update(t);
            _uowDal.Save();
        }
    }
}
