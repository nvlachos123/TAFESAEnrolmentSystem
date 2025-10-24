using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESAEnrolmentSystem.Classes
{
    /// <summary>
    /// An Address with location details.
    /// </summary>
    public class Address
    {
        private string streetNum;
        private string streetName;
        private string suburb;
        private string postCode;
        private string state;

        const string DEFAULT_STREET_NUM = "";
        const string DEFAULT_STREET_NAME = "";
        const string DEFAULT_SUBURB = "";
        const string DEFAULT_POSTCODE = "";
        const string DEFAULT_STATE = "";


        /// <summary>
        /// Get/set the street number.
        /// </summary>
        public string StreetNum
        {
            get { return streetNum; }
            set { streetNum = value; }
        }

        /// <summary>
        /// Get/set the street name.
        /// </summary>
        public string StreetName
        {
            get { return streetName; }
            set { streetName = value; }
        }

        /// <summary>
        /// Get/set the suburb.
        /// </summary>
        public string Suburb
        {
            get { return suburb; }
            set { suburb = value; }
        }

        /// <summary>
        /// Get/set the postcode.
        /// </summary>
        public string PostCode
        {
            get { return postCode; }
            set { postCode = value; }
        }

        /// <summary>
        /// Get/set the state.
        /// </summary>
        public string State
        {
            get { return state; }
            set { state = value; }
        }

        /// <summary>
        /// Initializes a new Address object with default values.
        /// </summary>
        public Address()
        {
            streetNum = DEFAULT_STREET_NUM;
            streetName = DEFAULT_STREET_NAME;
            suburb = DEFAULT_SUBURB;
            postCode = DEFAULT_POSTCODE;
            state = DEFAULT_STATE;
        }

        /// <summary>
        /// Initializes a new Address object with specific values.
        /// </summary>
        /// <param name="streetNum">The street number.</param>
        /// <param name="streetName">The street name.</param>
        /// <param name="suburb">The suburb.</param>
        /// <param name="postCode">The postcode.</param>
        /// <param name="state">The state.</param>
        public Address(string streetNum, string streetName, string suburb, string postCode, string state)
        {
            this.streetNum = streetNum;
            this.streetName = streetName;
            this.suburb = suburb;
            this.postCode = postCode;
            this.state = state;
        }

        /// <summary>
        /// Returns a string with all object variables and their values.
        /// </summary>
        /// <returns>A string containing the address details.</returns>
        public override string ToString()
        {
            return $"{streetNum} {streetName}, {suburb}, {state} {postCode}";
        }
    }
}