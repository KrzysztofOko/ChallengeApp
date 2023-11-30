using ChallengeApp;
Employee employee1 = new Employee("Adam", "Kowalski", 22);
Employee employee2 = new Employee("Adrian", "Trzcil", 33);
Employee employee3 = new Employee("Marek", "Przyczyna", 44);

employee1.AddScore(5);
employee1.AddScore(2);
employee1.AddScore(1);

employee2.AddScore(2);
employee2.AddScore(5);
employee2.AddScore(9);

employee3.AddScore(4);
employee3.AddScore(1);
employee3.AddScore(5);

List<Employee> employees = new List<Employee>()
{employee1, employee2, employee3};

int maxResult = -1;
Employee employeeWithMaxResult = null;
foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }
}

Console.WriteLine("Najlepszy wynik zdobyl: " + employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + "lat" + employeeWithMaxResult.Age);
Console.WriteLine("z suma punktow " + employeeWithMaxResult.Result);