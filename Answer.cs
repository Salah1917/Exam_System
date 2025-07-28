namespace Exam_Project
{
    public class Answer
    {
        public Answer(int AnswerId, string AnswerText) 
        {
            this.AnswerId = AnswerId;
            this.AnswerText = AnswerText;
        }

        public int AnswerId { get; set; }
        public string AnswerText { get; set; }


    }
}
