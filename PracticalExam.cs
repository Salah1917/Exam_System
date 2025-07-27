namespace Exam_Project
{
    public class PracticalExam : Exam
    {

        public PracticalExam(int _TimeOfExam, int _QuestionCount) : base(_TimeOfExam, _QuestionCount)
        {
            MCQuestion[] mCQuestions = new MCQuestion[_QuestionCount];
            for(int i = 0; i < _QuestionCount; i++)
            {
                mCQuestions[i] = createMCQuestion();
            }
            this.mCQuestions = mCQuestions;
            //PracticalExam practicalExam = new PracticalExam(mCQuestions, _TimeOfExam,  _QuestionCount);

        }
        //public PracticalExam(MCQuestion[] mCQuestions, int _TimeOfExam, int _QuestionCount) : base(_TimeOfExam, _QuestionCount)//{}

        MCQuestion[] mCQuestions { set; get; }
        
        public override int gradeExam()
        {
            throw new NotImplementedException();
        }

        public override int showResults()
        {
            throw new NotImplementedException();
        }
        public MCQuestion createMCQuestion()
        {
            Console.WriteLine("Enter the question header:");
            string questionHeader = Console.ReadLine();
            Console.WriteLine("Enter the question body:");
            string questionBody = Console.ReadLine();
            Console.WriteLine("Enter the question mark:");
            int questionMark = int.Parse(Console.ReadLine());
            MCQuestion question = new MCQuestion(questionHeader, questionBody, questionMark);
            return question;
        }
    }
}
