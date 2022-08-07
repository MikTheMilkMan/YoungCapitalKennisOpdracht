using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefoonboek
{
    public class Person
    {
        //this is a static int, used to give all future added Persons a unique ID. in the constructor, this ID is
        //first increased by one and then assigned to that Persons ID attribute.
        public static int staticID { get; set; }

        public Person (string name, string surname, DateTime dateOfBirth, string phoneNumber, string mailAddress)
        {
            ++staticID;
            this.name = name;
            this.surname = surname;
            this.dateOfBirth = DateOnly.FromDateTime(dateOfBirth);
            this.phoneNumber = phoneNumber;
            this.mailAddress = mailAddress;
            id = staticID;
        }

        public String name { get; set; }
        public String surname { get; set; }
        public DateOnly dateOfBirth { get; set; }
        public String phoneNumber { get; set; }
        public String mailAddress { get; set; }
        public Boolean isInList { get; set; }
        public int id { get; set; }


    }
}
