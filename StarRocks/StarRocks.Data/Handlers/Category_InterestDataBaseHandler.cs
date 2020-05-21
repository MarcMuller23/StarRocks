using MySql.Data.MySqlClient;
using StarRocks.Data.Entities;
using StarRocks.Interfaces;
using StarRocks.Interfaces.Handlers;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Data.Handlers
{
    public class Category_InterestDataBaseHandler : ICategory_InterestDataBaseHandler
    {
        private static string connectionString = "";

        public static void SetConnectionString(string constring)
        {
            connectionString = constring;
        }

        public List<ICategorie_Interest> GetAllCategorie_Interest()
        {
            List<ICategorie_Interest> Categorie_Interests = new List<ICategorie_Interest>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM Categorie_Interests";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Categorie_Interest dto = new Categorie_Interest();
                        dto.ID = reader.GetInt32(0);
                        dto.CategorieID = reader.GetInt32(1);
                        dto.AccountID = reader.GetInt32(2);
                        dto.EventPoint = reader.GetInt32(3);

                        Categorie_Interests.Add(dto);
                    }
                }
            }
            return Categorie_Interests;
        }
        public void CreateCategorie_Interest(ICategorie_Interest CI1)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO Categorie_Interest VALUES( @CategorieID,@AccountID,@EventPoint,@Password,@PhoneNumber,@Street,@HouseNumber,@Addition,@PostalCode,@City,@Birthdate); ";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    
                    command.Parameters.AddWithValue("@CategorieID", CI1.CategorieID);
                    command.Parameters.AddWithValue("@AccountID", CI1.AccountID);
                    command.Parameters.AddWithValue("@EventPoint", CI1.EventPoint);   
                    command.ExecuteNonQuery();
                }
            }
        }
        public void UpdateCategorie_Interest(ICategorie_Interest CI1)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "UPDATE Categorie_Interest SET CategorieID = @CategorieID, AccountID = @AccountID, EventPoint=@EventPoint WHERE ID=@ID; ";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ID", CI1.ID);
                    command.Parameters.AddWithValue("@CategorieID", CI1.CategorieID);
                    command.Parameters.AddWithValue("@AccountID", CI1.AccountID);
                    command.Parameters.AddWithValue("@EventPoint", CI1.EventPoint);                    
                    command.ExecuteNonQuery();
                }
            }
        }
        public void DeleteCategorie_Interest(int ID)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "DELETE FROM Categorie_Interest WHERE ID=@ID";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ID", ID);
                    command.ExecuteNonQuery();
                }
            }
        }

        public ICategorie_Interest GetById(ICategorie_Interest categorie_Interest)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM category_interest WHERE ID = @ID; ";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ID", categorie_Interest.ID);

                }
            }
            return categorie_Interest;
        }
    }
}

