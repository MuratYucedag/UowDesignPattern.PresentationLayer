using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UowDesignPattern.DataAccessLayer.Abstract;
using UowDesignPattern.DataAccessLayer.Concrete;
using UowDesignPattern.DataAccessLayer.Repository;
using UowDesignPattern.EntityLayer.Concrete;

namespace UowDesignPattern.DataAccessLayer.EntityFramework
{
    public class EfCustomerDal : GenericRepository<Customer>, ICustomerDal
    {
        public EfCustomerDal(Context context) : base(context)
        {

        }

        public void MultipleUpdateByCustomer(List<Customer> p)
        {

            using (var context = new Context())
            {
                //var durum1 = context.Entry(p).State;
                context.UpdateRange(p);
            }
        }
    }
}
