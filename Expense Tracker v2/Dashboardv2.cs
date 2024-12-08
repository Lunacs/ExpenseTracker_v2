using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;

namespace Expense_Tracker_v2
{
    public partial class Dashboardv2 : UserControl
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\CODING\OOP\Expense Tracker v2\Expense Tracker v2\expensesDB.mdf"";Integrated Security=True;Connect Timeout=30;Context Connection=False";

        public Dashboardv2()
        {
            InitializeComponent();

            expenseModal1.Visible = false;
            incomeModal1.Visible = false;

            expensesBtn.OnPressedState.FillColor = Color.FromArgb(255, 128, 0);
            expensesBtn.OnPressedState.ForeColor = Color.White;
            expensesBtn_Click(this, EventArgs.Empty);
            incomeTotalIncome();
            expensesTotalExpenses();
            displayUsername();
        }

        public void displayUsername()
        {
            string getUsername = Loginn.username;
            if (!string.IsNullOrEmpty(getUsername))
            {
                greetUser.Text = "Welcome, " + getUsername.Substring(0, 1).ToUpper() + getUsername.Substring(1);
            }
            else
            {
                greetUser.Text = "Welcome, Guest";
            }
        }

        private void Dashboardv2_Load(object sender, EventArgs e)
        {
            incomeDateToday.Text = DateTime.Today.Date.ToString("MMMM dd, yyyy"); // Format date as "December 12, 2024"
            incomeTimeToday.Text = DateTime.Now.ToString("HH:mm tt"); // Format time as "12:00 PM"

            expensesDateToday.Text = DateTime.Today.Date.ToString("MMMM dd, yyyy"); // Format date as "December 12, 2024"
            expensesTimeToday.Text = DateTime.Now.ToString("HH:mm tt"); // Format time as "12:00 PM"
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            expensesBtn.OnPressedState.FillColor = Color.FromArgb(249, 245, 255);
            expensesBtn.OnPressedState.ForeColor = Color.White;
            expensesBtn_Click(this, EventArgs.Empty);
            incomeTotalIncome();
            expensesTotalExpenses();
            displayUsername();
        }

