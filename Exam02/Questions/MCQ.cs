using Exam02.Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Questions
{
    internal class MCQ : Question
    {
        
        public MCQ(string header, string body, int mark, List<Answer> answers, int correctAnswer) : base(header, body, mark,answers,correctAnswer)
        {
            
            
        }

        public override void DisplayQuestion()
        {
            Console.WriteLine($"{Header} {Body}\n");
            for (int i = 0; i < Answers.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Answers[i].AnswerText}");
            }
        }
       

       
    }
}
