using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAFESAEnrolmentSystem.Classes;

namespace TAFESAEnrolmentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Address
            Console.WriteLine("~ Testing Address ~");
            Address address1 = new Address();
            Console.WriteLine("No-arg constructor: " + address1.ToString());
            Address address2 = new Address("123", "Fake St", "Adelaide", "5000", "SA");
            Console.WriteLine("All-arg constructor: " + address2.ToString());
            // Test setter
            address2.StreetNum = "456";
            Console.WriteLine("After setting StreetNum: " + address2.ToString());

            // Person
            Console.WriteLine("\n~ Testing Person ~");
            Person person1 = new Person();
            Console.WriteLine("No-arg constructor: " + person1.ToString());
            Person person2 = new Person("Nick Vlachos", "nick.vlachos@fakeemail.com", "0411111111", address2);
            Console.WriteLine("All-arg constructor: " + person2.ToString());
            // Test setter
            person2.Name = "Julie Ruiz";
            Console.WriteLine("After setting Name: " + person2.ToString());

            // Subject
            Console.WriteLine("\n~ Testing Subject ~");
            Subject subject1 = new Subject();
            Console.WriteLine("No-arg constructor: " + subject1.ToString());
            Subject subject2 = new Subject("ICT101", "Intro to ICT", 500.00m);
            Console.WriteLine("All-arg constructor: " + subject2.ToString());
            // Test setter
            subject2.Cost = 333.33m;
            Console.WriteLine("After setting Cost to 333.33: " + subject2.ToString());

            // Enrolment
            Console.WriteLine("\n~ Testing Enrolment ~");
            Enrolment enrolment1 = new Enrolment();
            Console.WriteLine("No-arg constructor: " + enrolment1.ToString());
            Enrolment enrolment2 = new Enrolment(new DateTime(2025, 1, 15), "F", "Semester 1", subject2);
            Console.WriteLine("All-arg constructor: " + enrolment2.ToString());
            // Test setter
            enrolment2.Grade = "P";
            Console.WriteLine("After setting Grade to P: " + enrolment2.ToString());

            // Student
            Console.WriteLine("\n~ Testing Student ~");
            // No-arg constructor
            Student student1 = new Student();
            Console.WriteLine("No-arg constructor: " + student1.ToString());
            // All-arg constructor
            Student student2 = new Student("KT Lau", "kt.lau@fakeemail.com", "0422222222",
                                            address2, "00111111", "Computer Science", new DateTime(2024, 9, 1));
            Console.WriteLine("All-arg constructor: " + student2.ToString());

            // Property setters
            student2.StudentID = "00222222";
            student2.Program = "Engineering";
            student2.DateRegistered = new DateTime(2024, 10, 1);
            student2.Enrolments.Add(enrolment2);
            Console.WriteLine("After setting properties and adding an enrolment: " + student2.ToString());

            // Base property setters
            student2.Name = "Heath Barratt";
            student2.Email = "heath.barratt@fakeemail.com";
            student2.PhoneNumber = "0433333333";
            student2.Address = new Address("234", "Real St", "Modbury", "5111", "SA");
            Console.WriteLine("After setting base properties: " + student2.ToString());

            // Equals, ==, !=, and GetHashCode
            Console.WriteLine("\n~ Testing Student Equality and Hashing ~");
            Student student3 = new Student("Paul Burke", "paul.burke@fakeemail.com", "0444444444",
                                            address2, "00222222", "Mathematics", new DateTime(2024, 9, 1));
            Student student4 = new Student("Nadil Sundarapperuman", "nadil.sundarapperuman@fakeemail.com", "0455555555",
                                            address2, "00333333", "Physics", new DateTime(2024, 9, 1));
            Student student5 = null; // For null tests

            // Test Equals
            Console.WriteLine($"student2.Equals(student3): {student2.Equals(student3)}"); // True
            Console.WriteLine($"student2.Equals(student4): {student2.Equals(student4)}"); // False
            Console.WriteLine($"student2.Equals(null): {student2.Equals(student5)}"); // False
            Console.WriteLine($"student2.Equals(new Person()): {student2.Equals(new Person())}"); // False

            // Test == operator
            Console.WriteLine($"student2 == student3: {student2 == student3}"); // True
            Console.WriteLine($"student2 == student4: {student2 == student4}"); // False
            Console.WriteLine($"student2 == null: {student2 == student5}"); // False
            Console.WriteLine($"student5(null) == null: {student5 == null}"); // True

            // Test != operator
            Console.WriteLine($"student2 != student3: {student2 != student3}"); // False
            Console.WriteLine($"student2 != student4: {student2 != student4}"); // True
            Console.WriteLine($"student2 != null: {student2 != student5}"); // True
            Console.WriteLine($"student5(null) != null: {student5 != null}"); // False

            // Test GetHashCode
            Console.WriteLine($"student2 HashCode: {student2.GetHashCode()}");
            Console.WriteLine($"student3 HashCode: {student3.GetHashCode()}"); // Same
            Console.WriteLine($"student4 HashCode: {student4.GetHashCode()}"); // Different

            // Test edge case: null StudentID
            Console.WriteLine("\n~ Testing Students with null StudentIDs ~");
            Student student6 = new Student();
            student6.StudentID = null;
            Student student7 = new Student();
            student7.StudentID = null;

            Console.WriteLine($"student6.Equals(student7): {student6.Equals(student7)}"); // True
            Console.WriteLine($"student6 == student7: {student6 == student7}"); // True
            Console.WriteLine($"student6 != student7: {student6 != student7}"); // False
            Console.WriteLine($"student6.GetHashCode(): {student6.GetHashCode()}"); // 0

            Console.ReadLine();
        }
    }
}