//ExecuteDntApplication();
ExecuteInheritance();

static void ExecuteInheritance()
{
	List<Employee> employees = new List<Employee>()
	{
		new Employee("Emp", "loem", 10.00),
		new Manager("Manager", "loma", 100.00)
	};

	foreach (var e in employees)
	{
		e.PerformWork(8);
		e.RecieveWage();
		Console.WriteLine();
	}
}

static void ExecuteDntApplication()
{
	ShowTitle();

	string userSelection;

	do
	{
		ShowActionTitle();
		ShowSelectionOfActions();

		userSelection = Console.ReadLine();

		switch (userSelection)
		{
			case "1":
				RegisterAnEmployee();
				break;

			case "2":
				RegisterWork();
				break;

			case "3":
				PayEmployee();
				break;

			case "quit":
				break;

			default:
				Console.WriteLine("Invalid selection. Please try again!");
				break;
		}
	}
	while (userSelection != "quit");

	Console.WriteLine("Thank you for using this application!");
	Console.ReadLine();
}

public static partial class Program
{
	private static List<Employee> employees = new List<Employee>();

	private static int DIFFERENCE_INDEX = 1;

	static void ShowAllEmployees()
	{
		int index = 0;
		index += DIFFERENCE_INDEX;
		foreach (Employee emp in employees)
		{
			Console.WriteLine($"{index}. {emp.FullName}");
			index++;
		}
	}

	static void PayEmployee()
	{
		Employee employeeSelected = SelectEmployee();
		employeeSelected.RecieveWage();

		Console.WriteLine($"Thank you for work!");
	}

	static void RegisterWork()
	{
		Employee employee = SelectEmployee();

		Console.Write("Enter the number of hours to work: ");
		int hoursWorked = int.Parse(Console.ReadLine());
		// TODO: Validate hours worked

		employee.PerformWork(hoursWorked);

		Console.WriteLine($"Now, {employee.FullName} has worked {employee.NumberOfHoursWorked}");
	}

	static void RegisterAnEmployee()
	{
		Console.ForegroundColor = ConsoleColor.Magenta;
		Console.WriteLine("Create an employee");
		Console.ForegroundColor = ConsoleColor.White;

		Console.Write("Enter first name: ");
		var firstName = Console.ReadLine();

		Console.Write("Enter last name: ");
		string lastName = Console.ReadLine();

		Console.Write("Enter hourly rate: ");
		var rate = double.Parse(Console.ReadLine());

		var employee = new Employee(firstName, lastName, rate);
		employees.Add(employee);

		Console.WriteLine("Employee created!\n\n");
	}

	static void ShowTitle()
	{
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("********************************");
		Console.WriteLine("** Datnt's Shop Employyee app **");
		Console.WriteLine("********************************");
		Console.ForegroundColor = ConsoleColor.White;
	}
	static void ShowActionTitle()
	{
		Console.ForegroundColor = ConsoleColor.Blue;
		Console.WriteLine("********************");
		Console.WriteLine("* Select an action *");
		Console.WriteLine("********************");
		Console.ForegroundColor = ConsoleColor.White;
	}

	static void ShowSelectionOfActions()
	{
		Console.WriteLine("Enter 1: Register an employyee");
		Console.WriteLine("Enter 2: Register work hours of employee");
		Console.WriteLine("Enter 3: Paid employee");
		Console.WriteLine("Enter 'quit': Quit application");
	}

	static Employee SelectEmployee()
	{
		// TODO: Ensure have employee
		Console.WriteLine("Select an employee");
		ShowAllEmployees();

		var userSelection = Console.ReadLine();
		// TODO: Validate user selection
		int userSelectionId = int.Parse(userSelection);
		int employeeId = userSelectionId - DIFFERENCE_INDEX;
		Employee employee = employees[employeeId];

		return employee;
	}
}
