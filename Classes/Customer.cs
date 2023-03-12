using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {
        //field

        // public string FirstName;

        //property

        public int Id { get; set; }

        //private string _firstName;
        //public string Name {
        //    get {
        //        return "Mr. " + _firstName;
        //    } 
        //    set {
        //        _firstName = value;
        //    } 
        //}

        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

    }
}
