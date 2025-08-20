using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Examination_System
{
    internal class PracticalExam: Exam
    {
        public PracticalExam(int time, int numQuestions)
        : base(time, numQuestions) { }

        public override void ShowExam()
        {
            Console.WriteLine("=== Practical Exam ===");

            foreach (var q in Questions)
            {
                q.DisplayQuestion();
                Console.Write("Your Answer: ");
                int ansId = int.Parse(Console.ReadLine());

                Console.WriteLine($"Correct Answer: {q.RightAnswer.AnswerText}\n");
            }
        }
    }
}
