using Exam02.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Exams
{
    internal abstract class Exam
    {
      

        public int Time {  get; set; }
        public int NumberOfQuestions {  get; set; }
        public List<Question> Questions { get; set; }
        protected Dictionary<Question, int> UserAnswers = new Dictionary<Question, int>();
        public int Result { get; protected set; } 
        public int TotalMark {  get; protected set; }
        protected Exam(int time, int numberOfQuestions, List<Question> questions,int total)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
            Questions = questions;
            TotalMark = total;
            Result= 0;
        }
        #region Methods

        public virtual void showExam()
        {
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
                    this.Result += question.Mark;
                }
                Console.WriteLine();
                Console.Clear();

            }
        }


        public abstract void ResultOfExam();
        
        #endregion


    }
}
