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
    public partial class IncomeModal : UserControl
    {

        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\CODING\OOP\Expense Tracker v2\Expense Tracker v2\expensesDB.mdf"";Integrated Security=True;Connect Timeout=30;Context Connection=False";


        public IncomeModal()
        {
            InitializeComponent();

            displayCategoryList();
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayCategoryList();
        }
        public void displayCategoryList()
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();

                string selectData = "SELECT category FROM categories WHERE type = @type AND status = @status AND UserId = @userId";

                using (SqlCommand cmd = new SqlCommand(selectData, connection))
                {
                    cmd.Parameters.AddWithValue("@type", "Income");
                    cmd.Parameters.AddWithValue("@status", "Active");
                    cmd.Parameters.AddWithValue("@userId", Loginn.UserId);

                    income_category.Items.Clear();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        income_category.Items.Add(reader["category"].ToString());
                    }
                }
                connection.Close();
            }
        }
        private void income_addBtn_Click_1(object sender, EventArgs e)
        {
            if (income_category.SelectedIndex == -1 || income_name.Text == "" ||
                income_amount.Text == "" || income_description.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    connection.Open();

                    string insertData = "INSERT INTO income (category, item, income, description, date_income, date_insert, UserId)" +
                        "VALUES(@cat, @item, @income, @desc, @date_in, @date, @userId)";

                    using (SqlCommand cmd = new SqlCommand(insertData, connection))
                    {
                        cmd.Parameters.AddWithValue("@cat", income_category.SelectedItem);
                        cmd.Parameters.AddWithValue("@item", income_name.Text);
                        cmd.Parameters.AddWithValue("@income", income_amount.Text);
                        cmd.Parameters.AddWithValue("@desc", income_description.Text);
                        cmd.Parameters.AddWithValue("@date_in", IncomeDate.Value);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now.Date);
                        cmd.Parameters.AddWithValue("@userId", Loginn.UserId);

                        cmd.ExecuteNonQuery();
                        clearFields();

                        MessageBox.Show("Income added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    connection.Close();
                }
                this.Visible = false;
            }
        }
        public void clearFields()
        {
            income_category.SelectedIndex = -1;
            income_name.Text = "";
            income_amount.Text = "";
        }
        private void IncomeModal_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFormCaptionButton1_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;

        }

        
    }
}
