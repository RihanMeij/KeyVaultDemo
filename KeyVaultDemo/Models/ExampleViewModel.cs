using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeyVaultDemo.Models
{
    public class ExampleViewModel
    {
        public ExampleViewModel()
        {
            People = new List<Person>();
        }
        public List<Person> People { get; set; }

    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
