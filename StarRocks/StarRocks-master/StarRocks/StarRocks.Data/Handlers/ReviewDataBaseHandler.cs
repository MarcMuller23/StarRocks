using MySql.Data.MySqlClient;
using StarRocks.Data.Entities;
using StarRocks.Interfaces.Entities;
using StarRocks.Interfaces.Handlers;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Data.Handlers
{
    public class ReviewDataBaseHandler : IReviewDataBaseHandler
    {
        private static string connectionString = "";

        public static void SetConnectionString(string constring)
        {
            connectionString = constring;
        }

        public ReviewDataBaseHandler()
        {

        }

        //Read in CRUD
        public List<IReview> GetAllReviews()
        {
            List<IReview> reviews = new List<IReview>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM review";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Review dto = new Review();
                        dto.ID = reader.GetInt32(0);
                        dto.EventID = reader.GetInt32(1);
                        dto.AccountID = reader.GetInt32(2);
                        dto.Rating = reader.GetInt32(3);
                        dto.Message = reader.GetString(4);

                        reviews.Add(dto);
                    }
                }
            }
            return reviews;
        }

        //Create in CRUD
        public void CreateReview(IReview R1)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO review VALUES(@EventID, @AccountID,@Rating,@Message); ";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@EventID", R1.EventID);
                    command.Parameters.AddWithValue("@AccountID", R1.AccountID);
                    command.Parameters.AddWithValue("@Rating", R1.Rating);
                    command.Parameters.AddWithValue("@Message", R1.Message);

                    command.ExecuteNonQuery();
                }
            }
        }

        //Update in CRUD
        public void UpdateReview(IReview R1)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "UPDATE review SET EventID = @EventID, AccountID = @AccountID, Rating=@Rating,Message=@Message WHERE ID=@ID; ";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ID", R1.ID);
                    command.Parameters.AddWithValue("@EventID", R1.EventID);
                    command.Parameters.AddWithValue("@AccountID", R1.AccountID);
                    command.Parameters.AddWithValue("@Rating", R1.Rating);
                    command.Parameters.AddWithValue("@Message", R1.Message);

                    command.ExecuteNonQuery();
                }
            }
        }

        //Delete in CRUD
        public void DeleteReview(int ID)
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
