using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESAEnrolmentSystem.Classes
{
    /// <summary>
    /// An enrolment in a subject to abe assigned to a Student.
    /// </summary>
    public class Enrolment
    {
        private DateTime dateEnrolled;
        private string grade;
        private string semester;
        private Subject subject; // Aggregation: Enrolment has one Subject

        const string DEFAULT_GRADE = "";
        const string DEFAULT_SEMESTER = "";
        const Subject DEFAULT_SUBJECT = null;


        /// <summary>
        /// Get/set the date of enrolment.
        /// </summary>
        public DateTime DateEnrolled
        {
            get { return dateEnrolled; }
            set { dateEnrolled = value; }
        }

        /// <summary>
        /// Get/set the grade for the enrolment.
        /// </summary>
        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        /// <summary>
        /// Get/set the semester of the enrolment.
        /// </summary>
        public string Semester
        {
            get { return semester; }
            set { semester = value; }
        }

        /// <summary>
        /// Get/set the subject of the enrolment.
        /// </summary>
        public Subject Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        /// <summary>
        /// Initializes a new Enrolment object with default values.
        /// </summary>
        public Enrolment()
        {
            dateEnrolled = DateTime.MinValue; // Use MinValue rather than Now for more clearly idenfitiable empty value.
            grade = DEFAULT_GRADE;
            semester = DEFAULT_SEMESTER;
            subject = DEFAULT_SUBJECT;
        }

        /// <summary>
        /// Initializes a new Enrolment object with specific values.
        /// </summary>
        /// <param name="dateEnrolled">The date of enrolment.</param>
        /// <param name="grade">The grade received.</param>
        /// <param name="semester">The semester of enrolment.</param>
        /// <param name="subject">The subject enrolled in.</param>
        public Enrolment(DateTime dateEnrolled, string grade, string semester, Subject subject)
        {
            this.dateEnrolled = dateEnrolled;
            this.grade = grade;
            this.semester = semester;
            this.subject = subject;
        }

        /// <summary>
        /// Returns a string with all object variables and their values.
        /// </summary>
        /// <returns>A string containing the enrolment details.</returns>
        public override string ToString()
        {
            return $"DateEnrolled: {dateEnrolled:yyyy-MM-dd}, Grade: {grade}, Semester: {semester}, " +
                   $"Subject: {(subject != null ? subject.ToString() : "None")}";
        }
    }
}