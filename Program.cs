using Exam_Project;
//Subject s = new Subject(1, "english");
//s.CreateExam();

//ToFQuestion toFQuestion = new ToFQuestion();

//toFQuestion.createQuestion();
//toFQuestion.displayQuestion();
//int ans = int.Parse(Console.ReadLine());
//Console.WriteLine( toFQuestion.CheckAnswer(ans));

MCQuestion mcQuestion = new MCQuestion();

mcQuestion.createQuestion();
mcQuestion.displayQuestion();
int ans = int.Parse(Console.ReadLine());
Console.WriteLine(mcQuestion.CheckAnswer(ans));