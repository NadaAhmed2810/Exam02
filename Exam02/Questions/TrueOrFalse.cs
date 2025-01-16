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
        public TrueOrFalse(string header, string body, int mark, int correctAnswer) : base(header, body, mark, correctAnswer)
        {
            Answers = new List<Answer>
            {
                new Answer(1, "True"),
                new Answer(2, "False")
            };

        }

        public override void DisplayQuestion()
        {
            Console.WriteLine($"{Body}\n1.true\n2.False");
        }
    }
}
