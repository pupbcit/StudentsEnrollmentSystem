using System;

namespace StudentEnrollmentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentModule.DisplayWelcomeMessage();
            var numberOfRetries = StudentModule.LoginStudent();

            if (numberOfRetries == 3)
            {
                Console.WriteLine("Application will exit...");
                Environment.Exit(0);
            }
            StudentModule.EnrollSubjects();
            StudentModule.DisplayEnrolledSubjects();
            StudentModule.DisplayStudentInfo();
        }
    }
}
