using System;
using System.Collections.Generic;
using System.Text;

namespace StudentEnrollmentSystem
{
    public class StudentModule
    {
        static string studentNumber = "2020-00425-BN-0";
        static string studentName = "Missy Janelle M. Tolosa";
        static string studentAdress = "San Antonio, Binan";
        static int age = 19;
        static string username = "jane";
        static string password = "missy";
        static string course = "DICT";
        static string yearlevel = "1st";
        static string[] subjectChoices = new[] {
                            "Major - Programming 2",
                            "Minor - Discrete Structures", 
                            "Minor - Technopreneurship",
                            "Minor - CWTS", 
                            "Major - Basic Electronics",
                            "Minor - Understanding the Self", 
                            "Minor - Science",
                            "Major - Hardware and Software", "PE"};
        static string[] enrolledSubjects;

        //parameter less and no return method
        static public void DisplayWelcomeMessage() // method definition
        {
            Console.WriteLine("Welcome to Student Enrollment System!!");
        }

        static public int LoginStudent() //methods with return
        {
            int i = 0;
            for (; i < 3; i++)
            {
                Console.Write("Enter Username:");
                string usernameInput = Console.ReadLine();

                Console.Write("Enter Password:");
                string passwordInput = Console.ReadLine();

                if (usernameInput == username && passwordInput == password)
                {
                    DisplayStudentInfo();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Username or Password.");
                }
            }
            return i;
        }
        static public void DisplayStudentInfo()
        {
            Console.WriteLine("STUDENT INFORMATION");
            Console.WriteLine("Student Number: " + studentNumber);
            Console.WriteLine("Student Name: " + studentName);
            Console.WriteLine("Student Address: " + studentAdress);
            Console.WriteLine("Student Age: " + age);
            Console.WriteLine("Student Coure & Year: " + course + " " + yearlevel);
        }

        static public void EnrollSubjects()
        {
            var enrolledSubjectSize = GetSubjectEnrollSize();
            enrolledSubjects = new string[enrolledSubjectSize];

            Console.WriteLine("\nPlease enter Y if you want to enroll the  subject or N if not.");
            Console.WriteLine("\nMajor subjects are required...");
            var enrollIndex = 0;

            for (int i = 0; i < subjectChoices.Length; i++)
            {
                if (enrollIndex < enrolledSubjectSize)
                {
                    var isRequired = CheckIfSubjectIsRequired(subjectChoices[i]);
                    if (isRequired)
                    {
                        AddSubject(enrollIndex, subjectChoices[i]);
                        enrollIndex++;
                    }
                    else
                    {
                        Console.Write("SUBJECT " + subjectChoices[i] + ":");
                        char userInput = char.Parse(Console.ReadLine());

                        if (userInput == 'Y')
                        {
                            AddSubject(enrollIndex, subjectChoices[i]);
                            enrollIndex++;
                        }
                    }
                }
            }
        }

       static public void AddSubject(int index, string subject)
        {
            enrolledSubjects[index] = subject;
        }

        //method are processes (input --> process --> output)

        static public bool CheckIfSubjectIsRequired(string subject) //method with parameter and with return
        {
            if (subject.StartsWith("Major")) //pre-defined methods.. user-defined 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public int GetSubjectEnrollSize() //capability to call itself, recursion
        {
            Console.WriteLine("How many subjects do you want to enroll this semester?");
            var enrollSubjectSize = Convert.ToInt32(Console.ReadLine());

            if (enrollSubjectSize > 5)
            {
                return enrollSubjectSize;
            }
            else
            {
                Console.WriteLine("Sorry. Required subjects to enroll shoul be more than five. Please try again..");
                return GetSubjectEnrollSize();
            }
        }

        static public void DisplayEnrolledSubjects()
        {
            Console.WriteLine("ALL ENROLLED SUBJECTS ARE: ");
            foreach (var subject in enrolledSubjects)
            {
                Console.WriteLine(subject);
            }
        }
    }
}
