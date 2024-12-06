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
    public partial class ExpensesForm : UserControl
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\CODING\OOP\Expense Tracker v2\Expense Tracker v2\expensesDB.mdf"";Integrated Security=True;Connect Timeout=30;Context Connection=False";

        public ExpensesForm()
        {
            InitializeComponent();

            displayCategoryList();
            displayExpenseData();
        }
        public void displayExpenseData()
        {
            ExpensesData eData = new ExpensesData();
            List<ExpensesData> listData = eData.expensesListData();

            bunifuDataGridView1.DataSource = listData;
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

        private void income_addBtn_Click(object sender, EventArgs e)
        {
            if (expense_category.SelectedIndex == -1 || expense_item.Text == "" ||
                expense_expense.Text == "" || expense_description.Text == "")
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
                        cmd.Parameters.AddWithValue("@cat", expense_category.SelectedItem);
                        cmd.Parameters.AddWithValue("@item", expense_item.Text);
                        cmd.Parameters.AddWithValue("@expense", expense_expense.Text);
                        cmd.Parameters.AddWithValue("@desc", expense_description.Text);
                        cmd.Parameters.AddWithValue("@date_ex", expense_date.Value);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now.Date);

                        

                        cmd.ExecuteNonQuery();
                        clearFields();

                        MessageBox.Show("Expense added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    connection.Close();
                }
            }
            displayExpenseData();
        }

        public void clearFields()
        {
            expense_category.SelectedIndex = -1;
            expense_item.Text = "";
            expense_expense.Text = "";
            expense_description.Text = "";
        }

        private void expense_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void expense_updateBtn_Click(object sender, EventArgs e)
        {
            if (expense_category.SelectedIndex == -1 || expense_item.Text == "" ||
                expense_expense.Text == "" || expense_description.Text == "")
            {
                MessageBox.Show("Please select item first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(MessageBox.Show("Are you sure you want to Update ID: " + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(stringConnection))
                    {
                        connection.Open();

                        string updateData = "UPDATE expenses SET category = @cat, item = @item" +
                            ", expense = @expense, description = @desc, date_expense = @date_ex WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(updateData, connection))
                        {
                            cmd.Parameters.AddWithValue("@cat", expense_category.SelectedItem);
                            cmd.Parameters.AddWithValue("@item", expense_item.Text);
                            cmd.Parameters.AddWithValue("@expense", expense_expense.Text);
                            cmd.Parameters.AddWithValue("@desc", expense_description.Text);
                            cmd.Parameters.AddWithValue("@date_ex", expense_date.Value);
                            cmd.Parameters.AddWithValue("@id", getID);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Expense updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }
                        connection.Close();
                    }
                }  
            }
            displayExpenseData();
        }

        private int getID = 0;
        private void bunifuDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = bunifuDataGridView1.Rows[e.RowIndex];

                getID = Convert.ToInt32(row.Cells[0].Value);
                expense_category.SelectedItem = row.Cells[1].Value.ToString();
                expense_item.Text = row.Cells[2].Value.ToString();
                expense_expense.Text = row.Cells[3].Value.ToString();
                expense_description.Text = row.Cells[4].Value.ToString();
                expense_date.Value = Convert.ToDateTime(row.Cells[5].Value);
            }
        }

        private void expense_deleteBtn_Click(object sender, EventArgs e)
        {
            if (expense_category.SelectedIndex == -1 || expense_item.Text == "" ||
                expense_expense.Text == "" || expense_description.Text == "")
            {
                MessageBox.Show("Please select item first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Delete ID: " + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(stringConnection))
                    {
                        connection.Open();

                        string deleteData = "DELETE FROM expenses WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(deleteData, connection))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Expense deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }
                        connection.Close();
                    }
                }
            }
            displayExpenseData();
        }
    }
}
