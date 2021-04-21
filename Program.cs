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
            string username = "jane";
            string password = "missy";
            string course = "DICT";
            string yearlevel = "1st";

            int i = 0;
            for (; i < 3; i++)
            {
                Console.Write("Enter Username:");
                string usernameInput = Console.ReadLine();

                Console.Write("Enter Password:");
                string passwordInput = Console.ReadLine();

                Console.WriteLine();
                if (usernameInput == username && passwordInput == password)
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
                    Console.WriteLine("Invalid Username or Password.");
                }
            }
            if (i == 3)
            {
                Console.WriteLine("Application will exit...");
                Environment.Exit(0);
            }

            var subjectChoices = new[] { "Programming 2", "PE", "English",
                                    "Statistics"};
            var enrolledSubjects = new string[4];

            Console.WriteLine();
            Console.WriteLine("Please enter Y if you want to enroll the  subject or N if not.");
            //iterate through the subjectChoices and get user input if Y or N to be enrolled

            for (int subjectIndex = 0; subjectIndex < subjectChoices.Length; subjectIndex++)
            {
                Console.Write("SUBJECT " + subjectChoices[subjectIndex] + ":");
                char userInput = char.Parse(Console.ReadLine());

                if (userInput == 'Y')
                {
                    enrolledSubjects[subjectIndex] = subjectChoices[subjectIndex];
                } 
                else if (userInput == 'N') { Console.Write(""); }
                else { Console.WriteLine("Invalid Input. Will show next subject..");}
            }

            Console.WriteLine();
            Console.WriteLine("SUBJECTS ENROLLED:");
            foreach (var enrolled in enrolledSubjects)
            {
                //if enrolled is null or empty will not display
                if (!string.IsNullOrEmpty(enrolled))
                {
                    Console.WriteLine(enrolled);
                }
            }
        }
    }
}
