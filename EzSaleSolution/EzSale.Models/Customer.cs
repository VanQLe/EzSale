using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzSale.Models
{
    public class Customer:Person
    {

        //ToDo Contact preference
        //ToDo Peferred Service Provider
        //ToDO Lead source

        //Customer informations
        //private DateTime _dateOfBirth;
        //private int _customerCode;
        //private int _cellPhone;
        //private int _workPhone;
        //private string _gender;
        //private string _state;
        //private int _zipCode;
        //private string _address2;
        //private string _country;
        //private string _address;
        //private string _city;
        //private string _lastName;
        //private string _firstName;
        //private string _email;


        public override string ToString()
        {
            string result = "";
            result += "This is an Customer\n";

            result += String.Format("First Name:{0} Last Name: {1} Email: {2}", FirstName, LastName, Email);

            return result;
        }

    }
      
}
