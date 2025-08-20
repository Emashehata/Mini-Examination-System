📘 Examination System
📌 Overview

This project implements an Examination System in C# following Object-Oriented Programming (OOP) concepts such as inheritance, abstraction, polymorphism, interfaces, and associations.
It supports multiple exam types (Final Exam and Practical Exam) and different question types (True/False and MCQ).

✨ Features

Question Object

Contains:

Header

Body

Mark

Array of Answers (with the correct one).

Question Types

True/False Question (for Final Exam).

MCQ Question (for both Practical & Final Exams).

Exam Types

Final Exam: Shows Questions, Answers, and Grade.

Practical Exam: Shows Questions and displays the right answers after finishing.

Answer Object

Includes AnswerId and AnswerText.

Subject Object

Contains SubjectId, SubjectName, and the Exam of the subject.

Allows creating exams for subjects.

OOP Concepts Used

Abstraction & Inheritance → Base classes (Question, Exam) with derived types.

Interface Implementation → ICloneable, IComparable.

Constructor Chaining.

ToString Override for readable outputs.

📂 Project Structure
Assignment/
│
├── Models/
│   ├── Answer.cs
│   ├── Question.cs (abstract)
│   ├── MCQQuestion.cs
│   ├── TrueFalseQuestion.cs
│   ├── Exam.cs (abstract)
│   ├── FinalExam.cs
│   ├── PracticalExam.cs
│   └── Subject.cs
│
├── Program.cs   // Entry point
└── README.md

🛠️ Usage

Create a Subject object.

Attach an Exam (Final or Practical).

Add Questions and Answers to the Exam.

Run the ShowExam() method to start the exam.

📌 Example (Main Method)
static void Main(string[] args)
{
    Subject math = new Subject(1, "Mathematics");

    Exam exam = new FinalExam(60, 2);
    exam.Questions.Add(new TrueFalseQuestion("Q1", "2+2=4?", 1, true));
    exam.Questions.Add(new MCQQuestion("Q2", "Capital of France?", 2,
        new List<Answer> {
            new Answer(1,"Berlin"),
            new Answer(2,"Paris"),
            new Answer(3,"Rome")
        }, 2));

    math.Exam = exam;
    math.Exam.ShowExam();
}

📊 UML Diagram
Subject → Exam → Question → Answer
Exam: FinalExam, PracticalExam
Question: MCQQuestion, TrueFalseQuestion

✅ Future Enhancements

Add database persistence for exams & results.

Add user/student management.

Add GUI instead of console-based interface.
