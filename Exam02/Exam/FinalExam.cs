﻿using Exam02.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Exam
{
    internal class FinalExam:Exam
    {
        public FinalExam(DateTime time, int numberofQuestion, List<Question> q) : base(time, numberofQuestion, q)
        {

        }
        public override void showExam()
        {
            throw new NotImplementedException();
        }
    }
}
