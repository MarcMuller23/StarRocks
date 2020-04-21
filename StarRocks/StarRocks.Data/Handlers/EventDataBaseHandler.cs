﻿using System;
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
    }
}