using LINQ2;

namespace LINQ_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = Data.GetEmployees();
            List<Department> departmentList = Data.GetDepartments();

            Console.WriteLine("******************** Question 1: High-Salary Managers Query(by method syntax) ******************** ");
            var results = employeeList
                          .Where(e => e.AnnualSalary > 80000 && e.IsManager)
                          .OrderByDescending(e => e.AnnualSalary)
                           .Select(e => new
                           {
                                Name = $"{e.FirstName} {e.LastName}",
                                Salary = e.AnnualSalary,
                                DepartmentName = departmentList
                                .FirstOrDefault(d => d.Id == e.DepartmentId)?.LongName ?? "Unassigned"
                           });
            foreach(var item in results)
            {
                Console.WriteLine($"Name: {item.Name} - " +
                                  $"Salary: {item.Salary} - " +
                                  $"Department: {item.DepartmentName}");
            }

            Console.WriteLine();
            Console.WriteLine("******************** Question 2:  Department Salary Summary(By query syntex) ******************** ");
            var results2 = from dept in departmentList
                         join emp in employeeList
                         on dept.Id equals emp.DepartmentId
                         into deptEmployees //Groups employees for each department
                         select new
                         {
                             DepartmentName = dept.LongName,
                             TotalSalary = deptEmployees.Sum(e => e.AnnualSalary),
                             AverageSalary = deptEmployees.Any() ? deptEmployees.Average(e => e.AnnualSalary) : 0
                         }
                         into deptSalaryStats
                         orderby deptSalaryStats.TotalSalary descending
                         select deptSalaryStats;

            foreach (var item in results2)
            {
                Console.WriteLine($"Department: {item.DepartmentName}, " +
                                  $"Total Salary: {item.TotalSalary}, " +
                                  $"Average Salary: {item.AverageSalary}");
            }

            Console.WriteLine();
            Console.WriteLine("******************** Question 3: Composite Query ******************** ");
            //Group employees by department & count each department
            var departmentEmployeeCounts = employeeList
                            .GroupBy(e => e.DepartmentId)
                            .Where(g => g.Count() >= 2)
                            .Select(g => new
                            {
                                DepartmentId = g.Key,
                                EmployeeCount = g.Count()
                            });
            var result = employeeList
                .Where(e => e.AnnualSalary >= 60000 && e.AnnualSalary <= 100000)
                .Join(departmentEmployeeCounts,
                    e => e.DepartmentId,
                    d => d.DepartmentId,
                    (e, d) => new { Employee = e, DepartmentEmployeeCount = d.EmployeeCount })
                .Join(departmentList,
                    ed => ed.Employee.DepartmentId,
                    d => d.Id,
                    (ed, d) => new
                    {
                        FullName = $"{ed.Employee.FirstName} {ed.Employee.LastName}",
                        Salary = ed.Employee.AnnualSalary,
                        DepartmentName = d.LongName,
                        DepartmentEmployeeCounts = ed.DepartmentEmployeeCount
                    });
            foreach (var item in result)
            {
                Console.WriteLine($"Full Name: {item.FullName}, " +
                                  $"Salary: {item.Salary}, " +
                                  $"Department: {item.DepartmentName}, " +
                                  $"Employees in Dept: {item.DepartmentEmployeeCounts}");
            }

            Console.WriteLine();
            Console.WriteLine("******************** Question 4:  Sorting and Filtering Employee Information ******************** ");
            var resultMethodSyntax = employeeList
                .Where(e => e.AnnualSalary > 50000) // Filter by salary
                .OrderBy(e => e.DepartmentId) // Sort by department
                .ThenByDescending(e => e.AnnualSalary) // Sort within department by salary descending
                .GroupJoin(departmentList,
                    e => e.DepartmentId,
                    d => d.Id,
                    (e, d) => new
                    {
                        FullName = $"{e.FirstName} {e.LastName}",
                        Salary = e.AnnualSalary,
                        DepartmentName = d.FirstOrDefault()?.LongName ?? "Unassigned"
                    });

            Console.WriteLine("Method Syntax Result:");
            foreach (var item in resultMethodSyntax)
            {
                Console.WriteLine($"Full Name: {item.FullName}, " +
                    $"Salary: {item.Salary}, " +
                    $"Department: {item.DepartmentName}");
            }

            // Query Syntax
            var resultQuerySyntax = from e in employeeList
                                    where e.AnnualSalary > 50000
                                    orderby e.DepartmentId, e.AnnualSalary descending
                                    join d in departmentList on e.DepartmentId equals d.Id into deptGroup
                                    from d in deptGroup.DefaultIfEmpty()
                                    select new
                                    {
                                        FullName = $"{e.FirstName} {e.LastName}",
                                        Salary = e.AnnualSalary,
                                        DepartmentName = d?.LongName ?? "Unassigned"
                                    };

            Console.WriteLine("\nQuery Syntax Result:");
            foreach (var item in resultQuerySyntax)
            {
                Console.WriteLine($"Full Name: {item.FullName}, " +
                    $"Salary: {item.Salary}, " +
                    $"Department: {item.DepartmentName}");
            }

            Console.WriteLine();
            Console.WriteLine("******************** Question 5:  Find the Unique Employee of a Specific Department ******************** ");
            int specialDepartment = 3;
            var employeesInSpecialDepartment = employeeList
               .Where(e => e.DepartmentId == specialDepartment)
               .ToList();

            if (employeesInSpecialDepartment.Count == 0)
            {
                Console.WriteLine($"Department {specialDepartment} has no employees.");
            }
            else if(employeesInSpecialDepartment.Count == 1)
            {
                var uniqueEmployee = employeesInSpecialDepartment.First();
                Console.WriteLine($"Unique Employee in Department {specialDepartment}: " +
                    $"{uniqueEmployee.FirstName} {uniqueEmployee.LastName}, " +
                    $"Salary: {uniqueEmployee.AnnualSalary}");
            }
            else
            {
                Console.WriteLine($"Department {specialDepartment} has more than one employee.");
            }

            Console.WriteLine();
            Console.WriteLine("******************** Question 6:  Group Sorting and Aggregation ******************** ");
            var departmentInfo = departmentList
                .GroupBy(d => d.Id)
                .Select(g => new
                {
                    DepartmentId = g.Key,
                    TotalEmployees = employeeList.Count(e => e.DepartmentId == g.Key),
                    HighestSalaryEmployee = employeeList
                        .Where(e => e.DepartmentId == g.Key)
                        .OrderByDescending(e => e.AnnualSalary)
                        .FirstOrDefault(),
                    LowestSalaryEmployee = employeeList
                        .Where(e => e.DepartmentId == g.Key)
                        .OrderBy(e => e.AnnualSalary)
                        .FirstOrDefault()
                })
                .OrderBy(d => d.DepartmentId)
                .ToList();

            foreach (var dept in departmentInfo)
            {
                Console.WriteLine($"Department ID: {dept.DepartmentId}, " +
                    $"Total Employees: {dept.TotalEmployees}");
                if (dept.TotalEmployees > 0)
                {
                    var highest = dept.HighestSalaryEmployee;
                    var lowest = dept.LowestSalaryEmployee;

                    Console.WriteLine($"Highest Salary Employee: {highest.FirstName} {highest.LastName}, " +
                        $"Salary: {highest.AnnualSalary}");
                    Console.WriteLine($"Lowest Salary Employee: {lowest.FirstName} {lowest.LastName}, " +
                        $"Salary: {lowest.AnnualSalary}");
                }
                else
                {
                    Console.WriteLine("No employees in this department.");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("******************** Question 7: . Salary Analysis Function ******************** ");
            // 1. Calculate total annual salary using Aggregate function
            decimal totalAnnualSalary = employeeList.Aggregate(0m, (total, emp) => total + emp.AnnualSalary);
            Console.WriteLine($"Total Annual Salary of All Employees: {totalAnnualSalary}");

            // 2. Find the employee with the highest annual salary using Max function
            var highestSalary = employeeList.Max(e => e.AnnualSalary);
            var highestSalaryEmployee = employeeList.FirstOrDefault(e => e.AnnualSalary == highestSalary);

            if (highestSalaryEmployee != null)
            {
                var departmentName = departmentList
                    .FirstOrDefault(d => d.Id == highestSalaryEmployee.DepartmentId)?.ShortName ?? "Unassigned";
                Console.WriteLine($"Employee with Highest Salary: {highestSalaryEmployee.FirstName} {highestSalaryEmployee.LastName}, " +
                    $"Department: {departmentName}, Salary: {highestSalary}");
            }

            Console.WriteLine();
            Console.WriteLine("******************** Question 8:  Department Salary Analysis Function ******************** ");
            var averageSalaries = employeeList
                .GroupBy(e => e.DepartmentId)
                .Select(g => new
                {
                    DepartmentId = g.Key,
                    AverageSalary = g.Average(e => e.AnnualSalary),
                    DepartmentName = departmentList.FirstOrDefault(d => d.Id == g.Key)?.LongName ?? "Unassigned"
                })
                .OrderByDescending(x => x.AverageSalary)
                .ToList();

            foreach (var item in averageSalaries)
            {
                Console.WriteLine($"Department: {item.DepartmentName}, " +
                    $"Average Salary: {item.AverageSalary}");
            }

            Console.WriteLine();
            Console.WriteLine("******************** Question 9: Filtering Function ******************** ");
            var highSalaryManagers = employeeList
                .Where(e => e.AnnualSalary > 80000 && e.IsManager)
                .SelectMany(e => new[]
                {
                    new
                    {
                        FullName = $"{e.FirstName} {e.LastName}",
                        Salary = e.AnnualSalary,
                        DepartmentName = departmentList.FirstOrDefault(d => d.Id == e.DepartmentId)?.LongName ?? "Unassigned" // Get department name
                    },

                    new
                    {
                        FullName = $"{e.FirstName}",
                        Salary = e.AnnualSalary,
                        DepartmentName = departmentList.FirstOrDefault(d => d.Id == e.DepartmentId)?.ShortName ?? "Unassigned" // Get department name
                    }
                })
                .ToList();
            foreach (var manager in highSalaryManagers)
            {
                Console.WriteLine($"Name: {manager.FullName}, " +
                    $"Salary: {manager.Salary}, " +
                    $"Department: {manager.DepartmentName}");
            }

            Console.WriteLine();
            Console.WriteLine("******************** Question 10:  Employee Transfer Function ******************** ");
            // suppose the department 1 and 3 we are going to merge 
            int departmentId1 = 1;
            int departmentId2 = 3;

            var mergedEmployees = employeeList
            .Where(e => e.DepartmentId == departmentId1 || e.DepartmentId == departmentId2)
            .Select(e => new
            {
                FullName = $"{e.FirstName} {e.LastName}",
                Salary = e.AnnualSalary,
                DepartmentName = departmentList.FirstOrDefault(d => d.Id == e.DepartmentId)?.LongName ?? "Unassigned"
            })
            .Distinct() // Ensure that we avoid duplicates
            .ToList();

            Console.WriteLine($"Merged Employees from Departments {departmentId1} and {departmentId2}:");
            foreach (var employee in mergedEmployees)
            {
                Console.WriteLine($"Name: {employee.FullName}, " +
                    $"Salary: {employee.Salary}, " +
                    $"Department: {employee.DepartmentName}");
            }

        }
    }
}
