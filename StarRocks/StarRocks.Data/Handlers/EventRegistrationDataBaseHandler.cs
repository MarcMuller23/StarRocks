using MySql.Data.MySqlClient;
using StarRocks.Data.Entities;
using StarRocks.Interfaces.Entities;
using StarRocks.Interfaces.Handlers;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Data.Handlers
{
    public class EventRegistrationDataBaseHandler : IEventRegistrationDataBaseHandler
    {
        private static string connectionString = "";

        public static void SetConnectionString(string constring)
        {
            connectionString = constring;
        }

        public EventRegistrationDataBaseHandler()
        {

        }

        //Read in CRUD
        public List<IEventRegistration> GetAllEventRegistrations()
        {
            List<IEventRegistration> eventRegistrations = new List<IEventRegistration>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM eventregistration";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        EventRegistration dto = new EventRegistration();
                        dto.EventID = reader.GetInt32(0);
                        dto.AccountID = reader.GetInt32(1);
                        eventRegistrations.Add(dto);
                    }
                }
            }
            return eventRegistrations;
        }

        //Create in CRUD
        public void CreateEventRegistration(IEventRegistration E1)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO eventregistration VALUES(@EventID, @AccountID); ";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@EventID", E1.EventID);
                    command.Parameters.AddWithValue("@AccountID", E1.AccountID);
                    
                    command.ExecuteNonQuery();
                }
            }
        }

        //Update in CRUD
        public void UpdateEventRegistration(IEventRegistration E1)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "UPDATE eventregistration SET EventID = @EventID, AccountID = @AccountID WHERE ID=@ID; ";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@EventID", E1.EventID);
                    command.Parameters.AddWithValue("@AccountID", E1.AccountID);
                    command.ExecuteNonQuery();
                }
            }
        }

        //Delete in CRUD
        public void DeleteEventRegistration(int ID)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "DELETE FROM eventregistration WHERE ID=@ID";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ID", ID);
                    command.ExecuteNonQuery();
                }
            }
        }

        //GetById
        public IEventRegistration GetById(IEventRegistration eventRegistration)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM eventRegistration WHERE ID = @ID; ";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ID", eventRegistration.ID);
                    command.Parameters.AddWithValue("@EventID", eventRegistration.EventID);
                    command.Parameters.AddWithValue("@AccountID", eventRegistration.AccountID);
                }
            }
            return eventRegistration;
        }

        
    }
}
