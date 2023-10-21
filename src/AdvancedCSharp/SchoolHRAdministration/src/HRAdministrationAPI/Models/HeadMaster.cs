namespace HRAdministrationAPI.Models;

public class HeadMaster : EmployeeBase
{
	public override decimal Salary => base.Salary + (base.Salary * 0.05m);

}