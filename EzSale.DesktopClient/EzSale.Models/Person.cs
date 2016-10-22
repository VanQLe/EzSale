using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzSale.Models
{
    public abstract class Person
    {
        private DateTime _dateOfBirth;
        private int _id;
        private int _cellPhone;
        private int _workPhone;
        private string _gender;
        private string _state;
        private int _zipCode;
        private string _address2;
        private string _country;
        private string _address;
        private string _city;
        private string _lastName;
        private string _firstName;
        private string _email;

        /// <summary>
        /// Person id
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        /// <summary>
        /// Person first name
        /// </summary>
        public string FirstName
        {
            get
            {
                return _firstName;
            }

            set
            {
                _firstName = value;
            }
        }


        /// <summary>
        /// Person last name
        /// </summary>
        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                _lastName = value;
            }
        }


        /// <summary>
        /// Person email
        /// </summary>
        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }


        /// <summary>
        /// Person primary address
        /// </summary>
        public string Address
        {
            get
            {
                return _address;
            }

            set
            {
                _address = value;
            }
        }
        /// <summary>
        /// Person city
        /// </summary>
        public string City
        {
            get
            {
                return _city;
            }

            set
            {
                _city = value;
            }
        }

        /// <summary>
        /// Person country
        /// </summary>
        public string Country
        {
            get
            {
                return _country;
            }

            set
            {
                _country = value;
            }
        }

        /// <summary>
        /// Person secondary address
        /// </summary>
        public string Address2
        {
            get
            {
                return _address2;
            }

            set
            {
                _address2 = value;
            }
        }

        /// <summary>
        /// Person zip code
        /// </summary>
        public int ZipCode
        {
            get
            {
                return _zipCode;
            }

            set
            {
                _zipCode = value;
            }
        }

        /// <summary>
        /// Person State
        /// </summary>
        public string State
        {
            get
            {
                return _state;
            }

            set
            {
                _state = value;
            }
        }
        /// <summary>
        /// Person gender
        /// </summary>
        public string Gender
        {
            get
            {
                return _gender;
            }

            set
            {
                _gender = value;
            }
        }

        /// <summary>
        /// Person work phone
        /// </summary>
        public int WorkPhone
        {
            get
            {
                return _workPhone;
            }

            set
            {
                _workPhone = value;
            }
        }

        /// <summary>
        /// Person cellphone 
        /// </summary>
        public int CellPhone
        {
            get
            {
                return _cellPhone;
            }

            set
            {
                _cellPhone = value;
            }
        }

        
        /// <summary>
        /// Employee date of birth;
        /// </summary>
        public DateTime DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }

            set
            {
                _dateOfBirth = value;
            }
        }




        public override string ToString()
        {
            string result = "";
            result += "This is a Person\n";

            result += String.Format("First Name:{0} Last Name: {1} Email: {2}", FirstName, LastName, Email);

            return result;
        }
    }
}
