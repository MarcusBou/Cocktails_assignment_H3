using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Cocktails_assignment_H3
{
    public class DrinkContext: DbContext
    {
        public DrinkContext(): base()
        {

        }

        public DbSet<DrinkBlend> DrinkBlend { get; set; }
        public DbSet<Container> containers { get; set; }
        public DbSet<Alcohol> alcohols { get; set; }
        public DbSet<Soft> softs { get; set; }
        public DbSet<Garnish> garnish { get; set; }
    }
}
