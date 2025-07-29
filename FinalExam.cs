namespace Exam_Project
{
    public class FinalExam : Exam
    {
        public FinalExam(Question[] questions, int TimeOfExam, int QuestionCount) : base(TimeOfExam, QuestionCount)
        {
            this.questions = questions;
        }
        

        Question[] questions { set; get; }

        public override void createExam()
        {
            throw new NotImplementedException();
        }

        public override int gradeExam()
        {
            throw new NotImplementedException();
        }

        public override void showResults()
        {
            throw new NotImplementedException();
        }
    }
}
