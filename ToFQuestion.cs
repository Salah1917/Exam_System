namespace Exam_Project
{
    public class ToFQuestion : Question
    {
        public ToFQuestion(string Header, string Body, int Mark) : base(Header, Body, Mark) { }

        public override bool CheckAnswer()
        {
            throw new NotImplementedException();
        }

        public override void displayQuestion()
        {
            throw new NotImplementedException();
        }
    }
}
