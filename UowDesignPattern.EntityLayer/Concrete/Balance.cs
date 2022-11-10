using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UowDesignPattern.EntityLayer.Concrete
{
    public class Balance
    {
        public int BalanceID { get; set; }
        public decimal TotalBalance { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
    }
}
