namespace Exam_Project
{
    public class Answer
    {
        Answer(int AnswerId, string AnsweText) 
        {
            this.AnswerId = AnswerId;
            this.AnswerText = AnsweText;
        }

        public int AnswerId { get; set; }
        public string AnswerText { get; set; }


    }
}
