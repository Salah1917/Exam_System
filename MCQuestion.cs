namespace Exam_Project
{
    public class MCQuestion: Question
    {

        public MCQuestion(string Header, string Body, int Mark) : base(Header, Body, Mark) { }
        Answer[] answers { set; get; }

        public override int CheckAnswer(int AnswerGiven)
        {
            throw new NotImplementedException();
        }

        public override void displayQuestion()
        {
            throw new NotImplementedException();
        }

        public override void createQuestion()
        {
            Console.WriteLine("Enter the question H");
            throw new NotImplementedException();
        }

    }

}
