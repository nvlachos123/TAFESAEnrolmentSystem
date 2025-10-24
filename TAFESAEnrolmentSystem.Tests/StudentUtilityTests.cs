using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAFESAEnrolmentSystem.Classes;

namespace TAFESAEnrolmentSystem.Tests
{
[TestFixture]
public class StudentUtilityTests
{
    private Student[]? studentsUnsorted;

    [SetUp]
    public void Setup()
    {
        // Create array of 10 students in an Unsorted order
        studentsUnsorted = new Student[]
        {
            new Student("Student One", "studentone@email.com", "0411111111", 
                new Address("1", "Street 1", "Suburb One", "5001", "SA"), "00001", "Student One Program", new DateTime(2001, 1, 1)),
            new Student("Student Three", "studentthree@email.com", "0433333333", 
                new Address("3", "Street 3", "Suburb Three", "5003", "SA"), "00003", "Student Three Program", new DateTime(2003, 3, 3)),
            new Student("Student Four", "studentfour@email.com", "0444444444", 
                new Address("4", "Street 4", "Suburb Four", "5004", "SA"), "00004", "Student Four Program", new DateTime(2004, 4, 4)),
            new Student("Student Two", "studenttwo@email.com", "0422222222", 
                new Address("2", "Street 2", "Suburb Two", "5002", "SA"), "00002", "Student Two Program", new DateTime(2002, 2, 2)),
            new Student("Student Five", "studentfive@email.com", "0455555555", 
                new Address("5", "Street 5", "Suburb Five", "5005", "SA"), "00005", "Student Five Program", new DateTime(2005, 5, 5)),
            new Student("Student Nine", "studentnine@email.com", "0499999999", 
                new Address("9", "Street 9", "Suburb Nine", "5009", "SA"), "00009", "Student Nine Program", new DateTime(2009, 9, 9)),
            new Student("Student Eight", "studenteight@email.com", "0488888888", 
                new Address("8", "Street 8", "Suburb Eight", "5008", "SA"), "00008", "Student Eight Program", new DateTime(2008, 8, 8)),
            new Student("Student Six", "studentsix@email.com", "0466666666", 
                new Address("6", "Street 6", "Suburb Six", "5006", "SA"), "00006", "Student Six Program", new DateTime(2006, 6, 6)),
            new Student("Student Seven", "studentseven@email.com", "0477777777",
                new Address("7", "Street 7", "Suburb Seven", "5007", "SA"), "00007", "Student Seven Program", new DateTime(2007, 7, 7)),
            new Student("Student Ten", "studentten@email.com", "0400000000", 
                new Address("10", "Street 10", "Suburb Ten", "5010", "SA"), "00010", "Student Ten Program", new DateTime(2010, 10, 10))
        };
    }

    [Test]
    public void LinearSearchArray_FoundStudent_ReturnsCorrectIndex()
    {
        Student target = new Student { StudentID = "00005" }; // Student 00005 is in the array

        int result = Utility.LinearSeachArray(studentsUnsorted, target);

        Assert.That(result, Is.EqualTo(4), "Linear search should return index 4 when StudentID == 00005.");
    }

    [Test]
    public void LinearSearchArray_NotFoundStudent_ReturnsMinusOne()
    {
        Student target = new Student { StudentID = "00011" }; // Student 00011 is not in the array

        int result = Utility.LinearSeachArray(studentsUnsorted, target);

        Assert.That(result, Is.EqualTo(-1), "Linear search should return -1 when StudentID is not in the array.");
    }

    [Test]
    public void BinarySearchArray_FoundStudent_ReturnsCorrectIndex()
    {
        // Create a new array to copy unsorted data to for sorting
        var testStudents = new Student[studentsUnsorted.Length];
        // Copy the unsorted array to the new array
        Array.Copy(studentsUnsorted, testStudents, studentsUnsorted.Length);
        // Sort the new array for binary search
        Array.Sort(testStudents);

        // Define the target of the search
        Student target = new Student { StudentID = "00005" }; // Student 00005 is in the array

        // Use the binary search to find the target student
        int result = Utility.BinarySearchArray(testStudents, target);

        // Confirm result is found
        Assert.That(result, Is.EqualTo(4), "Binary search should return index 4 when StudentID == 00005.");
    }

