namespace HRAdministrationAPI.Models;

public class Teacher : EmployeeBase
{
	public override decimal Salary => base.Salary + (base.Salary * 0.02m);
}