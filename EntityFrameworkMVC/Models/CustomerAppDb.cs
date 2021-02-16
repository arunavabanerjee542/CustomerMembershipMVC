using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkMVC.Models
{
    public class CustomerAppDb :DbContext
    {

        public CustomerAppDb(DbContextOptions<CustomerAppDb> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          

            modelBuilder.Entity<MemberShip>().HasData(

             new MemberShip()
            { DurationInMonths = 0, SignUpFee = 0, Discount = 0, MemberShipId = 1,MembershipType="Pay AS You Go" },

             new MemberShip()
            { DurationInMonths = 3, SignUpFee = 300, Discount = 10, MemberShipId = 2, MembershipType = "Quaterly" },

            new MemberShip()
            { DurationInMonths = 6, SignUpFee = 600, Discount = 15, MemberShipId = 3, MembershipType = "Half Yearly" },

          new MemberShip()
            { DurationInMonths = 12, SignUpFee = 900, Discount = 20, MemberShipId = 4, MembershipType = "Yearly" }

        );

           
            modelBuilder.Entity<Customer>().HasData(
             new Customer() { Name = "Ram", CustomerId = 4,MemberShipId=1 },
             new Customer() { Name = "Rama", CustomerId = 5 ,MemberShipId=2},
              new Customer() { Name = "Ramji", CustomerId = 6,MemberShipId=3}
             );

        }
     
        public DbSet<Customer> Customers { get; set; }
        public DbSet<MemberShip> Memberships { get; set; }


    }
}