        public void displayExpenseData()
        {
            ExpensesData eData = new ExpensesData();
            List<ExpensesData> listData = eData.expensesListDataTOP();

            //Theme
            bunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Chocolate;

            // Set AutoGenerateColumns to false
            bunifuDataGridView1.AutoGenerateColumns = false;

            // Clear existing columns
            bunifuDataGridView1.Columns.Clear();

            // Add specific columns
            bunifuDataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Item",
                HeaderText = "Item"
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
            var amountColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Cost",
                HeaderText = "Amount"
            };
            amountColumn.DefaultCellStyle.Format = "C"; // Format as currency
            bunifuDataGridView1.Columns.Add(amountColumn);
            // Set the data source
            bunifuDataGridView1.DataSource = listData;
        }

        public void displayincomeData()
        {
            IncomeData iData = new IncomeData();
            List<IncomeData> listData = iData.IncomeListDataTOP();

            //Theme
            bunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.ForestGreen;

            // Set AutoGenerateColumns to false
            bunifuDataGridView1.AutoGenerateColumns = false;

            // Clear existing columns
            bunifuDataGridView1.Columns.Clear();

            // Add specific columns
            bunifuDataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Item",
                HeaderText = "Item"
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
            var amountColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Cost",
                HeaderText = "Amount"
            };
            amountColumn.DefaultCellStyle.Format = "C"; // Format as currency
            bunifuDataGridView1.Columns.Add(amountColumn);
            // Set the data source
            bunifuDataGridView1.DataSource = listData;
        }

        public void incomeTotalIncome()
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();
                string query = "SELECT SUM(income) FROM income";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal totalIncome = Convert.ToDecimal(result);
                        CultureInfo culture = new CultureInfo("en-PH");
                        bunifuLabel4.Text = totalIncome.ToString("C", culture);
                    }
                    else
                    {
                        bunifuLabel4.Text = "₱0.00";
                    }
                }
                connection.Close();
            }
        }

        public void expensesTotalExpenses()
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();
                string query = "SELECT SUM(expense) FROM expenses";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal totalIncome = Convert.ToDecimal(result);
                        CultureInfo culture = new CultureInfo("en-PH");
                        bunifuLabel9.Text = totalIncome.ToString("C", culture);
                    }
                    else
                    {
                        bunifuLabel4.Text = "₱0.00";
                    }
                }
                connection.Close();
            }
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel5_Click(object sender, EventArgs e)
        {

        }

        private void incomeBtn_Click(object sender, EventArgs e)
        {
            bunifuLabel11.Text = "Recent Income";
            displayincomeData();
            expense_chartLbl.Text = "Income Chart";
            LoadIncomeDataIntoPieChart();
        }

        private void expensesBtn_Click(object sender, EventArgs e)
        {
            bunifuLabel11.Text = "Recent Expenses";
            displayExpenseData();
            expense_chartLbl.Text = "Expenses Chart";
            LoadExpenseDataIntoPieChart();
        }

        private void LoadExpenseDataIntoPieChart()
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();
                string query = "SELECT Category, SUM(expense) AS TotalCost FROM expenses GROUP BY Category";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    pieChart1.Series.Clear();

                    while (reader.Read())
                    {
                        string category = reader["Category"].ToString();
                        decimal totalCost = Convert.ToDecimal(reader["TotalCost"]);

                        var series = new LiveCharts.Wpf.PieSeries
                        {
                            Title = category,
                            Values = new ChartValues<LiveCharts.Defaults.ObservableValue> { new LiveCharts.Defaults.ObservableValue((double)totalCost) },
                            DataLabels = true,
                            LabelPoint = chartPoint => $"{category}: {chartPoint.Y} ({chartPoint.Participation:P})"
                        };

                        pieChart1.Series.Add(series);
                    }
                }
                connection.Close();
            }
        }
        private void LoadIncomeDataIntoPieChart()
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();
                string query = "SELECT Category, SUM(income) AS TotalCost FROM income GROUP BY Category";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    pieChart1.Series.Clear();

                    while (reader.Read())
                    {
                        string category = reader["Category"].ToString();
                        decimal totalCost = Convert.ToDecimal(reader["TotalCost"]);

                        var series = new LiveCharts.Wpf.PieSeries
                        {
                            Title = category,
                            Values = new ChartValues<LiveCharts.Defaults.ObservableValue> { new LiveCharts.Defaults.ObservableValue((double)totalCost) },
                            DataLabels = true,
                            LabelPoint = chartPoint => $"{category}: {chartPoint.Y} ({chartPoint.Participation:P})"
                        };

                        pieChart1.Series.Add(series);
                    }
                }
                connection.Close();
            }
        }


        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            ShowAndCenterUserControl1(expenseModal1, this);
        }

        private void bunifuPictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void ShowAndCenterUserControl1(ExpenseModal expenseMod, Control parent)
        {
            // Ensure the parent and userControl are valid
            if (expenseMod == null || parent == null) return;

            // Calculate the centered position
            int x = (parent.ClientSize.Width - expenseMod.Width) / 2;
            int y = (parent.ClientSize.Height - expenseMod.Height) / 2;

            // Set the location of the UserControl
            expenseMod.Location = new Point(x, y);

            // Make the UserControl visible
            expenseMod.Visible = true;
        }

        private void ShowAndCenterUserControl2(IncomeModal incomeMod, Control parent)
        {
            // Ensure the parent and userControl are valid
            if (incomeMod == null || parent == null) return;

            // Calculate the centered position
            int x = (parent.ClientSize.Width - incomeMod.Width) / 2;
            int y = (parent.ClientSize.Height - incomeMod.Height) / 2;

            // Set the location of the UserControl
            incomeMod.Location = new Point(x, y);

            // Make the UserControl visible
            incomeMod.Visible = true;
        }

        private void Dashboardv2_Resize(object sender, EventArgs e)
        {
            if (expenseModal1.Visible)
            {
                ShowAndCenterUserControl1(expenseModal1, (Control)sender);
            }
            if (incomeModal1.Visible)
            {
                ShowAndCenterUserControl2(incomeModal1, (Control)sender);
            }
        }

        private void bunifuPanel7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            ShowAndCenterUserControl2(incomeModal1, this);
        }

        private void expenseModal1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuPanel8_Click(object sender, EventArgs e)
        {

        }
    }
}
