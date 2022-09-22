using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfDemoCRUD
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void DeletePerson(int id)
        {
            PersonDbContext dbContext = new PersonDbContext();
            var person = dbContext.Persons.Where(p => p.id == id).FirstOrDefault();
            dbContext.Persons.Remove(person);
            dbContext.SaveChanges();
        }

        public IEnumerable<Person> GetAllPerson()
        {
            PersonDbContext dbContext = new PersonDbContext();
            var persons = dbContext.Persons.Select(Person => Person).ToList();
            return persons;
        }

        public void InsertPerson(Person person)
        {
            PersonDbContext dbContext = new PersonDbContext();
            dbContext.Persons.Add(person);
            dbContext.SaveChanges();
        }

        public void UpdatePerson(Person person)
        {
            PersonDbContext dbContext = new PersonDbContext();
            var findPerson = dbContext.Persons.Where(p => p.id == person.id).FirstOrDefault();
            findPerson.Name = person.Name;
            findPerson.PhoneNumber = person.PhoneNumber;
            dbContext.SaveChanges();
        }
    }
}
