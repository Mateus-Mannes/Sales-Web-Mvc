using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;
        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return;
            }
            Department department1 = new Department(1, "Computers");
            Department department2 = new Department(2, "Eletronics");
            Department department3 = new Department(3, "Fashion");
            Department department4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob", "bob", new DateTime(1980, 4, 21), 10.00, department1);
            Seller s2 = new Seller(2, "Bob1", "bob1", new DateTime(1980, 4, 21), 10.00, department2);
            Seller s3 = new Seller(3, "Bob2", "bob2", new DateTime(1980, 4, 21), 10.00, department2);
            Seller s4 = new Seller(4, "Bob3", "bob3", new DateTime(1980, 4, 21), 10.00, department3);
            Seller s5 = new Seller(5, "Bob4", "bob4", new DateTime(1980, 4, 21), 10.00, department4);
            Seller s6 = new Seller(6, "Bob5", "bob5", new DateTime(1980, 4, 21), 10.00, department4);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2918, 9, 25), 11000, SalesStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2918, 9, 25), 11000, SalesStatus.Billed, s1);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2918, 9, 25), 11000, SalesStatus.Billed, s2);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2918, 9, 25), 11000, SalesStatus.Billed, s3);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2918, 9, 25), 11000, SalesStatus.Billed, s4);

            _context.Department.AddRange(department1, department2, department3, department4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5);
            _context.SaveChanges();


        }

    }
}
