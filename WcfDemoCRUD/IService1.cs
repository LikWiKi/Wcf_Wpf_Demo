using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfDemoCRUD
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        IEnumerable<Person> GetAllPerson();

        [OperationContract]
        void InsertPerson(Person person);

        [OperationContract]
        void UpdatePerson(Person person);

        [OperationContract]
        void DeletePerson(int id);
    }

    [DataContract]
    public class Person
    {
        [DataMember]
        [Key]
        public int id { get; set; }
        [DataMember]
        [Required]
        public string Name { get; set; }
        [DataMember]
        [Required]
        public string PhoneNumber { get; set; }
        public Person() { }
    }
}
