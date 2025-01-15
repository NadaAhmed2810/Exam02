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
        public Question(string Header ,string Body ,int Mark)
        {
            this.Header = Header;
            this.Body = Body;
            this.Mark = Mark;
        }


    }
}
