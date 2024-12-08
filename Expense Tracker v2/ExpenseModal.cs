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
    public partial class ExpenseModal : UserControl
    {

        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\CODING\OOP\Expense Tracker v2\Expense Tracker v2\expensesDB.mdf"";Integrated Security=True;Connect Timeout=30;Context Connection=False";


        public ExpenseModal()
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

                string selectData = "SELECT category FROM categories WHERE type = @type AND status = @status";

                using (SqlCommand cmd = new SqlCommand(selectData, connection))
                {
                    cmd.Parameters.AddWithValue("@type", "Expenses");
                    cmd.Parameters.AddWithValue("@status", "Active");

                    expense_category.Items.Clear();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        expense_category.Items.Add(reader["category"].ToString());
                    }
                }
                connection.Close();
            }
        }
        private void expense_addBtn_Click(object sender, EventArgs e)
        {
            if (expenseDate.Text == "" || expense_category.SelectedIndex == -1 || expense_name.Text == "" ||
    expense_amount.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    connection.Open();

                    string insertData = "INSERT INTO expenses (category, item, expense, description, date_expense, date_insert)" +
                        "VALUES(@cat, @item, @expense, @desc, @date_ex, @date)";

                    using (SqlCommand cmd = new SqlCommand(insertData, connection))
                    {
                        cmd.Parameters.AddWithValue("@date_ex", expenseDate.Value);
                        cmd.Parameters.AddWithValue("@cat", expense_category.SelectedItem);
                        cmd.Parameters.AddWithValue("@item", expense_name.Text);
                        cmd.Parameters.AddWithValue("@desc", expense_description.Text);
                        cmd.Parameters.AddWithValue("@expense", expense_amount.Text);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now.Date);



                        cmd.ExecuteNonQuery();
                        clearFields();

                        MessageBox.Show("Expense added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    connection.Close();
                }
                this.Visible = false;
            }
        }
        public void clearFields()
        {
            expense_category.SelectedIndex = -1;
            expense_name.Text = "";
            expense_amount.Text = "";
        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDatePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFormCaptionButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void ExpenseModal_Load(object sender, EventArgs e)
        {

        }
    }
}
