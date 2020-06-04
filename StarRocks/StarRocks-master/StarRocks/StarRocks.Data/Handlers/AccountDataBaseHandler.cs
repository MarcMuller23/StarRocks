using MySql.Data.MySqlClient;
using StarRocks.Data.Entities;
using StarRocks.Interfaces;
using StarRocks.Interfaces.Handlers;
using System.Collections.Generic;

namespace StarRocks.Data.Handlers
{
    public class AccountDataBaseHandler : IAccountDataBaseHandler
    {
        private static string connectionString = "";

        public static void SetConnectionString(string constring)
        {
            connectionString = constring;
        }

        public List<IAccount> GetAllAccounts()
        {
            List<IAccount> Accounts = new List<IAccount>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM account";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Account dto = new Account();
                        dto.ID = reader.GetString(0);
                        dto.FirstName = reader.GetString(1);
                        dto.Preposition = reader.GetString(2);
                        dto.LastName = reader.GetString(3);
                        dto.Email = reader.GetString(4);
                        dto.Password = reader.GetString(5);
                        dto.PhoneNumber = reader.GetString(6);
                        dto.Street = reader.GetString(7);
                        dto.HouseNumber = reader.GetInt32(8);
                        dto.Addition = reader.GetString(9);
                        dto.PostalCode = reader.GetString(10);
                        dto.City = reader.GetString(11);
                        dto.Birthdate = reader.GetDateTime(12);
                        Accounts.Add(dto);
                    }
                }
            }
            return Accounts;
        }
        public void CreateAccount(IAccount A1)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO Account VALUES( @FirstName,@Preposition,@LastName,@Email,@Password,@PhoneNumber,@Street,@HouseNumber,@Addition,@PostalCode,@City,@Birthdate); ";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@FirstName", A1.FirstName);
                    command.Parameters.AddWithValue("@Preposition", A1.Preposition);
                    command.Parameters.AddWithValue("@LastName", A1.LastName);
                    command.Parameters.AddWithValue("@Email", A1.Email);
                    command.Parameters.AddWithValue("@Password", A1.Password);
                    command.Parameters.AddWithValue("@PhoneNumber", A1.PhoneNumber);
                    command.Parameters.AddWithValue("@Street", A1.Street);
                    command.Parameters.AddWithValue("@Addition", A1.Addition);
                    command.Parameters.AddWithValue("@PostalCode", A1.PostalCode);
                    command.Parameters.AddWithValue("@City", A1.City);
                    command.Parameters.AddWithValue("@Birthdate", A1.Birthdate);




                    command.ExecuteNonQuery();
                }
            }
        }
        public void UpdateAccount(IAccount A1)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "UPDATE account SET Firstname = @FirstName, Preposition = @Preposition, LastName=@LastName,Email=@Email,Password=@Password,PhoneNumber=@PhoneNumber,Street=@Street,Addition=@Addition,PostalCode=@PostalCode,City=@City,Birthdate=@Birthdate WHERE ID=@ID; ";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ID", A1.ID);
                    command.Parameters.AddWithValue("@FirstName", A1.FirstName);
                    command.Parameters.AddWithValue("@Preposition", A1.Preposition);
                    command.Parameters.AddWithValue("@LastName", A1.LastName);
                    command.Parameters.AddWithValue("@Email", A1.Email);
                    command.Parameters.AddWithValue("@Password", A1.Password);
                    command.Parameters.AddWithValue("@PhoneNumber", A1.PhoneNumber);
                    command.Parameters.AddWithValue("@Street", A1.Street);
                    command.Parameters.AddWithValue("@Addition", A1.Addition);
                    command.Parameters.AddWithValue("@PostalCode", A1.PostalCode);
                    command.Parameters.AddWithValue("@City", A1.City);
                    command.Parameters.AddWithValue("@Birthdate", A1.Birthdate);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void DeleteAccount(int ID)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "DELETE FROM account WHERE ID=@ID";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ID", ID);
                    command.ExecuteNonQuery();
                }
            }
        }

        public IAccount GetById(IAccount account)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM account WHERE ID = @ID; ";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ID", account.ID);

                }
            }
            return account;
        }
    }
}

