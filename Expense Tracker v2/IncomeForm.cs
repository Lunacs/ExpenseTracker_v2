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
    public partial class IncomeForm : UserControl
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\CODING\OOP\Expense Tracker v2\Expense Tracker v2\expensesDB.mdf"";Integrated Security=True;Connect Timeout=30;Context Connection=False";

        public IncomeForm()
        {
            InitializeComponent();

            displayCategoryList();
            displayIncomeData();
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayCategoryList();
            displayIncomeData();
        }
        public void displayIncomeData()
        {
            IncomeData iData = new IncomeData();
            List<IncomeData> listData = iData.IncomeListData(Loginn.UserId);

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
                    cmd.Parameters.AddWithValue("@type", "Income");
                    cmd.Parameters.AddWithValue("@status", "Active");

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

        private void income_addBtn_Click(object sender, EventArgs e)
        {
            if (income_category.SelectedIndex == -1 || income_item.Text == "" ||
                income_income.Text == "" || income_description.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    connection.Open();

                    string insertData = "INSERT INTO income (category, item, income, description, date_income, date_insert)" +
                        "VALUES(@cat, @item, @income, @desc, @date_in, @date)";

                    using (SqlCommand cmd = new SqlCommand(insertData, connection))
                    {
                        cmd.Parameters.AddWithValue("@cat", income_category.SelectedItem);
                        cmd.Parameters.AddWithValue("@item", income_item.Text);
                        cmd.Parameters.AddWithValue("@income", income_income.Text);
                        cmd.Parameters.AddWithValue("@desc", income_description.Text);
                        cmd.Parameters.AddWithValue("@date_in", income_date.Value);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now.Date);

                        cmd.ExecuteNonQuery();
                        clearFields();

                        MessageBox.Show("Income added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    connection.Close();
                }
            }
            displayIncomeData();
        }

        private void income_category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void clearFields()
        {
            income_category.SelectedIndex = -1;
            income_item.Text = "";
            income_income.Text = "";
            income_description.Text = "";
            income_date.Value = DateTime.Now;
        }
        private void income_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void income_updateBtn_Click(object sender, EventArgs e)
        {
            if (income_category.SelectedIndex == -1 || income_item.Text == "" ||
                income_income.Text == "" || income_description.Text == "")
            {
                MessageBox.Show("Please select item first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(MessageBox.Show("Are you sure you want to Update ID: " + getID + "?",
                    "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(stringConnection))
                    {
                        connection.Open();

                        string updateData = "UPDATE income SET category = @cat, item = @item," +
                            "income = @income, description = @desc, date_income = @date_in WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(updateData, connection))
                        {
                            cmd.Parameters.AddWithValue("@cat", income_category.SelectedItem);
                            cmd.Parameters.AddWithValue("@item", income_item.Text);
                            cmd.Parameters.AddWithValue("@income", income_income.Text);
                            cmd.Parameters.AddWithValue("@desc", income_description.Text);
                            cmd.Parameters.AddWithValue("@date_in", income_date.Value);
                            cmd.Parameters.AddWithValue("@id", getID);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Income updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }
                        connection.Close();
                    }
                }
                
            }
            displayIncomeData();
        }

        private int getID = 0;
        private void bunifuDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = bunifuDataGridView1.Rows[e.RowIndex];

                getID = Convert.ToInt32(row.Cells[0].Value);
                income_category.SelectedItem = row.Cells[1].Value.ToString();
                income_item.Text = row.Cells[2].Value.ToString();
                income_income.Text = row.Cells[3].Value.ToString();
                income_description.Text = row.Cells[4].Value.ToString();
                income_date.Value = Convert.ToDateTime(row.Cells[5].Value.ToString());
            }
        }

        private void income_deleteBtn_Click(object sender, EventArgs e)
        {
            if (income_category.SelectedIndex == -1 || income_item.Text == "" ||
                income_income.Text == "" || income_description.Text == "")
            {
                MessageBox.Show("Please select item first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Delete ID: " + getID + "?",
                    "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(stringConnection))
                    {
                        connection.Open();

                        string deleteData = "DELETE FROM income WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(deleteData, connection))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Income deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }
                        connection.Close();
                    }
                }
                    
            }
            displayIncomeData();
        }
    }
}
