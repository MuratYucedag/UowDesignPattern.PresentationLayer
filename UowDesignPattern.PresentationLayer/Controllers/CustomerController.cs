using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UowDesignPattern.BusinessLayer.Abstract;
using UowDesignPattern.DataAccessLayer.Concrete;
using UowDesignPattern.DataAccessLayer.UnitOfWork.Abstract;
using UowDesignPattern.EntityLayer.Concrete;
using UowDesignPattern.PresentationLayer.Models;

namespace UowDesignPattern.PresentationLayer.Controllers
{
    public class CustomerController : Controller
    {
        ICustomerService _customerService;
        IUowDal _uowDal;

        public CustomerController(ICustomerService customerService, IUowDal uowDal)
        {
            _customerService = customerService;
            _uowDal = uowDal;
        }

        [HttpGet]
        public IActionResult SendMoney()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMoney(ProcessViewModel p)
        {
            Context context = new Context();

            decimal senderCurrentBalance = context.Customers.Where(x => x.CustomerID == p.SenderID).Select(y => y.Balance).FirstOrDefault();

            decimal receiverCurrentBalance = context.Customers.Where(x => x.CustomerID == p.ReceiverID).Select(y => y.Balance).FirstOrDefault();

            p.SenderNewBalance = senderCurrentBalance - p.Amount;
            p.ReceiverNewBalance = receiverCurrentBalance + p.Amount;

             Customer t = new Customer();

            var value1 = new Customer()
            {
                CustomerID = p.SenderID,
                Balance = p.SenderNewBalance
            };

            var value2 = new Customer()
            {
                CustomerID = p.ReceiverID,
                Balance = p.ReceiverNewBalance
            };

            List<Customer> modifiedCustomers = new List<Customer>()
            {
                value1,
                value2
            };

            _customerService.TUpdate(modifiedCustomers);

            return View();
        }
    }
}
