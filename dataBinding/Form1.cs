using System.ComponentModel;
using System.Data;
namespace dataBinding
{
    public partial class Form1 : Form
    {
        private Person person;
        private BindingList<Person> people;
        public Form1()
        {
            InitializeComponent();
            person = new Person { Name = "Tom", Age = 25 };
            //bind the data to ui
            txtName.DataBindings.Add("Text", person, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            txtAge.DataBindings.Add("Text", person, "Age", true, DataSourceUpdateMode.OnPropertyChanged);
            lblName.DataBindings.Add("Text", person, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            lblAge.DataBindings.Add("Text", person, "Age", true, DataSourceUpdateMode.OnPropertyChanged);
            people = new BindingList<Person>()
            {
                new Person {Name = "Alice", Age = 30},
                new Person {Name = "Lily", Age = 35}
            };
            comboBox1.DataSource = people;
            comboBox1.DisplayMember = "Name";

            listBox1.DataSource = people;
            listBox1.DisplayMember = "Name";

            // dataGridView1.DataSource = people;
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Name",  typeof(string));
            dataTable.Columns.Add("Age", typeof(int));
            dataTable.Rows.Add(person.Name, person.Age);

            dataGridView1.DataSource = dataTable;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            person.Name = "Bob";
            person.Age = 27;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //people.Add(new Person { Name = "Deepanshi", Age = 24 });
            people.Add(new Person { Name = person.Name, Age = person.Age });
        }
    }
}

