namespace HRAdministrationAPI.Models;

public class HeadOfDepartment : EmployeeBase
{
	public override decimal Salary => base.Salary + (base.Salary * 0.03m);

}