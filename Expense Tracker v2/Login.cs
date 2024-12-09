using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;      

namespace Expense_Tracker_v2
{
    public partial class Loginn : Form
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\CODING\OOP\Expense Tracker v2\Expense Tracker v2\expensesDB.mdf"";Integrated Security=True;Connect Timeout=30;Context Connection=False";
        public Loginn()
        {
            InitializeComponent();
            loginPassword.UseSystemPasswordChar = true; // Ensure this is set

        }

        public static string username;
        public static int UserId;
        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();

                string selectData = "SELECT id FROM users WHERE username = @usern AND password = @password";

                using (SqlCommand cmd = new SqlCommand(selectData, connection))
                {
                    cmd.Parameters.AddWithValue("@usern", loginUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", loginPassword.Text.Trim());

                    //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    //DataTable table = new DataTable();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        UserId = Convert.ToInt32(reader["id"]);
                        username = loginUsername.Text.Trim();
                        MessageBox.Show("Login Successful", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        MainForm dashboardForm = new MainForm();
                        dashboardForm.Show();
                        this.Hide();
                    }

                    //adapter.Fill(table);
                    //if (table.Rows.Count > 0)
                    //{
                    //    UserId = Convert.ToInt32(reader["id"]);
                    //    username = loginUsername.Text.Trim();
                    //    MessageBox.Show("Login Successful", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    //    MainForm dashboardForm = new MainForm();
                    //    dashboardForm.Show();
                    //    this.Hide();
                    //}
                    else if(loginUsername.Text == "" || loginPassword.Text == "")
                    {
                        bunifuSnackbar1.Show(this, "Please fill in all fields", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                    }
                    else
                    {
                        bunifuSnackbar1.Show(this, "Invalid Username or Password", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                        //MessageBox.Show("Invalid Username or Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void bunifuLabel5_Click(object sender, EventArgs e)
        {
            SignUp signUpForm = new SignUp();
            signUpForm.Show();

            this.Hide();
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
