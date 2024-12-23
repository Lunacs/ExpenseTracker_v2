﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Expense_Tracker_v2
{
    internal class IncomeData
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\CODING\OOP\Expense Tracker v2\Expense Tracker v2\expensesDB.mdf"";Integrated Security=True;Connect Timeout=30;Context Connection=False";

        public int ID { get; set; }
        public string Category { get; set; }
        public string Item { get; set; }
        public double Cost { get; set; }
        public string Description { get; set; }
        public string DateIncome { get; set; }

        public List<IncomeData> IncomeListData(int userId)
        {
            List<IncomeData> listData = new List<IncomeData>();
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();

                string selectData = "SELECT * FROM income WHERE userId = @userId";
                using (SqlCommand cmd = new SqlCommand(selectData, connection))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        IncomeData iData = new IncomeData();

                        iData.ID = Convert.ToInt32(reader["id"]);
                        iData.Category = reader["category"].ToString();
                        iData.Item = reader["item"].ToString();
                        iData.Cost = Convert.ToDouble(reader["income"]);
                        iData.Description = reader["description"].ToString();
                        iData.DateIncome = ((DateTime)reader["date_income"]).ToString("MM-dd-yyyy");

                        listData.Add(iData);
                    }
                }
                connection.Close();
            }
            return listData;
        }

        public List<IncomeData> IncomeListDataTOP(int userId)
        {
            List<IncomeData> listData = new List<IncomeData>();
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();

                string selectData = "SELECT TOP 5 item, description, category, income FROM income WHERE userId = @userId ORDER BY id DESC";
                using (SqlCommand cmd = new SqlCommand(selectData, connection))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        IncomeData iData = new IncomeData();

                        iData.Item = reader["item"].ToString();
                        iData.Description = reader["description"].ToString();
                        iData.Category = reader["category"].ToString();
                        iData.Cost = Convert.ToDouble(reader["income"]);
                        

                        listData.Add(iData);
                    }
                }
                connection.Close();
            }
            return listData;
        }
    }
}
