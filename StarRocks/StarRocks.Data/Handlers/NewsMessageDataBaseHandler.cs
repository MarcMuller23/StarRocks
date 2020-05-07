using MySql.Data.MySqlClient;
using StarRocks.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Data.Handlers
{
    public class NewsMessageDataBaseHandler
    {
        private static string connectionString = "";

        public static void SetConnectionString(string constring)
        {
            connectionString = constring;
        }

        public NewsMessageDataBaseHandler()
        {

        }

        //Read in CRUD
        public List<NewsMessage> GetAllNewsMessages()
        {
            List<NewsMessage> Events = new List<NewsMessage>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM newsmessage";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        NewsMessage dto = new NewsMessage();
                        dto.ID = reader.GetInt32(0);
                        dto.AccountID = reader.GetInt32(1);
                        dto.Title = reader.GetString(2);
                        dto.Message = reader.GetString(3);                        
                        Events.Add(dto);
                    }
                }
            }
            return Events;
        }
        //Create in CRUD
        public void CreateNewsMessage(NewsMessage NM1)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO newsmessage VALUES(@AccountID,@Title,@Message); ";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@AccountID", NM1.AccountID);
                    command.Parameters.AddWithValue("@Title", NM1.Title);
                    command.Parameters.AddWithValue("@Message", NM1.Message);

                    command.ExecuteNonQuery();
                }
            }
        }

        //Update in CRUD
        public void UpdateNewsMessage(NewsMessage NM1)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "UPDATE newsmessage SET ID = @ID, AccountID = @AccountID, Title=@Title,Message=@Message WHERE ID=@ID; ";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ID", NM1.ID);
                    command.Parameters.AddWithValue("@AccountID", NM1.AccountID);
                    command.Parameters.AddWithValue("@Title", NM1.Title);
                    command.Parameters.AddWithValue("@Message", NM1.Message);

                    command.ExecuteNonQuery();
                }
            }
        }

        //Delete in CRUD
        public void DeleteNewsMessage(int ID)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "DELETE FROM newsmessage WHERE ID=@ID";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ID", ID);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
