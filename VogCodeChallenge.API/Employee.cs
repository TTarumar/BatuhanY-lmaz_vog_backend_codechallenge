using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VogCodeChallenge.API
{
    [DataContract]
    public class Employee
    {

        [DataMember(Name="Name")]
        public string Name { get; set; }

        [DataMember(Name = "LastName")]
        public string LastName { get; set; }

        [DataMember(Name = "JobTitle")]
        public string JobTitle { get; set; }

        [DataMember(Name = "Adress")]
        public string Adress { get; set; }

        internal void Add(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
