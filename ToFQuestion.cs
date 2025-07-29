namespace Exam_Project
{
    public class ToFQuestion : Question
    {
        public ToFQuestion(string Header, string Body, int Mark) : base(Header, Body, Mark) { }
        public ToFQuestion() { } 
        public bool Answer { get; set; }
        public override int CheckAnswer(int AnswerGiven)
        {
            if (Answer && AnswerGiven == 1)
                return Mark;
            else if (!Answer && AnswerGiven == 2)
                return Mark;
            else return 0;
        }
        
        public override void displayQuestion()
        {
            Console.WriteLine(Header);
            Console.WriteLine(Body);
            Console.WriteLine("1 for True and 2 For False:");
        }
        public override void createQuestion()
        {
            this.Header = "True or False Question";

            Console.WriteLine("Enter the body of the question:");
            this.Body = Console.ReadLine();
            
            Console.WriteLine("Enter the marks of the question:");
            this.Mark = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Please enter the right answer of the question (1 for True and 2 for False)");
            
            int AnswerInt = int.Parse(Console.ReadLine());
            if(AnswerInt == 1) this.Answer = true;
            else if(AnswerInt == 2) this.Answer = false;
        }
    }
}
