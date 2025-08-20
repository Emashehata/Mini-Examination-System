namespace Mini_Examination_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject sub = new Subject(1, "Programming");

             
            FinalExam exam = new FinalExam(60, 2);

            MCQQuestion q1 = new MCQQuestion("What is OOP?", 5);
            q1.AnswerList.Add(new Answer(1, "Object Oriented Programming"));
            q1.AnswerList.Add(new Answer(2, "Only Old Programs"));
            q1.RightAnswer = q1.AnswerList[0];

            TrueFalseQuestion q2 = new TrueFalseQuestion("C# is a language.", 5);
            q2.RightAnswer = q2.AnswerList[0];

            exam.Questions.Add(q1);
            exam.Questions.Add(q2);

            sub.CreateExam(exam);

            // Show Exam
            sub.Exam.ShowExam();
        }
    }
}
