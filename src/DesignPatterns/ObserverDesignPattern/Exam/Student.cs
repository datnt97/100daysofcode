using ObserverDesignPattern.Exam;
using System;

public class Student : IStudent
{
	private string name;
	private double grade;
	public Student(string name, double grade)
	{
		this.name = name;
		this.grade = grade;
	}

	public void CalculateRateOfGrade(Exam exam, double oldMaxGrade)
	{
		Console.WriteLine($"Student {name} has {grade} on maximum {oldMaxGrade}: {grade/oldMaxGrade}");
		Console.WriteLine($"Now, Grade of {name} is {grade} on maximum {exam.MaxGrade}: {grade * exam.MaxGrade/oldMaxGrade}");
	}
}