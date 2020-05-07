using MySql.Data.MySqlClient;
using StarRocks.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Data.Handlers
{
    public class ReminderDataBaseHandler
    {
        private static string connectionString = "";

        public static void SetConnectionString(string constring)
        {
            connectionString = constring;
        }
        public ReminderDataBaseHandler()
        {

        }

        //Read in CRUD
        public List<Reminder> GetAllReminders()
        {
            List<Reminder> reminders = new List<Reminder>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM reminder";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Reminder dto = new Reminder();
                        dto.ID = reader.GetInt32(0);
                        dto.EventID = reader.GetInt32(1);
                        dto.Date = reader.GetDateTime(2);
                        dto.Message = reader.GetString(3);
                        
                        reminders.Add(dto);
                    }
                }
            }
            return reminders;
        }

        //Create in CRUD
        public void CreateReminder(Reminder R1)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO reminder VALUES(@EventID, @Date,@Message); ";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@EventID", R1.EventID);
                    command.Parameters.AddWithValue("@Date", R1.Date);
                    command.Parameters.AddWithValue("@Message", R1.Message);

                    command.ExecuteNonQuery();
                }
            }
        }

        //Update in CRUD
        public void UpdateReminder(Reminder R1)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "UPDATE reminder SET EventID = @EventID, Date = @Date, Message=@Message WHERE ID=@ID; ";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ID", R1.ID);
                    command.Parameters.AddWithValue("@EventID", R1.EventID);
                    command.Parameters.AddWithValue("@Date", R1.EventID);
                    command.Parameters.AddWithValue("@Message", R1.Message);

                    command.ExecuteNonQuery();
                }
            }
        }

        //Delete in CRUD
        public void DeleteReminder(int ID)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "DELETE FROM reminder WHERE ID=@ID";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ID", ID);
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
