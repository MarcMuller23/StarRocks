using MySql.Data.MySqlClient;
using StarRocks.Data.Entities;
using StarRocks.Interfaces;
using StarRocks.Interfaces.Entities;
using StarRocks.Interfaces.Handlers;
using System;
using System.Collections.Generic;
using System.Data;
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
                
                string query = "INSERT INTO eventregistration(EventID,AccountID)VALUES(@EventID,@AccountID); ";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@EventID", E1.EventID);
                    command.Parameters.AddWithValue("@AccountID", E1.AccountID);
                    conn.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        //Update in CRUD
        public void UpdateEventRegistration(IEventRegistration E1)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
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
                conn.Open();
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
                conn.Open();
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

        public List<IAccount> GetAttendees(int eventId)
        {
            var userList = new List<IAccount>(); 

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand query = new MySqlCommand("select * from account a inner join eventregistration er on er.AccountID = a.ID where er.EventID = @eventId", conn))
                {
                    query.Parameters.AddWithValue("@eventId", eventId);
                    conn.Open();
                    var reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        IAccount Account = new Account();
                        Account.FirstName = reader.GetString(1);
                        Account.Preposition = reader.GetString(2);
                        Account.LastName = reader.GetString(3);

                        userList.Add(Account);
                    }
                }
            }
            return userList;
        }

    }
}
