using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Examination_System
{
    internal class MCQQuestion: Question
    {
        public MCQQuestion(string body, int mark)
        : base("MCQ Question", body, mark) { }

        public override void DisplayQuestion()
        {
            Console.WriteLine(this);
            foreach (var ans in AnswerList)
            {
                Console.WriteLine(ans);
            }
        }
    }
}
