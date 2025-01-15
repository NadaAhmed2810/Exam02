using Exam02.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Exam
{
    internal abstract class Exam
    {
      

        public DateTime Time {  get; set; }
        public int NumberOfQuestions {  get; set; }
        public List<Question> Questions { get; set; }
        protected Exam(DateTime time, int numberOfQuestions, List<Question> questions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
            Questions = questions;
        }
        public abstract void showExam();

    }
}
