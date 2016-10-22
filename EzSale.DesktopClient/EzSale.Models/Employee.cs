using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzSale.Models
{
    public class Employee: Person
    {
        //ToDo Contact preference
        //ToDo  Service Provider, on or off
        //ToDO Lead source
        //ToDO Title/Position
        //ToDo BookingGroup
        //To Do Assigned location
        //ToDo Access permission

        //Employee informations
        //private DateTime _dateOfBirth;
        //private int _employeeCode;
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
        private string _password;
        private decimal _hourlyWage;
        private int _pinCode;

        public decimal HourlyWage
        {
            get
            {
                return _hourlyWage;
            }

            set
            {
                _hourlyWage = value;
            }
        }

        /// <summary>
        /// Employee password
        /// </summary>
        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
            }


        }

        /// <summary>
        /// Employee pin code
        /// </summary>
        public int PinCode
        {
            get
            {
                return _pinCode;
            }

            set
            {
                _pinCode = value;
            }
        }

        public override string ToString()
        {
            string result = "";
            result += "This is an employee\n";

            result += String.Format("First Name:{0} Last Name: {1} Email: {2}", FirstName, LastName, Email);

            return result;
        }
    }

}
