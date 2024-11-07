using static LINQ.Program;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeesList = Data.GetEmployees();
            List<Department> departmentList = Data.GetDepartments();

            //Method Syntax
            //var results = employeesList.Select(emp => new
            //{
            //    FullName = emp.FirstName + " " + emp.LastName,
            //    AnuualSalary = emp.AnnualSalary
            //}).Where(e => e.AnuualSalary >= 50000);

            //foreach (var item in results)
            //{
            //   // Console.WriteLine($"{item.FullName,-20} - {item.AnuualSalary,10}");

            //}
            //Query Synatx
            //var result = (from emp in employeesList
            //             where emp.AnnualSalary >= 50000
            //             select new
            //             {
            //                 FullName = emp.FirstName + "" + emp.LastName,
            //                 AnnualSalary = emp.AnnualSalary
            //             }).ToList();
            //employeesList.Add(new Employee
            //{
            //    Id = 5,
            //    FirstName = "Sam",
            //    LastName = "Davis",
            //    AnnualSalary = 100000.20m,
            //    IsManager = true,
            //    DepartmentId = 2
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.FullName,-20} - {item.AnnualSalary,10}");
            //}

            ///Inner join
            //var result = departmentList.Join(employeesList,
            //                                 department => department.Id,
            //                                 employees => employees.DepartmentId,
            //                                 (department, employees) => new
            //                                 {
            //                                     FullName = employees.FirstName + " " + employees.LastName,
            //                                     AnnualSalary = employees.AnnualSalary,
            //                                     DepartmentName = department.LongName
            //                                 }) ;
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.FullName,-20} - {item.AnnualSalary,10} - {item.DepartmentName}");
            //}
            //var result = from dept in departmentList
            //             join emp in employeesList
            //             on dept.Id equals emp.DepartmentId
            //             select new
            //             {
            //                 FullName = emp.FirstName + " " + emp.LastName,
            //                 AnnualSalary = emp.AnnualSalary,
            //                 DepartmentName = dept.LongName
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.FullName,-20} - {item.AnnualSalary,10} - {item.DepartmentName}");
            //}

            //var result = departmentList.GroupJoin(employeesList, dept => dept.Id, emp => emp.DepartmentId,
            //    (dept, employeeGroup) => new
            //    {
            //        Employees = employeeGroup,
            //        DepartmentName = dept.LongName
            //    });
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Department Name: {item.DepartmentName}");
            //    foreach (var emp in item.Employees)
            //    {
            //        Console.WriteLine($"{emp.FirstName} {emp.LastName}");
            //    }
            //}
            //left join
            //        var result = departmentList.GroupJoin(employeesList, dept => dept.Id, emp => emp.DepartmentId,
            //(dept, employeeGroup) => new
            //{
            //    Employees = employeeGroup,
            //    DepartmentName = dept.LongName
            //});
            //        foreach (var item in result)
            //        {
            //            Console.WriteLine($"Department Name: {item.DepartmentName}");
            //            foreach (var emp in item.Employees)
            //            {
            //                Console.WriteLine($"{emp.FirstName} {emp.LastName}");
            //            }
            //        }
            //Right join
            var result = employeesList.GroupJoin(departmentList, emp => emp.DepartmentId, dept => dept.Id,
        (emp, departmentGroup) => new
        {
            Employee = emp,
            Departments = departmentGroup // Ensures right join behavior
        });

            foreach (var item in result)
            {
                //Console.WriteLine($"Department Name: {dept?.LongName ?? "No Department"}");

                foreach (var dept in item.Departments)
                {
                    Console.WriteLine($"Department Name: {dept.LongName}");
                    Console.WriteLine($"{item.Employee.FirstName} {item.Employee.LastName}");
                }
            }

        }
        public class Employee
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public decimal AnnualSalary { get; set; }
            public bool IsManager { get; set; }
            public int DepartmentId { get; set; }
        }
        public class Department
        {
            public int Id { get; set; }
            public string ShortName { get; set; }
            public string LongName { get; set; }
        }

        public static class Data
        {
            public static List<Employee> GetEmployees()
            {
                List<Employee> employees = new List<Employee>();

                Employee employee = new Employee
                {
                    Id = 1,
                    FirstName = "Bob",
                    LastName = "Jones",
                    AnnualSalary = 60000.3m,
                    IsManager = true,
                    DepartmentId = 1
                };
                employees.Add(employee);
                employee = new Employee
                {
                    Id = 2,
                    FirstName = "Sarah",
                    LastName = "Jameson",
                    AnnualSalary = 80000.1m,
                    IsManager = true,
                    DepartmentId = 2
                };
                employees.Add(employee);
                employee = new Employee
                {
                    Id = 3,
                    FirstName = "Douglas",
                    LastName = "Roberts",
                    AnnualSalary = 40000.2m,
                    IsManager = false,
                    DepartmentId = 2
                };
                employees.Add(employee);
                employee = new Employee
                {
                    Id = 4,
                    FirstName = "Jane",
                    LastName = "Stevens",
                    AnnualSalary = 30000.2m,
                    IsManager = false,
                    DepartmentId = 2
                };
                employees.Add(employee);

                return employees;
            }

            public static List<Department> GetDepartments()
            {
                List<Department> departments = new List<Department>();

                Department department = new Department
                {
                    Id = 1,
                    ShortName = "HR",
                    LongName = "Human Resources"
                };
                departments.Add(department);
                department = new Department
                {
                    Id = 2,
                    ShortName = "FN",
                    LongName = "Finance"
                };
                departments.Add(department);
                department = new Department
                {
                    Id = 3,
                    ShortName = "TE",
                    LongName = "Technology"
                };
                departments.Add(department);

                return departments;
            }
        }
    }
}
