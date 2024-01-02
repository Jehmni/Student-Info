using System;

public class Student
{
	private string name, id;
	private int age;
	
	// Constructors (default constructor and for when values are provided)
	public Student()
	{
		this.name= null;
		this.age= 0;
		this.id= "-";
	}
	public Student(string studName, int age, string studId)
	{
		this.name = studName;
		this.age = age;	
		this.id = studId;
	}


	// Properties getters and setters
	public string Name {get {return name; } set { name = value; } }
	public int Age { get {return age; } set { age = value; } }
	public string Id { get {return id; } set { id = value; } }

	// Method to write student information on screen
	public void GetInformation()
	{
		Console.WriteLine(name + ", with Student-ID " +id+ " is " +age+ " years old.");
		Console.WriteLine();
	}
	
}

