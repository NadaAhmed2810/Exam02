using Exam02.Answers;
using Exam02.Exams;
using Exam02.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exam02.Subjects
{
    internal class Subject
    {
        #region property
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam? exam { get; set; }
        #endregion


        #region Constructor
        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
            exam = null;
        }
        #endregion

        #region Methods
        private Question CreateQuestion(int examType)
        {
            bool f = false;
            int typeofQuestion;
            #region Validation Question
            //valid Question
            if (examType == 1)
            {
                do
                {

                    Console.WriteLine("Choose question type: 1. True/False  2. MCQ");

                    f = int.TryParse(Console.ReadLine(), out typeofQuestion);

                } while (!f || (typeofQuestion != 1 && typeofQuestion != 2));
            }
            else
            {
                Console.WriteLine("MCQ Question:");
                typeofQuestion = 2;
            }
            #endregion
            string header, body,answertext;
            do
            {
                Console.WriteLine("Enter the question body:");
                body = Console.ReadLine();
            } while (body == default || body == "");

            int mark;
            do
            {
                Console.WriteLine("Enter the mark for this question:");

                f = int.TryParse(Console.ReadLine(), out mark);

            } while (!f);

            #region Create Questions
            if (typeofQuestion == 1)
            {
                header = "True OR False";
                f = false;
                int correctAnswerId; do
                {
                    Console.WriteLine("Enter the correct answer (1 for True, 2 for False):");
                    f = int.TryParse(Console.ReadLine(), out correctAnswerId);
                } while (!f || (correctAnswerId != 1 && correctAnswerId != 2));
                return new TrueOrFalse(header, body, mark, correctAnswerId);
            }
            else
            {
                header = "MCQ";
                List<Answer> answers = new List<Answer>();

                for (int j = 1; j <= 4; j++)
                {
                    do
                    {
                        Console.WriteLine($"Enter  Answer {j}:");
                        answertext = Console.ReadLine();
                    } while (answertext == default || answertext == "" || answertext is null);
                  
                    answers.Add(new Answer(j, answertext));
                }
                int correctAnswerId;
                do
                {
                    Console.WriteLine("Enter the correct answer ID (1-4):");
                    f = int.TryParse(Console.ReadLine(), out correctAnswerId);
                } while (!f || (correctAnswerId < 1 || correctAnswerId > 4));



                return new MCQ(header, body, mark, answers, correctAnswerId);
            }
            #endregion
        }

        public void CreateExam()
        {
            int examType, total = 0;
            bool f = false;
            #region ExamType
            //valid Exam
            do
            {
                Console.WriteLine("Choose exam type: 1. Final Exam  2. Practical Exam");
                f = int.TryParse(Console.ReadLine(), out examType);

            } while (!f || (examType != 1 && examType != 2));

            #endregion

            #region Minutes
            f = false;
            int minutes;
            //valid minutes
            do
            {
                Console.WriteLine("Enter exam duration (in minutes):");
                f = int.TryParse(Console.ReadLine(), out minutes);

            } while (!f);
            #endregion
            #region NumberOfQuestion
            //valid #Question
            int numberofquestion;
            do
            {
                Console.WriteLine("Enter of Number Of Question");
                f = int.TryParse(Console.ReadLine(), out numberofquestion);

            } while (!f);
            #endregion
            #region Add Questions
            List<Question> questions = new List<Question>();
            for (int i = 0; i < numberofquestion; i++)
            {
                Question question = CreateQuestion(examType);
                total += question.Mark;
                questions.Add(question);

            }
            #endregion
            #region Create Exam
            if (examType == 1)
            {
                exam = new FinalExam(minutes, numberofquestion, questions, total);

            }
            else if (examType == 2)
            {
                exam = new PracticalExam(minutes, numberofquestion, questions, total);
            }
            #endregion

        } 
        #endregion

    }
 }