    [Test]
    public void BinarySearchArray_NotFoundStudent_ReturnsMinusOne()
    {
        // Create a new array to copy unsorted data to for sorting
        var testStudents = new Student[studentsUnsorted.Length];

        // Copy the unsorted array to the new array
        Array.Copy(studentsUnsorted, testStudents, studentsUnsorted.Length);

        // Sort the new array for binary search
        Array.Sort(testStudents);

        // Define the target of the search
        Student target = new Student { StudentID = "00011" }; // Student is not in the array

        // Use the binary search to attempt to find the target student
        int result = Utility.BinarySearchArray(testStudents, target);

        // Confirm result is not found
        Assert.That(result, Is.EqualTo(-1), "Binary search should return -1 when StudentID is not in the array.");
    }

    [Test]
    public void SelectionSortAscending_SortsByStudentID_CorrectOrder()
    {
        // Create a new array to copy array for sorting
        var testStudents = new Student[studentsUnsorted.Length];

        // Copy the array for sorting
        Array.Copy(studentsUnsorted, testStudents, studentsUnsorted.Length);

        // Use SelectionSortAscending to sort array in ascending order 
        Utility.SelectionSortAscending(testStudents);

        // Loop through each index to ensure each index StudentID is less than the subsequent index StudentID
        for (int i = 0; i < testStudents.Length - 1; i++)
        {
            Assert.That(testStudents[i].StudentID, Is.LessThanOrEqualTo(testStudents[i + 1].StudentID),
                $"Selection sort failed. Indexes are out of expected order.");
        }
    }

    [Test]
    public void SelectionSortDescending_SortsByStudentID_CorrectOrder()
    {
        // Create a new array to copy array for sorting
        var testStudents = new Student[studentsUnsorted.Length];

        // Copy the array for sorting
        Array.Copy(studentsUnsorted, testStudents, studentsUnsorted.Length);

        // Use SelectionSortDescending to sort array in descending order
        Utility.SelectionSortDescending(testStudents);

        // Loop through each index to ensure each index StudentID is greater than the subsequent index StudentID
        for (int i = 0; i < testStudents.Length - 1; i++)
        {
            Assert.That(testStudents[i].StudentID, Is.GreaterThanOrEqualTo(testStudents[i + 1].StudentID),
                $"Selection sort failed. Indexes are out of expected order.");
        }
    }

    [Test]
    public void SelectionSortAscending_WithDescendingExpectation_Fails()
    {
        // Create a new array to copy array for sorting
        var testStudents = new Student[studentsUnsorted.Length];

        // Copy the array for sorting
        Array.Copy(studentsUnsorted, testStudents, studentsUnsorted.Length);

        // Use SelectionSortAscending to sort array in ascending order
        Utility.SelectionSortAscending(testStudents);

        // Intentionally assert that the array is in descending order to demonstrate failure
        bool hasFailed = false;
        try
        {
            for (int i = 0; i < testStudents.Length - 1; i++)
            {
                Assert.That(testStudents[i].StudentID, Is.GreaterThanOrEqualTo(testStudents[i + 1].StudentID),
                    $"Expected descending order, but array is sorted ascending.");
            }
        }
        catch (AssertionException)
        {
            hasFailed = true;
        }
        Assert.That(hasFailed, Is.True, "Ascending sort test should fail when expecting descending order.");
    }

    [Test]
    public void SelectionSortDescending_WithAscendingExpectation_Fails()
    {
        // Create a new array to copy array for sorting
        var testStudents = new Student[studentsUnsorted.Length];

        // Copy the array for sorting
        Array.Copy(studentsUnsorted, testStudents, studentsUnsorted.Length);

        // Use SelectionSortDescending to sort array in descending order
        Utility.SelectionSortDescending(testStudents);

        // Intentionally assert that the array is in ascending order to demonstrate failure
        bool hasFailed = false;
        try
        {
            for (int i = 0; i < testStudents.Length - 1; i++)
            {
                Assert.That(testStudents[i].StudentID, Is.LessThanOrEqualTo(testStudents[i + 1].StudentID),
                    $"Expected ascending order, but array is sorted descending.");
            }
        }
        catch (AssertionException)
        {
            hasFailed = true;
        }
        Assert.That(hasFailed, Is.True, "Descending sort test should fail when expecting ascending order.");
    }
}
}