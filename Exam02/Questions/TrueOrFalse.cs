using Exam02.Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Questions
{
    internal class TrueOrFalse : Question
    {
        public TrueOrFalse(string header, string body, int mark, List<Answer> answers, int correctAnswer) : base(header, body, mark, answers, correctAnswer)
        {
            header = "True Or False Question";
        }

        public override void DisplayQuestion()
        {
            Console.WriteLine($"{Header} {Body}\n1. True\n2. False");
        }
    }
}
