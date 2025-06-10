using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1.Repositories
{
    public class ClientRepository
    {
        private readonly string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=winformdb;Integrated Security=True;Trust Server Certificate=True";

        // Get all clients
        public List<Client> GetClients()
        {
            var clients = new List<Client>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM clients ORDER BY id DESC";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Client client = new Client
                            {
                                id = reader.GetInt32(0),
                                firstName = reader.GetString(1),
                                lastName = reader.GetString(2),
                                email = reader.GetString(3),
                                phone = reader.GetString(4),
                                address = reader.GetString(5),
                                createdAt = reader.GetDateTime(6).ToString()
                            };

                            clients.Add(client);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving clients: " + ex.Message);
            }

            return clients;
        }

        // Get a client by ID
        public Client? GetClient(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM clients WHERE id = @id";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@id", SqlDbType.Int).Value = id;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Client
                                {
                                    id = reader.GetInt32(0),
                                    firstName = reader.GetString(1),
                                    lastName = reader.GetString(2),
                                    email = reader.GetString(3),
                                    phone = reader.GetString(4),
                                    address = reader.GetString(5),
                                    createdAt = reader.GetDateTime(6).ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving client: " + ex.Message);
            }

            return null;
        }

        // Create a new client
        public void CreateClient(Client client)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO clients (firstname, lastname, email, phone, address) " +
                                 "VALUES (@firstname, @lastname, @email, @phone, @address)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@firstname", SqlDbType.NVarChar).Value = client.firstName;
                        command.Parameters.Add("@lastname", SqlDbType.NVarChar).Value = client.lastName;
                        command.Parameters.Add("@email", SqlDbType.NVarChar).Value = client.email;
                        command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = client.phone;
                        command.Parameters.Add("@address", SqlDbType.NVarChar).Value = client.address;

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error creating client: " + ex.Message);
            }
        }

        // Update an existing client
        public void UpdateClient(Client client)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE clients SET firstname = @firstname, lastname = @lastname, " +
                                 "email = @email, phone = @phone, address = @address WHERE id = @id";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@firstname", SqlDbType.NVarChar).Value = client.firstName;
                        command.Parameters.Add("@lastname", SqlDbType.NVarChar).Value = client.lastName;
                        command.Parameters.Add("@email", SqlDbType.NVarChar).Value = client.email;
                        command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = client.phone;
                        command.Parameters.Add("@address", SqlDbType.NVarChar).Value = client.address;
                        command.Parameters.Add("@id", SqlDbType.Int).Value = client.id;

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating client: " + ex.Message);
            }
        }

        // Delete a client by ID
        public void DeleteClient(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "DELETE FROM clients WHERE id = @id";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting client: " + ex.Message);
            }
        }
    }
}
