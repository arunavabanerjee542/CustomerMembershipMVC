using EntityFrameworkMVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkMVC.Models
{
    public interface ICustomerRepository
    {
        IEnumerable<MemberShip> GetAllCustomerDetails();
       Customer GetCustomerById(int id);

    }
}
