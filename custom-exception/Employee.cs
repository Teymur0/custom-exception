namespace custom_exception
{
    internal class Employee : IPerson
    {

        private static int _id;

        public int Id { get; }
        public double Salary { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Employee(string name, int age, double salary)
        {
            Id = _id++;
            Name = name;
            Age = age;
            Salary = salary;
        }


        public string ShowInfo()
        {
            return $"ID: {Id} -- Name: {Name} -- Age: {Age} -- Salary: {Salary}";
        }

        public override string ToString()
        {
            return ShowInfo();
        }

    }
}
