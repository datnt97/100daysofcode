List<Employee> employees = new List<Employee>();

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
		case"3":
			PayEmployee();
			break;

		case "quite":
			break;
		default:
			Console.WriteLine("Invalid selection. Please try again!");
			break;
	} 
}
while (userSelection != "quit");


Console.WriteLine("Thank you for using this application!");
Console.ReadLine();	

void PayEmployee()
{
	throw new NotImplementedException();
}

void RegisterWork()
{
	throw new NotImplementedException();
}

void RegisterAnEmployee()
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