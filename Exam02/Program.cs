using Exam02.Exams;
using Exam02.Subjects;

namespace Exam02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Exam Management System:)");


            bool f = false;
            int subjectId;
            do 
            {
                Console.Write("Enter the Subject ID:");
                f=int.TryParse(Console.ReadLine(), out subjectId);
            } while (!f);
           

            Console.Write("Enter the Subject Name:");
            string subjectName = Console.ReadLine();
           

            Subject subject = new Subject(subjectId, subjectName);
            

            Console.WriteLine($"\nSubject '{subject.SubjectName}' created successfully!\n");
            subject.CreateExam();
            Console.Clear();
         
            int flag;
            f = false;
            do
            {
                Console.WriteLine("\nExam is ready. Do you want to start the exam now? (1 for yes/ 2 for no)");
                f=int.TryParse(Console.ReadLine(), out flag);   
            } while (!f ||(flag!= 1 && flag != 2));

            if (flag==1)
            {
                if (subject is null || subject.exam is null )
                {
                    Console.Write("wroong");
                    return;
                }
                else subject.exam.showExam();

                // Step 4: Show results
                if (subject.exam is FinalExam)
                {
                    Console.WriteLine("\nFinal Exam Completed. Results:");
                }
                else if (subject.exam is PracticalExam)
                {
                    Console.WriteLine("\nPractical Exam Completed.");
                }
                subject.exam.ResultOfExam();
               
            }
            else
            {
                Console.WriteLine("Exam creation completed. You can start it later.");
            }

           
        }
    }
}
    

