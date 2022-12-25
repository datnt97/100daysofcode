using DatntEmployyShop.HR;

public class Employee : IEmployee, IComparable
{
	private int id;
	private string firstName;
	private string lastName;

	private int numberOfHoursWorked;
	private double wage;
	private double hourlyRate;

	public int Id
	{
		get => id;
		set => id = value;
	}

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

	public Employee(int id, string firstName, string lastName, double hourlyRate)
	{
		Id = id;
		FirstName = firstName;
		LastName = lastName;
		HourlyRate = hourlyRate;
	}

	public virtual void PerformWork(int hoursWorked)
	{
		NumberOfHoursWorked += hoursWorked;
	}

	public double ReceiveWage()
	{
		Console.WriteLine($"The wage for {NumberOfHoursWorked} hours worked is {Wage}");
		ResetNumberOfHoursWorkedAfterReceiveWage();

		return Wage;
	}

	private void ResetNumberOfHoursWorkedAfterReceiveWage()
	{
		NumberOfHoursWorked = 0;
	}

	public void PerformWork()
	{
		this.PerformWork(0);
	}

	public void ReceiveCompliment()
	{
		Console.WriteLine($"You've done a great job, {FullName}");
	}

	public int CompareTo(object? obj)
	{
		var employee = (Employee)obj;
		if (id > employee.Id)
			return 1;
		else if (id < employee.Id)
			return -1;
		else
			return 0;
	}
}
