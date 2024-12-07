using Bunifu.UI.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Expense_Tracker_v2
{
	public partial class SignUp : Form
	{
		SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\CODING\OOP\Expense Tracker v2\Expense Tracker v2\expensesDB.mdf"";Integrated Security=True;Connect Timeout=30;Context Connection=False");
		public SignUp()
		{
			InitializeComponent();
		}

		public bool checkConnection()
		{
			return (connection.State == ConnectionState.Closed) ? true : false;
		}
		private void Form1_Load(object sender, EventArgs e)
		{

		}



		private void bunifuFormDock1_FormDragging(object sender, Bunifu.UI.WinForms.BunifuFormDock.FormDraggingEventArgs e)
		{

		}

		private void bunifuPictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void bunifuPanel1_Click(object sender, EventArgs e)
		{

		}

		private void bunifuPanel2_Click(object sender, EventArgs e)
		{

		}

		private void bunifuLabel2_Click(object sender, EventArgs e)
		{

		}

		private void bunifuLabel4_Click(object sender, EventArgs e)
		{

		}

		private void bunifuButton21_Click(object sender, EventArgs e)
		{
			if(signup_username.Text == "" ||  signup_Password.Text == "" || signup_cPassword.Text == "")
			{
                //MessageBox.Show("Please fill in all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bunifuSnackbar1.Show(this, "Please fill in all fields", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }
			else
			{
                if (checkConnection())
                {
					try
					{
						connection.Open();

						string selectUsername = "SELECT * FROM users WHERE username = @usern";
						using (SqlCommand checkUser = new SqlCommand(selectUsername, connection))
						{
							checkUser.Parameters.AddWithValue("@usern", signup_username.Text.Trim());

							SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
							DataTable table = new DataTable();

							adapter.Fill(table);

							if (table.Rows.Count > 0)
							{
								string tempUsern = signup_username.Text.Substring(0, 1).ToUpper() + signup_username.Text.Substring(1);
								MessageBox.Show(tempUsern + " is existing already", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
							else if (signup_Password.Text.Length < 8)
							{
								MessageBox.Show("Password must be at least 8 characters", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
							else if (signup_Password.Text != signup_cPassword.Text)
							{
								MessageBox.Show("Passwords do not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

							}
							else
							{
								string insertData = "INSERT INTO users (username, password, date_created) VALUES(@usern, @pass, @date)";

								using (SqlCommand insertUser = new SqlCommand(insertData, connection))
								{
									insertUser.Parameters.AddWithValue("@usern", signup_username.Text.Trim());
									insertUser.Parameters.AddWithValue("@pass", signup_Password.Text.Trim());
									insertUser.Parameters.AddWithValue("@date", DateTime.Now);
									insertUser.ExecuteNonQuery();
									MessageBox.Show("Account created successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
									Loginn loginForm = new Loginn();
									loginForm.Show();
									this.Hide();
								}
							}
                        }
                    }
                    catch (Exception ex)
					{
						MessageBox.Show("Failed Connection: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					finally
					{
						connection.Close();
                    }
                }
            }
		}

		private void bunifuLabel5_Click(object sender, EventArgs e)
		{
			Loginn loginForm = new Loginn();
			loginForm.Show();

            this.Hide();
		}
	}
}
