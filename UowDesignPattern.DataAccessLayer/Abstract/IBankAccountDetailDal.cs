using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UowDesignPattern.EntityLayer.Concrete;

namespace UowDesignPattern.DataAccessLayer.Abstract
{
    public interface IBankAccountDetailDal : IGenericDal<BankAccountDetail>
    {
    }
}
