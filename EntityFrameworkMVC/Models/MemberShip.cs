using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkMVC.Models
{
    public class MemberShip
    {
        public MemberShip()
        {
            Customers = new HashSet<Customer>();
        }

        public int MemberShipId { get; set; }
        public int SignUpFee { get; set; }
        public  int DurationInMonths{ get; set; }
        public int Discount{ get; set; }

        public ICollection<Customer> Customers { get; set; }

    }
}
