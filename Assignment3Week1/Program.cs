class Student
{
    public int Id { get; init; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Student()
    {
        Id = 0;
        FirstName = "";
        LastName = "";
    }

    public Student(int i)
    {
        Id = i;
        FirstName = "";
        LastName = "";
    }

    public Student(int i, string first, string last)
    {
        Id = i;
        FirstName = first;
        LastName = last;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student(20);
        student1.FirstName = "John";
        student1.LastName = "Smith";

        Student student2 = new Student(30, "Jane", "Smith");

        Console.WriteLine($"Student 1 - ID: {student1.Id}, First Name: {student1.FirstName}, Last Name: {student1.LastName}");
        Console.WriteLine($"Student 2 - ID: {student2.Id}, First Name: {student2.FirstName}, Last Name: {student2.LastName}");
    }
}
