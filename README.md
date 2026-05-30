# Exam System — Console-Based Examination Application

A C# console application for creating, displaying, and grading two types of exams: **Practical Exams** (MCQ-only) and **Final Exams** (mixed True/False and Multiple Choice Questions). Built as a learning project demonstrating object-oriented programming principles in C#.

## Tech Stack

- **Language:** C# (.NET 9.0)
- **Project Type:** Console Application
- **Dependencies:** None (pure .NET base class library)
- **IDE:** Visual Studio 2022

## Class Hierarchy

```
Subject
  └── CreateExam()
       ├── PracticalExam : Exam
       │    └── MCQuestion : Question → Answer
       └── FinalExam : Exam
            ├── MCQuestion : Question → Answer
            └── ToFQuestion : Question
```

- **Exam** (abstract) — holds TimeOfExam, QuestionCount, Mark; defines `createExam()` and `showResults()`
- **Question** (abstract) — holds Header, Body, Mark; defines `createQuestion()`, `displayQuestion()`, `CheckAnswer()`
- **FinalExam** — Mix of ToF and MCQ questions with full grading
- **PracticalExam** — MCQ-only, shows correct answers at the end (review mode, no grading)

## Features

- Interactive exam creation (user chooses type, number of questions, and answers)
- True/False questions (1 = True, 2 = False)
- Multiple Choice questions with 3 options
- Automatic grading for Final Exams with score display
- Review mode for Practical Exams (shows correct answers)

## How It Works

1. Program prompts the user to select exam type (Practical or Final)
2. User specifies the number of questions and provides question details
3. For Final Exams: student answers each question, system grades and displays total score
4. For Practical Exams: system displays all correct answers for review
