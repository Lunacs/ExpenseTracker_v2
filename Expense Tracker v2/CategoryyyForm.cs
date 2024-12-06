﻿using Bunifu.UI.WinForms;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace Expense_Tracker_v2
{
    public partial class CategoryyyForm : UserControl
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\CODING\OOP\Expense Tracker v2\Expense Tracker v2\expensesDB.mdf"";Integrated Security=True;Connect Timeout=30;Context Connection=False";
        public CategoryyyForm()
        {
            InitializeComponent();
            loadCategories();
        }

        public void loadCategories()
        {
            CategoryData cData = new CategoryData();
            List<CategoryData> listData = cData.categoryListData();

            bunifuDataGridView1_new.DataSource = listData;

            bunifuDataGridView1_new.Columns["Date"].DefaultCellStyle.Format = "MM-dd-yyyy";
        }

        private void category_addBtn_new_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(category_cat_new.Text) || category_type_new.SelectedIndex == -1 || category_status_new.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    connection.Open();

                    string insertData = "INSERT INTO categories (category, type, status, date_insert)" +
                        "VALUES(@cat, @type, @status, @date)";

                    using (SqlCommand cmd = new SqlCommand(insertData, connection))
                    {
                        cmd.Parameters.AddWithValue("@cat", category_cat_new.Text.Trim());
                        cmd.Parameters.AddWithValue("@type", category_type_new.SelectedItem);
                        cmd.Parameters.AddWithValue("@status", category_status_new.SelectedItem);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now.Date);

                        cmd.ExecuteNonQuery();
                        clearFields();

                        MessageBox.Show("Category added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    connection.Close();
                }
            }
            loadCategories();
        }

        private int getID = 0;
        private void bunifuDataGridView1_new_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = bunifuDataGridView1_new.Rows[e.RowIndex];

                getID = Convert.ToInt32(row.Cells[0].Value);
                category_cat_new.Text = row.Cells[1].Value.ToString();
                category_type_new.SelectedItem = row.Cells[2].Value.ToString();
                category_status_new.SelectedItem = row.Cells[3].Value.ToString();
            }
        }

        private void category_updateBtn_new_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(category_cat_new.Text) || category_type_new.SelectedIndex == -1 || category_status_new.SelectedIndex == -1)
            {
                MessageBox.Show("Please select item first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Update ID: " + getID + "?", "Confirmation Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(stringConnection))
                    {
                        connection.Open();

                        string updateData = "UPDATE categories SET category = @cat, type = @type, status = @status WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(updateData, connection))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);
                            cmd.Parameters.AddWithValue("@cat", category_cat_new.Text.Trim());
                            cmd.Parameters.AddWithValue("@type", category_type_new.SelectedItem);
                            cmd.Parameters.AddWithValue("@status", category_status_new.SelectedItem);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Category Updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        connection.Close();
                    }
                }
            }
            loadCategories();
        }

        public void clearFields()
        {
            category_cat_new.Text = "";
            category_type_new.SelectedIndex = -1;
            category_status_new.SelectedIndex = -1;
        }

        private void category_clearBtn_new_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void category_deleteBtn_new_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(category_cat_new.Text) || category_type_new.SelectedIndex == -1 || category_status_new.SelectedIndex == -1)
            {
                MessageBox.Show("Please select item first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Delete ID: " + getID + "?", "Confirmation Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(stringConnection))
                    {
                        connection.Open();

                        string updateData = "DELETE FROM categories WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(updateData, connection))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Category Deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        connection.Close();
                    }
                }
            }
            loadCategories();
        }
    }
}