using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01.Logic
{
    class Person
    {
        int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }

        public Person()
        {
        }

        public Person(int id, string name, string lastname)
        {
            Id = id;
            Name = name;
            Lastname = lastname;
        }
    }
}
