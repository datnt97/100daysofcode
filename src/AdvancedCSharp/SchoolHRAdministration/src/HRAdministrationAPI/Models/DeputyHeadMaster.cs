namespace HRAdministrationAPI.Models;

public class DeputyHeadMaster : EmployeeBase
{
	public override decimal Salary => base.Salary + (base.Salary * 0.04m);

}