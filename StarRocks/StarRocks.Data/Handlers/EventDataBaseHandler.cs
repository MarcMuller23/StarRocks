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

        //READ
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

        //CREATE
        public void CreateEvent(Event E1)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = $"INSERT INTO event VALUES({E1.ID},{E1.AccountID}, {E1.CategoryID},{E1.Name},{E1.Description},{E1.Date},{E1.Location},{E1.MaxCapacity}; ";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        //UPDATE
        public void UpdateEvent(Event E1)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = $"UPDATE werknemer SET Name = {E1.Name}, Description = {E1.Description}, Date={E1.Date},Location={E1.Location},MaxCapacity={E1.MaxCapacity} WHERE ID={E1.ID}; ";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        //DELETE
        public void DeleteEvent(int ID)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = $"DELETE FROM event WHERE ID={ID}";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
