namespace Exam_Project
{
    public class Subject
    {
        Exam[] exams { set; get; }
        public int SubjectId { get; set; }
        public string Name { get; set; }

        public Subject(int SubjectId, string Name) 
        {
            this.SubjectId = SubjectId;
            this.Name = Name;
        }

        public void CreateExam()
        {
            Console.WriteLine("What Exam do you want to create?");
            Console.WriteLine("1.Practical Exam\n2.Final Exam");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    CreatePracticalExam();
                    break;
                case 2:
                    CreateFinalExam();
                    break;
                default:
                    Console.WriteLine("Please enter a valid choice!");
                    break;
            }
        }

        public void CreatePracticalExam()
        {
            PracticalExam practicalExam = new PracticalExam(60, 5);
        }
        public void CreateFinalExam()
        {

        }
    }
}
