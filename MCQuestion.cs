using System.Collections.Generic;

namespace Exam_Project
{
    public class MCQuestion: Question
    {

        public MCQuestion(string Header, string Body, int Mark) : base(Header, Body, Mark) { }
        public string correctAnswerText { get; set; }
        public MCQuestion() { }


        public List<Answer> answers = new List<Answer>();

        public int correctAnswer { get; set; }
        public override int CheckAnswer(int AnswerGiven)
        {
            if (AnswerGiven == correctAnswer)
                return Mark;
            return 0;
        }

        public override void displayQuestion()
        {
            Console.WriteLine(Header);
            Console.WriteLine(Body);
            int i = 1;
            foreach ( Answer answer in answers)
            {
                Console.WriteLine($"{i}. {answer.AnswerText}");
                i++;
            }

            Console.WriteLine("Choose the correct answer:");
        }

        public override void createQuestion()
        {
            this.Header = "Multiple Choice Question";
            
            Console.WriteLine("Enter the question body:");
            this.Body = Console.ReadLine();

            Console.WriteLine("Enter the marks of the question:");
            this.Mark = int.Parse(Console.ReadLine());
            
            for ( int i = 0; i < 3; i++ )
            {
                int j = i + 1;
                Console.WriteLine($"Enter answer #{j}:");
                string answerText = Console.ReadLine();
                Answer answer = new Answer(j, answerText);
                answers.Add(answer);
            }
            
            Console.WriteLine("Specify which answer is correct:");
            this.correctAnswer = int.Parse( Console.ReadLine() );
        }

    }

}
