using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace Exam_Project
{
    public class FinalExam : Exam
    {
        public FinalExam(int TimeOfExam, int QuestionCount) : base(TimeOfExam, QuestionCount)
        {

        }


        public List<Question> questions = new List<Question>();
        public int Mark { get; set; }

        ArrayList answers = new ArrayList();

        public override void createExam()
        {
            Console.WriteLine("How Many questions do you want?");
            int questionCount = int.Parse(Console.ReadLine());
            for (int i = 1; i <= questionCount; i++)
            {
                Console.WriteLine($"What is the type of Question {i} (1 for ToF and 2 for MCQ)");
                int questionType = int.Parse(Console.ReadLine());

                if (questionType == 1)
                {
                    ToFQuestion toFQuestion = new ToFQuestion();
                    toFQuestion.createQuestion();
                    questions.Add(toFQuestion);
                }

                else if (questionType == 2)
                {
                    MCQuestion mCQuestion = new MCQuestion();
                    mCQuestion.createQuestion();
                    this.questions.Add(mCQuestion);
                }
            }
        }

        public int gradeExam()
        {
            for(int i = 0; i < questions.Count; i++)
            {
                Mark += questions[i].CheckAnswer((int) answers[i]);
            }
            return Mark;
        }

        public void showExam()
        {
            foreach (Question question in questions)
            {
                question.displayQuestion();
                int answerGiven = int.Parse(Console.ReadLine());
                answers.Add(answerGiven);
            }
        }

        public override void showResults()
        {
            Console.WriteLine($"You scored {Mark} Marks");
        }
    }
}
