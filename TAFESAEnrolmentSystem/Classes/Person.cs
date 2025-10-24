using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESAEnrolmentSystem.Classes
{
    /// <summary>
    /// A person with basic contact information and an address.
    /// </summary>
    public class Person
    {
        private string name;
        private string email;
        private string phoneNumber;
        private Address address; // Aggregation: Person has one Address

        const string DEFAULT_NAME = "";
        const string DEFAULT_EMAIL = "";
        const string DEFAULT_PHONE_NUMBER = "";
        const Address DEFAULT_ADDRESS = null;

        /// <summary>
        /// Get/set the person's name.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Get/set the person's email.
        /// </summary>
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        /// <summary>
        /// Get/set the person's phone number.
        /// </summary>
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        /// <summary>
        /// Get/set the person's address.
        /// </summary>
        public Address Address
        {
            get { return address; }
            set { address = value; }
        }

        /// <summary>
        /// Initializes a new Person object with default values.
        /// </summary>
        public Person()
        {
            name = DEFAULT_NAME;
            email = DEFAULT_EMAIL;
            phoneNumber = DEFAULT_PHONE_NUMBER;
            address = DEFAULT_ADDRESS;
        }

        /// <summary>
        /// Initializes a new Person object with specific values.
        /// </summary>
        /// <param name="name">The person's name.</param>
        /// <param name="email">The person's email.</param>
        /// <param name="phoneNumber">The person's phone number.</param>
        /// <param name="address">The person's address.</param>
        public Person(string name, string email, string phoneNumber, Address address)
        {
            this.name = name;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.address = address;
        }

        /// <summary>
        /// Returns a string with all object variables and their values.
        /// </summary>
        /// <returns>A string containing the person's details.</returns>
        public override string ToString()
        {
            return $"Name: {name}, Email: {email}, Phone: {phoneNumber}, Address: {(address != null ? address.ToString() : "None")}";
        }
    }
}
