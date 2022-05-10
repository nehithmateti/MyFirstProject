
using MyThirdProject.Models;

NehithdbDataProvider dataProvider = new NehithdbDataProvider();
//dataProvider.UpdateEmployeePermanentAddress(1, "Perur");
//dataProvider.DeleteEmployee(11);
List<TblStudentDetail> list = dataProvider.GetEmployeesByGender("M");
TblStudentDetail s = dataProvider.GetStudentById(12);

Console.WriteLine($"{s.SNo}  {s.SFirstName}");
Console.WriteLine();
foreach (var std in list)
{
    Console.WriteLine($"{std.SId} {std.SFirstName} {std.SLastName} {std.SAddress}");
}
Console.ReadLine();




