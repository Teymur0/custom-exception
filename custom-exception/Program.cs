using custom_exception;
using custom_exception.Exceptions;
Employee firstEmp = new Employee("First User", 20, 1000);
Employee secondEmp = new Employee("Second User", 30, 3000);
Employee thirdEmp = new Employee("Third User", 21, 2133);

Department itDepartment = new Department("IT", 2);

try
{
    itDepartment.AddEmployee(firstEmp);
    itDepartment.AddEmployee(secondEmp);
    itDepartment.AddEmployee(thirdEmp);
    itDepartment.PrintInformation();
}
catch (CapacityLimitException msg)
{
    Console.WriteLine(msg.Message);
}
finally
{
    Console.WriteLine("Operatin was completed");
}