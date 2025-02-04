﻿using Exam02.Answers;
using Exam02.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Exams
{
    internal class FinalExam : Exam
    {
        
        public FinalExam(int time, int numberofQuestion, List<Question> q,int TotalMark) : base(time, numberofQuestion, q,TotalMark)
        {

        }

        public override void ResultOfExam()
        {
            Console.WriteLine("\nExam Results:");
            foreach (var answer in UserAnswers)
            {
                Question question = answer.Key;
                int userAnswer = answer.Value;
                string userAnswerText = question.GetAnswer(userAnswer);
                string correctAnswerText = question.GetAnswer(question.CorrectAnswer);

                Console.WriteLine($"\nQuestion: {question.Body}");
                Console.WriteLine($"Your Answer: {userAnswerText}");
                Console.WriteLine($"Correct Answer: {correctAnswerText}");
                Console.WriteLine($"Mark:{question.Mark}");
            }
            Console.WriteLine($"Your Mark:{Result} from {TotalMark}");
        }

    }
}
