using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UowDesignPattern.DataAccessLayer.Concrete;
using UowDesignPattern.EntityLayer.Concrete;

namespace UowDesignPattern.PresentationLayer.Controllers
{
    public class ProcessController : Controller
    {
        Context context = new Context();

        [HttpGet]
        public IActionResult SendMoney()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMoney(Balance p)
        {
            var senderBalance = context.Balances.Where(x => x.CustomerID == 1).Select(y => y.TotalBalance).FirstOrDefault();
            int sendbalance = Convert.ToInt32(senderBalance);
            sendbalance = sendbalance - 3580;
            
            context.SaveChanges();

            var receiverbalance = context.Balances.Where(x => x.CustomerID == 2).Select(y => y.TotalBalance).FirstOrDefault();
            int receivbalance = Convert.ToInt32(receiverbalance);
            receivbalance = receivbalance + 3580;

            context.SaveChanges();

            return View();
        }
    }
}
