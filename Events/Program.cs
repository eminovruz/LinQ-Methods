namespace Models;

static class ExtensionMethods
{
	static public void Show(this IEnumerable<Student> students)
    {
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }
}


public class Student
{
	public int Id { get; set; }
	public string? Name { get; set; }
	public string? Surname { get; set; }
	public float Score { get; set; }
	public DateOnly BirthDate { get; set; }


	public static List<Student> GetStudents() => new List<Student>
	{
		new Student{ Id = 1, Name = "Royal", Surname = "Bedelli", Score = 10, BirthDate = new DateOnly(2000, 1, 11) },
		new Student{ Id = 2, Name = "Nihat", Surname = "Canheban", Score = 10, BirthDate = new DateOnly(2000, 1, 11) },
		new Student{ Id = 1, Name = "Huseyn", Surname = "Hemidov", Score = 10, BirthDate = new DateOnly(2000, 1, 11) },
		new Student{ Id = 4, Name = "Mirtalib", Surname = "Huseynzade", Score = 10, BirthDate = new DateOnly(2000, 1, 11) },
		new Student{ Id = 5, Name = "Huseyn", Surname = "Ibrahimov", Score = 10, BirthDate = new DateOnly(2000, 1, 11) },
		new Student{ Id = 6, Name = "Murad", Surname = "Meherremli", Score = 10, BirthDate = new DateOnly(2000, 1, 11) },
		new Student{ Id = 7, Name = "Isa", Surname = "Memmedli", Score = 10, BirthDate = new DateOnly(2000, 1, 11) },
		new Student{ Id = 9, Name = "Emin", Surname = "Novruz", Score = 10, BirthDate = new DateOnly(2000, 1, 11) },
		new Student{ Id = 8, Name = "Resul", Surname = "Qasimov", Score = 10, BirthDate = new DateOnly(2000, 1, 11) }
	};

	public override string ToString() => $@"
Id: {Id}
Name: {Name}
Surname: {Surname}
Score: {Score}
BirthDate: {BirthDate.ToShortDateString()}";

}



class Program
{
	static void Main()
	{
        // example 1

        Console.WriteLine("Example 1");

        List<int> numbers = new List<int>();

        numbers.AddRange(new int[] { 11, 11, 39, 902, 1, 3 });

        numbers = numbers.Distinct().ToList();

        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("-----------------------------------------------");

        // example 1

        Console.WriteLine("Example 2");

        var students = Student.GetStudents();

        students = students.DistinctBy(s => { return s.Id; }).ToList();

        foreach (var item in students)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("-----------------------------------------------");

        Console.WriteLine("Task 1");

        students.DistinctBy(s => { return s.Id; }).Show();

        Console.WriteLine("-----------------------------------------------");

        Console.WriteLine("Task 2");



        var count = students.Count(s => s.Score > 9);
        Console.WriteLine(count);

        Console.WriteLine("-----------------------------------------------");

        Console.WriteLine("Example 3");


        Console.WriteLine(students.Skip(2).Take(3).Sum(s => s.Score));
        Console.WriteLine(students.Skip(2).Take(3).Count(s => s.Score > 10));



















    }
}
