using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Data.SqlClient;
namespace UserDBFS
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source = LAPTOPD\\SQLEXPRESS; Initial Catalog = userDBFS; Integrated Security = True";
        public Form1()
        {
            InitializeComponent();
            LoadAllUsers();
        }
        private void LoadAllUsers()
        {
            string query = "SELECT UserId, UserName, Email FROM Users";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        dataGridView1.DataSource = dataTable;
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show("Failed: " + ex.Message);
                }
            }
            

           
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {


            string userInput = txtUserId.Text;

            if(userInput == "")
            {
                MessageBox.Show("Please input user ID!");
                return;
            }
            int userId = Convert.ToInt32(userInput);
            string query = "SELECT UserId, UserName, Email FROM Users WHERE UserId = @userId ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userId", userId);
                        SqlDataReader reader = command.ExecuteReader();

                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        dataGridView1.DataSource = dataTable;
                    }
                }catch (Exception ex)
                {
                    MessageBox.Show("Failed: " + ex.Message);
                }
            }
        }
    }
}
