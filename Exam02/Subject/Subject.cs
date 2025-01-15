using Exam02.Exams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exam02.Subject
{
    internal class Subject
    {
        public int SubjectId {  get; set; }
        public string SubjectName {  get; set; }
        public Exam exam { get; set; }
        public void CreateExam()
        {
            exam.showExam();
        }
    }
}
