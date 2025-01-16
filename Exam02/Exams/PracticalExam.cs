using Exam02.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Exams
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(int time ,int numberofQuestion, List<Question> q,int TotalMark) : base(time, numberofQuestion, q,TotalMark)
        {

        }
        public override void showExam()
        {
            Console.WriteLine("Practical Exam\n");
            Result = 0;

            foreach (var question in Questions)
            {
                bool f = false;
                int answer;
                do
                {
                    question.DisplayQuestion();
                    Console.Write("Your Answer: ");

                    f = int.TryParse(Console.ReadLine(), out answer);

                } while (!f);
                UserAnswers.Add(question, answer);
                if (question.AnswerIsCorrect(answer))
                {
                    Result += question.Mark;
                }
                Console.WriteLine();
            }
        }
        public override void ResultOfExam()
        {
            int i = 0;
            foreach (var answer in UserAnswers)
            {
                Question question = answer.Key;
               
                string correctAnswerText = question.GetAnswer(question.CorrectAnswer);
                Console.WriteLine($"Correct Answer for Q{++i}: {correctAnswerText}");
                Console.WriteLine($"Mark:{question.Mark}");
            }
            Console.WriteLine($"\nExam Results:{Result} from {TotalMark}");
          
        }
    }
}
