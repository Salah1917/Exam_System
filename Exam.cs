namespace Exam_Project
{
    public abstract class Exam
    {  
        public Exam(int TimeOfExam, int QuestionCount)
        {
            this.TimeOfExam = TimeOfExam;
            this.QuestionCount = QuestionCount;
        }
        public int TimeOfExam { get; set; }
        public int QuestionCount { get; set; }
      
        public abstract int gradeExam();
        public abstract int showResults();

    }
}
