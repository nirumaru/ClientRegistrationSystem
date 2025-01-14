using ClientRegistrationApp.Models;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Identity.Client;
using System.Linq.Expressions;

namespace ClientRegistrationApp.Repositories
{
    public class ClientRepository
    {
        //connection string
        private readonly string connectionString = "Data Source=LAPTOP-GRALUI5E\\SQLEXPRESS;Initial Catalog=ClientsDB;Integrated Security=True;Trust Server Certificate=True";

        //creating a GetClients method that returns the list of Client object
        public List<Client> GetClients()
        {
            //creating a list of Client objects named clients
            var clients = new List<Client>();

            try
            {
                //connecting to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    //reading the clients
                    string sql = "SELECT * FROM clients ORDER BY id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //creating a new Client object
                                Client client = new Client();
                                client.id = reader.GetInt32(0);
                                client.name = reader.GetString(1);
                                client.email = reader.GetString(2);
                                client.phonenumber = reader.GetString(3);
                                client.address = reader.GetString(4);
                                client.category = reader.GetString(5);


                                clients.Add(client);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());

                
            }
            return clients;
            
        }

        //method to search for clients using id
        public Client? GetClient(int id)
        {
            try
            {
                //connecting to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM clients where id=@id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // checking to see if the client with the id exists
                            if (reader.Read())
                            {
                                //if the client exits, create a new client object
                                Client client = new Client();
                                client.id = reader.GetInt32(0);
                                client.name = reader.GetString(1);
                                client.email = reader.GetString(2);
                                client.phonenumber = reader.GetString(3);
                                client.address = reader.GetString(4);
                                client.category = reader.GetString(5);

                                return client;

                            }
                        }
                    }
                }

            }
            catch(Exception ex) 
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
            return null;
        }

        //create a public class to create a client, void because it does not return anything
        public void CreateClient(Client client)
        {
            try
            {
                //connect to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    //query to insert client data 
                    string sql = "INSERT INTO clients " +
                                 "(name, email, phonenumber, address, category) VALUES" +
                                 "(@name, @email, @phonenumber, @address, @category);";

                    
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        //adding client.name as the @name for the value in database
                        command.Parameters.AddWithValue("@name", client.name);
                        command.Parameters.AddWithValue("@email", client.email);
                        command.Parameters.AddWithValue("@phonenumber", client.phonenumber);
                        command.Parameters.AddWithValue("@address", client.address);
                        command.Parameters.AddWithValue("@category", client.category);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }

        }

        // creating a method to update the client details
        // Client is the type of parameter and client is name of the parameter
        public void UpdateClient(Client client)
        {
            try
            {


                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE clients SET name=@name, email=@email, phonenumber=@phonenumber, address=@address WHERE id=@id;";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        //updating clients

                        command.Parameters.AddWithValue("@id", client.id);
                        command.Parameters.AddWithValue("@name", client.name);
                        command.Parameters.AddWithValue("@email", client.email);
                        command.Parameters.AddWithValue("@phonenumber", client.phonenumber);
                        command.Parameters.AddWithValue("@address", client.address);
                        command.Parameters.AddWithValue("@category", client.category);

                        command.ExecuteNonQuery();
                    }



                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }


        //creating a method to delete a client
        public void DeleteClient(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "DELETE FROM clients WHERE id=@id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                }
            }catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }

        
    }
}

