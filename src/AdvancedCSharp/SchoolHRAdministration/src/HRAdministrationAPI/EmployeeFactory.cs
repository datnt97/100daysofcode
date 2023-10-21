using HRAdministrationAPI.Enums;
using HRAdministrationAPI.Models;

namespace HRAdministrationAPI;

public static class EmployeeFactory
{
	public static IEmployee GetEmployeeInstance(
		EmployeeType employeeType,
		int id,
		string firstName,
		string lastName,
		decimal salary) => employeeType switch
		{
			EmployeeType.Teacher => new Teacher { Id = id, FirstName = firstName, LastName = lastName, Salary = salary },
			EmployeeType.HeadOfDepartment => new HeadOfDepartment { Id = id, FirstName = firstName, LastName = lastName, Salary = salary },
			EmployeeType.DeputyHeadMaster => new DeputyHeadMaster { Id = id, FirstName = firstName, LastName = lastName, Salary = salary },
			EmployeeType.HeadMaster => new HeadMaster { Id = id, FirstName = firstName, LastName = lastName, Salary = salary },
			_ => throw new ArgumentOutOfRangeException("Unknown Employee type.")
		};
}
