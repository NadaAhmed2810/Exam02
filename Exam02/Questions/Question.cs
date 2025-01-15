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
      
        public required string Header { get; set; }
        public required string Body { get; set; }
        public int Mark {  get; set; }
        public List<Answer>Answers { get; set; }
        public int  CorrectAnswer { get; set; }
        protected Question(string header, string body, int mark, List<Answer> answers, int correctAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            Answers = answers?? new List<Answer>();
            CorrectAnswer = correctAnswer;
        }
        public abstract void DisplayQuestion();
        public bool AnswerIsCorrect(int Id)
        {
            return Id == CorrectAnswer;
        }
    }
}
