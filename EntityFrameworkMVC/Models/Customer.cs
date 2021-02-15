using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkMVC.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string Name { get; set; }

        [ForeignKey("MemberShip")]
        public int MemberShipId { get; set; }
        public MemberShip MemberShip { get; set; }
       
    }
}
