using custom_exception.Exceptions;

namespace custom_exception
{
    internal class Department
    {
        public string Name { get; set; }
        public int EmployeeLimit { get; set; }

        private Employee[] employees;
        public Department(string name, int employeeLimit)
        {

            Name = name;
            EmployeeLimit = employeeLimit;
            employees = new Employee[0];

        }


        public Employee this[int index]
        {
            get
            {
                return employees[index];
            }
            set
            {
                if (index < 0)
                {
                    Console.WriteLine("Index must be greater than 0");
                }

                if (index >= EmployeeLimit)
                {

                    Console.WriteLine($"Index can not be greater than {EmployeeLimit}");
                }

                employees[index] = value;
            }
        }



        public void AddEmployee(Employee employee)
        {
            if (employees.Length >= EmployeeLimit)
            {
                throw new CapacityLimitException($"You are reached employees limit. Limit is {EmployeeLimit}");
            }

            Array.Resize(ref employees, employees.Length + 1);

            employees[employees.Length - 1] = employee;
        }

        public void PrintInformation()
        {
            for (int i = 0; i < employees.Length; i++)
            {


                Console.WriteLine($"Employee: {employees[i]}");
            }

        }

    }
}
