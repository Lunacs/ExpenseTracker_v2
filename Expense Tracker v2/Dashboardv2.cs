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
    public partial class Dashboardv2 : UserControl
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\CODING\OOP\Expense Tracker v2\Expense Tracker v2\expensesDB.mdf"";Integrated Security=True;Connect Timeout=30;Context Connection=False";

        public Dashboardv2()
        {
            InitializeComponent();
            displayExpenseData();
        }

        public void displayExpenseData()
        {
            ExpensesData eData = new ExpensesData();
            List<ExpensesData> listData = eData.expensesListDataTOP();

            // Set AutoGenerateColumns to false
            bunifuDataGridView1.AutoGenerateColumns = false;

            // Clear existing columns
            bunifuDataGridView1.Columns.Clear();

            // Add specific columns
            bunifuDataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Item",
                HeaderText = "Subject"
            });
            bunifuDataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Description",
                HeaderText = "Description"
            });
            bunifuDataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Category",
                HeaderText = "Category"
            });
            
            bunifuDataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Cost",
                HeaderText = "Amount"
            });

            // Set the data source
            bunifuDataGridView1.DataSource = listData;
        }

        //public void displayincomeData()
        //{
        //    IncomeData iData = new IncomeData();
        //    List<IncomeData> listData = iData.IncomeListDataTOP();

        //    // Set AutoGenerateColumns to false
        //    bunifuDataGridView2.AutoGenerateColumns = false;

        //    // Clear existing columns
        //    bunifuDataGridView2.Columns.Clear();

        //    // Add specific columns
        //    bunifuDataGridView2.Columns.Add(new DataGridViewTextBoxColumn
        //    {
        //        DataPropertyName = "Item",
        //        HeaderText = "Item"
        //    });
        //    bunifuDataGridView2.Columns.Add(new DataGridViewTextBoxColumn
        //    {
        //        DataPropertyName = "Description",
        //        HeaderText = "Description"
        //    });
        //    bunifuDataGridView2.Columns.Add(new DataGridViewTextBoxColumn
        //    {
        //        DataPropertyName = "Category",
        //        HeaderText = "Category"
        //    });

        //    bunifuDataGridView2.Columns.Add(new DataGridViewTextBoxColumn
        //    {
        //        DataPropertyName = "Cost",
        //        HeaderText = "Amount"
        //    });

        //    // Set the data source
        //    bunifuDataGridView2.DataSource = listData;
        //}

        public void totalIncome()
        {
           using(SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();
                string selectData = "SELECT SUM(income) FROM income";

                using (SqlCommand cmd = new SqlCommand(selectData, connection))
                {
                    DateTime today = DateTime.Today;
                    cmd.Parameters.AddWithValue("@date_in", today);

                    object result = cmd.ExecuteScalar();

                    if(result != DBNull.Value)
                    {
                        decimal totalIncome = Convert.ToDecimal(result);

                        bunifuLabel4.Text = totalIncome.ToString("C");
                    }
                    else
                    {
                        bunifuLabel4.Text = "P0.00";
                    }
                }
                connection.Close();
            }
        }
    }
}
