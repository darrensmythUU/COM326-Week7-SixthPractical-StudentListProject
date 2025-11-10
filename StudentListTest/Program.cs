using SixthPractical_StudentListProject;

class Program
{
    static void Main(string[] args)
    {
        string studentName;
        int studentAge;
        List<Student> studentList = new List<Student>();

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Please enter the student's name: ");
            studentName = Console.ReadLine();

            Console.WriteLine("Please enter the student's age: ");
            studentAge = Convert.ToInt32(Console.ReadLine());

            studentList.Add(new Student(studentName, studentAge));
        }

        foreach (Student student in studentList)
        {
            student.DisplayInfo();
        }
    }
}