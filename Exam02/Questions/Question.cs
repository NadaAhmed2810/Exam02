using Exam02.Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Questions
{
    internal abstract class Question
    {
      
        public  string Header { get; set; }
        public  string Body { get; set; }
        public int Mark {  get; set; }
        public List<Answer>Answers { get; set; }
        public int  CorrectAnswer { get; set; }
        #region Constructor
        protected Question(string header, string body, int mark, int correctAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            Answers = new List<Answer>();
            CorrectAnswer = correctAnswer;
        }
        protected Question(string header, string body, int mark,List<Answer>answers, int correctAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            Answers = answers;
            CorrectAnswer = correctAnswer;
        }
        #endregion

        public abstract void DisplayQuestion();
        public string GetAnswer(int Id)
        {
            Answer?  answer = Answers.Find(a => a.AnswerId == Id);
            return answer is not null ? answer.AnswerText : "Answer not exist.";
          
        }
        public bool AnswerIsCorrect(int Id)
        {
            return Id == CorrectAnswer;
        }
    }
}
