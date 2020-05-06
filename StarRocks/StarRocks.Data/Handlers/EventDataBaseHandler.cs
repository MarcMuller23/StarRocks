using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using StarRocks.Data.Entities;

namespace StarRocks.Data.Handlers
{
    public class EventDataBaseHandler
    {
        private static string connectionString = "";

        public static void SetConnectionString(string constring)
        {
            connectionString = constring;
        }
        public EventDataBaseHandler()
        {

        }
        public List<Event> GetAllEvents()
        {
            List<Event> Events = new List<Event>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM event";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Event dto = new Event();
                        dto.ID = reader.GetInt32(0);
                        dto.AccountID = reader.GetInt32(1);
                        dto.CategoryID = reader.GetInt32(2);
                        dto.Name = reader.GetString(3);
                        dto.Description = reader.GetString(4);
                        dto.Date = reader.GetDateTime(5);
                        dto.Location = reader.GetString(6);
                        dto.MaxCapacity = reader.GetInt32(7);
                        Events.Add(dto);
                    }
                }
            }
            return Events;
        }
        public void CreateEvent(Event E1)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = $"INSERT INTO event VALUES(@ID, @Catagory,@Name,@Description,@Date,@Location,@MaxCapacity; ";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ID", E1.AccountID);
                    command.Parameters.AddWithValue("@Catagory", E1.CategoryID);
                    command.Parameters.AddWithValue("@Name", E1.Name);
                    command.Parameters.AddWithValue("@Description", E1.Description);
                    command.Parameters.AddWithValue("@Date", E1.Date);
                    command.Parameters.AddWithValue("@Location", E1.Location);
                    command.Parameters.AddWithValue("@MaxCapacity", E1.MaxCapacity);


                    command.ExecuteNonQuery();
                }
            }
        }
        public void UpdateEvent(Event E1)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = $"UPDATE werknemer SET Name = @Name, Description = @Description, Date=@Date,Location=@Location,MaxCapacity=@MaxCapacity WHERE ID=@ID; ";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ID", E1.AccountID);
                    command.Parameters.AddWithValue("@Catagory", E1.CategoryID);
                    command.Parameters.AddWithValue("@Name", E1.Name);
                    command.Parameters.AddWithValue("@Description", E1.Description);
                    command.Parameters.AddWithValue("@Date", E1.Date);
                    command.Parameters.AddWithValue("@Location", E1.Location);
                    command.Parameters.AddWithValue("@MaxCapacity", E1.MaxCapacity);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void DeleteEvent(int ID)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = $"DELETE FROM event WHERE ID=@ID";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ID", ID);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
