﻿using MySql.Data.MySqlClient;
using StarRocks.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Data.Handlers
{
    public class RoleDataBaseHandler
    {
        private static string connectionString = "";

        public static void SetConnectionString(string constring)
        {
            connectionString = constring;
        }

        public RoleDataBaseHandler()
        {

        }

        //Read in CRUD
        public List<Role> GetAllRoles()
        {
            List<Role> roles = new List<Role>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM role";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Role dto = new Role();
                        dto.ID = reader.GetInt32(0);
                        dto.Role_Description = reader.GetString(1);

                        roles.Add(dto);
                    }
                }
            }
            return roles;
        }

        //Create in CRUD
        public void CreateRole(Role R1)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO role VALUES(@Role_Description; ";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Role_Description", R1.Role_Description);

                    command.ExecuteNonQuery();
                }
            }
        }

        //Update in CRUD
        public void UpdateRole(Role R1)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "UPDATE role SET Role_Description = @Role_Description WHERE ID=@ID; ";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Role_Description", R1.Role_Description);

                    command.ExecuteNonQuery();
                }
            }
        }

        //Delete in CRUD
        public void DeleteRole(int ID)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "DELETE FROM role WHERE ID=@ID";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ID", ID);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
