using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Expense_Tracker_v2
{
    internal class CategoryData
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\CODING\OOP\Expense Tracker v2\Expense Tracker v2\expensesDB.mdf"";Integrated Security=True;Connect Timeout=30;Context Connection=False";

        public int ID { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Date { get; set; }

        public List<CategoryData> categoryListData(int userId)
        {
            List<CategoryData> listData = new List<CategoryData>();

            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string selectedData = "SELECT * FROM categories WHERE userId = @userId";

                using(SqlCommand cmd = new SqlCommand(selectedData, connect))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        CategoryData cData = new CategoryData();
                        cData.ID = (int)reader["id"];
                        cData.Category = reader["category"].ToString();
                        cData.Type = reader["type"].ToString();
                        cData.Status = reader["status"].ToString();
                        cData.Date = ((DateTime)reader["date_insert"]).ToString("MM-dd-yyyy");

                        listData.Add(cData);
                    }
                }
            }
            return listData;
        }
    }
}
