using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Examination_System
{
    internal class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string body, int mark)
        : base("True/False Question", body, mark)
        {
            AnswerList.Add(new Answer(1, "True"));
            AnswerList.Add(new Answer(2, "False"));
        }

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
