namespace OOPGenericCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeesForStack = new List<Employee>();

            employeesForStack.Add(new Employee(1, "Bob", "Male", 20000));
            employeesForStack.Add(new Employee(2, "Zoe", "Female", 30000));
            employeesForStack.Add(new Employee(3, "Leo", "Male", 25000));
            employeesForStack.Add(new Employee(4, "Max", "Male", 15000));
            employeesForStack.Add(new Employee(5, "Ava", "Female", 19000));


            Stack<Employee> employeesStack = new Stack<Employee>();

            Console.WriteLine("Part 1");

            foreach (var employee in employeesForStack)
            {
                employeesStack.Push(employee);
            }

            foreach (var employee in employeesStack)
            {

                Console.WriteLine($"Items left in the Stack = {employeesStack.Count}");
                Console.WriteLine(employee.ToString());

            }
            Console.WriteLine("----------------------------------------------------------------");

            Console.WriteLine("Retirieve using Pop Method");
            while (employeesStack.Count > 0)
            {
                var employeePop = employeesStack.Pop();
                Console.WriteLine(employeePop.ToString());
                Console.WriteLine($"Items left in the Stack = {employeesStack.Count}");

            }

            foreach (var employee in employeesForStack)
            {
                employeesStack.Push(employee);
            }
            Console.WriteLine("----------------------------------------------------------------");

            for (int i = 0; i < 2; i++)
            {
                var employeePeek = employeesStack.Peek();
                Console.WriteLine(employeePeek.ToString());
                Console.WriteLine($"Items left in the Stack = {employeesStack.Count}");
            }

            bool containsThree = employeesStack.Any(employees => employees.Id == 3);
            if (containsThree)
            {
                Console.WriteLine("\nEmployee with ID 3 exists in the Stack.");
            }
            else
            {
                Console.WriteLine("\nEmployee with ID 3 does not exist in the Stack.");
            }


            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(1, "Bob", "Male", 20000));
            employees.Add(new Employee(2, "Zoe", "Female", 30000));
            employees.Add(new Employee(3, "Leo", "Male", 25000));
            employees.Add(new Employee(4, "Max", "Male", 15000));
            employees.Add(new Employee(5, "Ava", "Female", 19000));

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("\nPart 2");
            // var employeeToFind = employees[1];
            bool ifContains = employees.Contains(employees[1]);

            if (ifContains)
            {
                Console.WriteLine("\nEmployee2 object exists in the list");
            }
            else
            {
                Console.WriteLine("\nEmployee2 object does not exist in the list");
            }

            Console.WriteLine("----------------------------------------------------------------");


            var foundEmployee = employees.Find(employees => employees.Gender == "Male");
            Console.WriteLine(foundEmployee.ToString());

            Console.WriteLine("----------------------------------------------------------------");

            var allMaleEmployees = employees.FindAll(employees => employees.Gender == "Male");

            foreach (var employee in allMaleEmployees)
            {
                Console.WriteLine(employee.ToString());
            }




        }
    }
}
