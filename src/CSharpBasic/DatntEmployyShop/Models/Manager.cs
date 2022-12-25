// See https://aka.ms/new-console-template for more information
public class Manager : Employee
{
	public Manager(int id, string firstName, string lastName, double hourlyRate) : base(id, firstName, lastName, hourlyRate)
	{
	}

	public override void PerformWork(int hoursWorked)
	{
		base.PerformWork(hoursWorked);
		Console.WriteLine($"Manager {FullName} is working!");
	}
	public void AttendManagerMeeting()
	{
		Console.WriteLine($"Manager {FullName} is attending a meeting right now!");
	}
}