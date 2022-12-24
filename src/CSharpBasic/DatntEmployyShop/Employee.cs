// See https://aka.ms/new-console-template for more information
using System.Reflection.Emit;

public class Employee
{
	private string firstName;
	private string lastName;

	private int numberOfHoursWorked;
	private double wage;
	private double hourlyRate;

	public string FirstName
	{
		get => firstName;
		set => firstName = value;
	}

	public string LastName
	{
		get { return lastName; }
		set
		{
			lastName = value;
		}
	}

	public int NumberOfHoursWorked
	{
		get
		{
			return numberOfHoursWorked;
		}

		set
		{
			numberOfHoursWorked = value;
		}
	}

	public double Wage
	{
		get => numberOfHoursWorked * hourlyRate;
	}

	public double HourlyRate
	{
		get { return hourlyRate; }
		set
		{
			hourlyRate = value;
		}
	}

	public string FullName => $"{firstName} {lastName}";

	public Employee(string firstName, string lastName, double hourlyRate)
	{
		FirstName = firstName;
		LastName = lastName;
		HourlyRate = hourlyRate;
	}

	public void PerformWork(int hoursWorked)
	{
		NumberOfHoursWorked += hoursWorked;
	}

	public double RecieveWage()
	{
		Console.WriteLine($"The wage for {NumberOfHoursWorked} is {Wage}");
		ResetNumberOfHoursWorkedAfterRecieveWage();

		return Wage;
	}

	private void ResetNumberOfHoursWorkedAfterRecieveWage()
	{
		NumberOfHoursWorked = 0;
	}
}
