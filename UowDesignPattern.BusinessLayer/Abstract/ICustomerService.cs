using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UowDesignPattern.EntityLayer.Concrete;

namespace UowDesignPattern.BusinessLayer.Abstract
{
    public interface ICustomerService : IGenericService<Customer>
    {
        public void TMultipleUpdateByCustomer(List<Customer> p);
    }
}
