using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESAEnrolmentSystem.Classes
{
    /// <summary>
    /// A subject in the enrolment system.
    /// </summary>
    public class Subject
    {
        private string subjectCode;
        private string subjectName;
        private decimal cost;

        const string DEFAULT_SUBJECT_CODE = "";
        const string DEFAULT_SUBJECT_NAME = "";
        const decimal DEFAULT_COST = 0.0m;

        /// <summary>
        /// Get/set the subject code.
        /// </summary>
        public string SubjectCode
        {
            get { return subjectCode; }
            set { subjectCode = value; }
        }

        /// <summary>
        /// Get/set the subject name.
        /// </summary>
        public string SubjectName
        {
            get { return subjectName; }
            set { subjectName = value; }
        }

        /// <summary>
        /// Get/set the cost of the subject.
        /// </summary>
        public decimal Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        /// <summary>
        /// Initializes a new Subject object with default values.
        /// </summary>
        public Subject()
        {
            subjectCode = DEFAULT_SUBJECT_CODE;
            subjectName = DEFAULT_SUBJECT_NAME;
            cost = DEFAULT_COST;
        }

        /// <summary>
        /// Initializes a new Subject object with specific values.
        /// </summary>
        /// <param name="subjectCode">The subject code.</param>
        /// <param name="subjectName">The subject name.</param>
        /// <param name="cost">The cost of the subject.</param>
        public Subject(string subjectCode, string subjectName, decimal cost)
        {
            this.subjectCode = subjectCode;
            this.subjectName = subjectName;
            this.cost = cost;
        }

        /// <summary>
        /// Returns a string with all object variables and their values.
        /// </summary>
        /// <returns>A string containing the subject details.</returns>
        public override string ToString()
        {
            return $"Code: {subjectCode}, Name: {subjectName}, Cost: {cost:C}";
        }
    }
}