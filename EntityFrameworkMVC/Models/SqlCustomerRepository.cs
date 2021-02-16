using EntityFrameworkMVC.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkMVC.Models
{
    public class SqlCustomerRepository : ICustomerRepository
    {
        private CustomerAppDb _context;

        public SqlCustomerRepository(CustomerAppDb context)
        {
            _context = context;
        }


        public IEnumerable<MemberShip> GetAllCustomerDetails()
        {

            var cust = _context.Memberships.Include(a => a.Customers).ToList();
        
            return cust;


        }

        public Customer GetCustomerById(int id)
        {
           //return _context.Customers?.Where(x => x.CustomerId == id).SingleOrDefault();
             var cust = _context.Customers.Include(c => c.MemberShip).ToList();
             var customer = cust.Where(x => x.CustomerId == id).SingleOrDefault();

            return customer;
        }
    }
}
