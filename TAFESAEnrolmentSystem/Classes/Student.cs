using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESAEnrolmentSystem.Classes
{
    /// <summary>
    /// A student, inheriting from Person, with enrolment details.
    /// </summary>
    public class Student : Person, IComparable<Student>
    {
        private string studentID;
        private string program;
        private DateTime dateRegistered;
        private List<Enrolment> enrolments;

        const string DEFAULT_STUDENT_ID = "";
        const string DEFAULT_PROGRAM = "";

        /// <summary>
        /// Get/set the student's ID.
        /// </summary>
        public string StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        /// <summary>
        /// Get/set the student's program.
        /// </summary>
        public string Program
        {
            get { return program; }
            set { program = value; }
        }

        /// <summary>
        /// Get/set the date the student registered.
        /// </summary>
        public DateTime DateRegistered
        {
            get { return dateRegistered; }
            set { dateRegistered = value; }
        }

        /// <summary>
        /// Get/set the list of enrolments for the student.
        /// </summary>
        public List<Enrolment> Enrolments
        {
            get { return enrolments; }
            set { enrolments = value; }
        }

        /// <summary>
        /// Initializes a new Student object with default values.
        /// </summary>
        public Student() : base()
        {
            studentID = DEFAULT_STUDENT_ID;
            program = DEFAULT_PROGRAM;
            dateRegistered = DateTime.MinValue; // Use MinValue rather than Now for more clearly idenfitiable empty value.
            enrolments = new List<Enrolment>();
        }

        /// <summary>
        /// Initializes a new Student object with specific values.
        /// </summary>
        /// <param name="name">The student's name (inherited).</param>
        /// <param name="email">The student's email (inherited).</param>
        /// <param name="phoneNumber">The student's phone number (inherited).</param>
        /// <param name="address">The student's address (inherited).</param>
        /// <param name="studentID">The student's ID.</param>
        /// <param name="program">The student's program.</param>
        /// <param name="dateRegistered">The date the student registered.</param>
        public Student(string name, string email, string phoneNumber, Address address,
                      string studentID, string program, DateTime dateRegistered)
            : base(name, email, phoneNumber, address)
        {
            this.studentID = studentID;
            this.program = program;
            this.dateRegistered = dateRegistered;
            enrolments = new List<Enrolment>();
        }

        /// <summary>
        /// Checks equality of two objects, comparing this Student object and another object based on StudentID.
        /// </summary>
        /// <param name="obj">The object to compare with the current Student.</param>
        /// <returns>True if the specified object is a Student with the same StudentID; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return true;
            if (obj.GetType() != GetType())
            {
                return false;
            }
            Student other = (Student)obj;
            return studentID == other.studentID;
        }

        /// <summary>
        /// Compares two Students for Equality based on StudentID.
        /// </summary>
        /// <param name="a">The first Student object.</param>
        /// <param name="b">The second Student object.</param>
        /// <returns>True if the Students have the same StudentIDs (else false).</returns>
        public static bool operator ==(Student a, Student b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;
            return Equals(a.StudentID, b.StudentID);
        }

        /// <summary>
        /// Compares two Students for inequality based on StudentID.
        /// </summary>
        /// <param name="a">The first Student object.</param>
        /// <param name="b">The second Student object.</param>
        /// <returns>True if the students have different StudentIDs (else false).</returns>
        public static bool operator !=(Student a, Student b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return false;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return true;
            return !Equals(a.StudentID, b.StudentID);
        }

        /// <summary>
        /// Generates a hash code for this Student object based its StudentID.
        /// </summary>
        /// <returns>A hash code for this Student object.</returns>
        public override int GetHashCode()
        {
            if (studentID == "" || studentID == null)
                return 0;
            return studentID.GetHashCode();
        }

        /// <summary>
        /// Returns a string with all object variables and their values.
        /// </summary>
        /// <returns>A string containing the student's details.</returns>
        public override string ToString()
        {
            string enrolmentDetails;
            if (enrolments.Count > 0)
            {
                enrolmentDetails = string.Join("; ", enrolments);
            }
            else
            {
                enrolmentDetails = "No enrolments";
            }
            return $"{base.ToString()}, StudentID: {studentID}, Program: {program}, " +
                   $"DateRegistered: {dateRegistered:yyyy-MM-dd}, Enrolments: {enrolmentDetails}";
        }

        /// <summary>
        /// Compares this Student object with another Student object.
        /// </summary>
        /// <param name="other">Another student to compare with.</param>
        /// <returns>
        /// -1 if this student is less, 
        /// 0 if equal to, or
        /// 1 if greater than the other student
        /// </returns>
        public int CompareTo(Student other)
        {
            if (other == null)
                return 1;

            return string.Compare(StudentID, other.StudentID);
        }
    }
}