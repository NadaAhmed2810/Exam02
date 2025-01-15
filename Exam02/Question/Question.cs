using Exam02.Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Question
{
    internal abstract class Question
    {
      
        public required string Header { get; set; }
        public required string Body { get; set; }
        public int Mark {  get; set; }
        public List<Answer>Answers { get; set; }
        public Answer CorrectAnswer { get; set; }
        protected Question(string header, string body, int mark, List<Answer> answers, Answer correctAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            Answers = answers?? new List<Answer>();
            CorrectAnswer = correctAnswer;
        }



    }
}
