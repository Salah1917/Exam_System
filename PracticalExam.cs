namespace Exam_Project
{
    public class PracticalExam : Exam
    {

        public PracticalExam(int _TimeOfExam, int _QuestionCount) : base(_TimeOfExam, _QuestionCount){}
        //public PracticalExam() { }

        List<MCQuestion> mCQuestions = new List<MCQuestion>();

        public override void showResults()
        {
            int i = 1;
            foreach (MCQuestion question in mCQuestions)
            {
                Console.WriteLine($"Correct answer for question #{i}: {question.answers[question.correctAnswer - 1].AnswerText}");
                i++;
            }
        }

        public override void createExam()
        {
            Console.WriteLine("How many questions do you want?");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                MCQuestion mCQuestion = new MCQuestion();
                mCQuestion.createQuestion();
                
                mCQuestions.Add(mCQuestion);
            }
        }

        public void showExam()
        {
            foreach (MCQuestion question in mCQuestions)
            {
                question.displayQuestion();
                int answerGiven = int.Parse(Console.ReadLine());
            }
        }
    }
}
