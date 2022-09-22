using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WcfDemoCRUD
{
    public class PersonDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public PersonDbContext() : base("PersonCS")
        {

        }
    }
}