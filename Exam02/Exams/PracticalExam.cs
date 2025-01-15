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
        public PracticalExam(DateTime time ,int numberofQuestion, List<Question> q) : base(time, numberofQuestion, q)
        {

        }
        public override void showExam()
        {
            throw new NotImplementedException();
        }
    }
}
