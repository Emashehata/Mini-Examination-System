using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Examination_System
{
    internal class FinalExam: Exam
    {
        public FinalExam(int time, int numQuestions)
       : base(time, numQuestions) { }

        public override void ShowExam()
        {
            Console.WriteLine("***** Final Exam *****");
            int totalGrade = 0;

            foreach (var q in Questions)
            {
                q.DisplayQuestion();
                Console.Write("Your Answer: ");
                int ansId = int.Parse(Console.ReadLine());

                if (q.RightAnswer != null && ansId == q.RightAnswer.AnswerId)
                    totalGrade += q.Mark;
            }

            Console.WriteLine($"Your Grade: {totalGrade}/{Questions.Count}");
        }
    }
}
