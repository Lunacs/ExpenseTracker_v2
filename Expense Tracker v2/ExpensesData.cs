using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Expense_Tracker_v2
{
    internal class ExpensesData
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\CODING\OOP\Expense Tracker v2\Expense Tracker v2\expensesDB.mdf"";Integrated Security=True;Connect Timeout=30;Context Connection=False";

        public int ID { get; set; }
        public string Category { get; set; }
        public string Item { get; set; }
        public double Cost { get; set; }
        public string Description { get; set; }
        public string DateIncome { get; set; }

        public List<ExpensesData> expensesListData()
        {
            List<ExpensesData> listData = new List<ExpensesData>();
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();

                string selectData = "SELECT * FROM expenses";
                using (SqlCommand cmd = new SqlCommand(selectData, connection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ExpensesData eData = new ExpensesData();

                        eData.ID = Convert.ToInt32(reader["id"]);
                        eData.Category = reader["category"].ToString();
                        eData.Item = reader["item"].ToString();
                        eData.Cost = Convert.ToDouble(reader["expense"]);
                        eData.Description = reader["description"].ToString();
                        eData.DateIncome = ((DateTime)reader["date_expense"]).ToString("MM-dd-yyyy");

                        listData.Add(eData);
                    }
                }
                connection.Close();
            }
            return listData;
        }

        public List<ExpensesData> expensesListDataTOP()
        {
            List<ExpensesData> listData = new List<ExpensesData>();
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();

                //string selectData = "SELECT TOP 5 item as Item, description as About, category as Category, FORMAT(expense, 'N2') as Amount" +
                //    "FROM expenses ORDER BY id DESC";
                //string selectData = "SELECT TOP 5 * FROM expenses ORDER BY date_expense DESC"; // Example query
                string selectData = "SELECT TOP 5 item, description, category, expense FROM expenses ORDER BY id DESC";


                using (SqlCommand cmd = new SqlCommand(selectData, connection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ExpensesData eData = new ExpensesData();

                        eData.Item = reader["item"].ToString(); // Use alias
                        eData.Description = reader["description"].ToString(); // Use alias
                        eData.Category = reader["category"].ToString(); // Use alias
                        eData.Cost = Convert.ToDouble(reader["expense"]); // Handle formatted string


                        listData.Add(eData);
                    }
                }
                connection.Close();
            }
            return listData;
        }
    }
}
