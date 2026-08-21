// See https://aka.ms/new-console-template for more information
using System;

namespace Pract1
{
    class Student
    {
        private int admissionNo;
        private string studentName;
        private string course;
        private int semester;
        private double admissionFees;
        private bool scholarship;

        const double ScholarshipRate = 0.10;

        public Student()
        {
            Console.WriteLine("Student Object Created Successfully.\n");
        }

        public void AcceptDetails()
        {
            Console.Write("Enter Admission Number : ");
            admissionNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Name     : ");
            studentName = Console.ReadLine();

            Console.Write("Enter Course           : ");
            course = Console.ReadLine();

            Console.Write("Enter Semester         : ");
            semester = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Admission Fees   : ");
            admissionFees = Convert.ToDouble(Console.ReadLine());
        }

        public double CalculateFinalFees()
        {
            if (admissionFees >= 45000)
            {
                scholarship = true;
                return admissionFees - (admissionFees * ScholarshipRate);
            }

            scholarship = false;
            return admissionFees;
        }

        public void DisplayDetails()
        {
            double finalFees = CalculateFinalFees();

            Console.WriteLine("\n------------------------------------------------");
            Console.WriteLine("           STUDENT ADMISSION DETAILS");
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine($"Admission Number : {admissionNo}");
            Console.WriteLine($"Student Name     : {studentName}");
            Console.WriteLine($"Course           : {course}");
            Console.WriteLine($"Semester         : {semester}");
            Console.WriteLine($"Admission Fees   : {admissionFees}");
            Console.WriteLine($"Scholarship      : {(scholarship ? "Eligible" : "Not Eligible")}");
            Console.WriteLine($"Final Fees       : {finalFees}");

            Console.WriteLine("------------------------------------------------");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();

            s1.AcceptDetails();

            s1.DisplayDetails();

            Console.WriteLine("\nPress Enter to Exit...");
            Console.ReadLine();
        }
    }
}
