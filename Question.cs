namespace Exam_Project
{
    public abstract class Question
    {
        public Question(string Header, string Body, int Mark) 
        {
            this.Header = Header;
            this.Body = Body;
            this.Mark = Mark;
        }
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public abstract bool CheckAnswer();
        public abstract void displayQuestion();
    }
}
