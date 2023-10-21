using HRAdministrationAPI;
using HRAdministrationAPI.Enums;

//decimal totalSalaries = 0;
List<IEmployee> employees = new();

SeedData(employees);

//foreach (var employee in employees)
//{
//	totalSalaries += employee.Salary;
//}

//Console.WriteLine($"Total Annual Salaries (including bonus): {totalSalaries}");

Console.WriteLine($"Total Annual Salaries (including bonus): {employees.Sum(e => e.Salary)}");

Console.ReadKey();

static void SeedData(List<IEmployee> employees)
{
	var firstTeacher = EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 1, "Nguyễn", "Van A", 40000);
	employees.Add(firstTeacher);

	var secondTeacher = EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 2, "Jenny", "Thomas", 40000);
	employees.Add(secondTeacher);

	var headOfDepartment = EmployeeFactory.GetEmployeeInstance(EmployeeType.HeadOfDepartment, 3, "Brenda", "Mullins", 50000);
	employees.Add(headOfDepartment);

	var deputyHeadMaster = EmployeeFactory.GetEmployeeInstance(EmployeeType.DeputyHeadMaster, 4, "Devlin", "Brown", 60000);
	employees.Add(deputyHeadMaster);

	var headMaster = EmployeeFactory.GetEmployeeInstance(EmployeeType.HeadMaster, 5, "Damien", "Jones", 80000);
	employees.Add(headMaster);
}
