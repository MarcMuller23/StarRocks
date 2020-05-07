using MySql.Data.MySqlClient;
using StarRocks.Data.Entities;
using StarRocks.Interfaces;
using StarRocks.Interfaces.Handlers;
using System.Collections.Generic;

namespace StarRocks.Data.Handlers
{
    class CatagoryDataBaseHandler : ICategoryDataBaseHandler
    {
        private static string connectionString = "";

        public static void SetConnectionString(string constring)
        {
            connectionString = constring;
        }

        public List<ICategorie> GetAllCatagory()
        {
            List<ICategorie> Categories = new List<ICategorie>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM Categorie";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Categorie dto = new Categorie();
                        dto.ID = reader.GetInt32(0);
                        dto.AccountID = reader.GetInt32(1);
                        dto.Name = reader.GetString(2);
                        dto.Description = reader.GetString(3);
                        Categories.Add(dto);
                    }
                }
            }
            return Categories;
        }
        public void CreateEvent(ICategorie C1)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO Categorie VALUES(@AccountID, @Name,@Description) ";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@AccountID", C1.AccountID);
                    command.Parameters.AddWithValue("@Name", C1.Name);
                    command.Parameters.AddWithValue("@Description", C1.Description);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void UpdateEvent(ICategorie C1)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = $"UPDATE Categorie SET AccountID = @AccountID, Name = @Name, Description=@Description WHERE ID=@ID; ";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ID", C1.ID);
                    command.Parameters.AddWithValue("@AccountID", C1.AccountID);
                    command.Parameters.AddWithValue("@Name", C1.Name);
                    command.Parameters.AddWithValue("@Description", C1.Description);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void DeleteEvent(int ID)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = $"DELETE FROM Categorie WHERE ID=@ID";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ID", ID);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

