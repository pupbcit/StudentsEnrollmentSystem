using System;

namespace StudentEnrollmentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Students Enrollment System");

            string studentNumber = "2020-00425-BN-0"; //declare + assignment
            string studentName = "Missy Janelle M. Tolosa";
            string studentAdress = "San Antonio, Binan";
            int age = 19;
            string password = "missy";
            string course = "DICT";
            string yearlevel = "1st";

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter Password:");
                string passwordInput = Console.ReadLine();

                Console.WriteLine();
                if (passwordInput == password)
                {
                    Console.WriteLine("STUDENT INFORMATION");
                    Console.WriteLine("Student Number: " + studentNumber);
                    Console.WriteLine("Student Name: " + studentName);
                    Console.WriteLine("Student Address: " + studentAdress);
                    Console.WriteLine("Student Age: " + age);
                    Console.WriteLine("Student Coure & Year: " + course + " " + yearlevel);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Password.");
                }
            }

            //subject selection
            string subject1 = "Programming 2";
            string subject2 = "PE";
            string subject3 = "English";
            string subject4 = "Statistics";

            //subject selected
            string enrolledSubject1 = "";
            string enrolledSubject2 = "";
            string enrolledSubject3 = "";
            string enrolledSubject4 = "";

            Console.WriteLine();
            Console.WriteLine("Please enter Y if you want to enroll the  subject or N if not.");

            Console.Write("SUBJECT: " + subject1 + ": ");
            char sub1enrollYorN = char.Parse(Console.ReadLine());

            if (sub1enrollYorN == 'Y')
            {
                enrolledSubject1 = subject1;
            } else if (sub1enrollYorN != 'Y' || sub1enrollYorN != 'N')
            {
                Console.WriteLine("Invalid Input. System will exit.");
            }

            Console.Write("SUBJECT: " + subject2 + ": ");
            char sub2enrollYorN = char.Parse(Console.ReadLine());

            if (sub2enrollYorN == 'Y')
            {
                enrolledSubject2 = subject2;
            }
            else if (sub1enrollYorN != 'Y' || sub1enrollYorN != 'N')
            {
                Console.WriteLine("Invalid Input. System will exit.");
            }

            Console.Write("SUBJECT: " + subject3 + ": ");
            char sub3enrollYorN = char.Parse(Console.ReadLine());

            if (sub3enrollYorN == 'Y')
            {
                enrolledSubject3 = subject3;
            }
            else if (sub1enrollYorN != 'Y' || sub1enrollYorN != 'N')
            {
                Console.WriteLine("Invalid Input. System will exit.");
            }

            Console.Write("SUBJECT: " + subject4 + ": ");
            char sub4enrollYorN = char.Parse(Console.ReadLine());

            if (sub4enrollYorN == 'Y')
            {
                enrolledSubject4 = subject4;
            }
            else if (sub1enrollYorN != 'Y' || sub1enrollYorN != 'N')
            {
                Console.WriteLine("Invalid Input. System will exit.");
            }

            //OUTPUT ALL SELECTED ENROLLED SUBJECTS
            Console.WriteLine();
            Console.WriteLine("SUBJECTS ENROLLED:");
            
            if (enrolledSubject1 != String.Empty)
            {
                Console.Write(enrolledSubject1);
                Console.Write(",");
            }
            if (enrolledSubject2 != String.Empty)
            {
                Console.Write(enrolledSubject2);
                Console.Write(",");
            }
            if (enrolledSubject3 != String.Empty)
            {
                Console.Write(enrolledSubject3);
                Console.Write(",");
            }
            if (enrolledSubject4 != String.Empty)
            {
                Console.Write(enrolledSubject4);
            }
        }
    }
}
