using System.ComponentModel;
using System.Security.Cryptography.Pkcs;
using Tree_View;

namespace TreeViewDetails
{
    public partial class Form1 : Form
    {
        private BindingList<Employee> employees;
        private BindingList<Department> departments;
        public Form1()
        {
            InitializeComponent();
            InitializeTreeView();

        }
        private void InitializeTreeView()
        {
            //TreeNode rootNode = new TreeNode("Department");
            //TreeNode hrNode = new TreeNode("Human Resourses");
            //hrNode.Nodes.Add("Emp 1");
            //hrNode.Nodes.Add("Emp 2");
            //TreeNode fnNode = new TreeNode("Finance");
            //fnNode.Nodes.Add("Emp 3");
            //fnNode.Nodes.Add("Emp 4");
            //TreeNode teNode = new TreeNode("Technology");
            //teNode.Nodes.Add("Emp 5");
            //teNode.Nodes.Add("Emp 6");

            //rootNode.Nodes.Add(hrNode);
            //rootNode.Nodes.Add(fnNode);
            //rootNode.Nodes.Add(teNode);

            //treeView1.Nodes.Add(rootNode);
            employees = new BindingList<Employee>(Data.GetEmployees());
            departments = new BindingList<Department>(Data.GetDepartments());

            UpdateTreeView();

            employees.ListChanged += (sender, e) => { UpdateTreeView(); };
            departments.ListChanged += (sender, e) => { UpdateTreeView(); };
        }
        private void UpdateTreeView()
        {
            treeView1.Nodes.Clear();
            TreeNode rootNode = new TreeNode("Company");
            foreach (Department department in departments)
            {
                TreeNode departmentNode = new TreeNode(department.LongName);
                IEnumerable<Employee> departmentEmployee = employees.Where(emp => emp.DepartmentId == department.Id);

                foreach (Employee employee in departmentEmployee)
                {
                    TreeNode employeeNode = new TreeNode($"{employee.FirstName} {employee.LastName}");
                    departmentNode.Nodes.Add(employeeNode);
                }
                rootNode.Nodes.Add(departmentNode);
            }

            treeView1.Nodes.Add(rootNode);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            employees.Add(new Employee
            {
                Id = employees.Count + 1,
                FirstName = "New",
                LastName = "Employee",
                AnnualSalary = 45000m,
                IsManager = false,
                DepartmentId = 3

            });
            departments.Add(new Department
            {
                Id = employees.Count + 1,
                ShortName = "IT",
                LongName = "IT Services"

            });
        }
    }
}
