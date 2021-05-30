using CapitecAssessment.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapitecAssessment.Models
{
    public class BikeContext : DbContext
    {

        public BikeContext(DbContextOptions<BikeContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Bike> Bikes {get;set;}
    }
}
