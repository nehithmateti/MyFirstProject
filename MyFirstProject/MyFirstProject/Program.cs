// See https://aka.ms/new-console-template for more information


using MyFirstProject.Models;

EliteDataProvider dataProvider = new EliteDataProvider();
//dataProvider.UpdateEmployeePermanentAddress(1, "Perur");
//dataProvider.DeleteEmployee(11);
List<Employee> list = dataProvider.GetEmployeesByGender("M");
Employee e = dataProvider.GetEmployeeById(10);

Console.WriteLine($"{e.EmpId}  {e.Name}");
Console.WriteLine();
foreach (var emp in list)
{
    Console.WriteLine($"{emp.EmpId}  {emp.Name}" );
}




Console.ReadLine();
