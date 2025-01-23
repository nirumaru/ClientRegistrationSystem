using ClientRegistrationSystem.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRegistrationSystem.Repositories
{
    public class ClientRepository
    {
        //connecting to the database
        private readonly string connectionString = "Data Source=LAPTOP-GRALUI5E\\SQLEXPRESS;Initial Catalog=ClientsDB;Integrated Security=True;Trust Server Certificate=True";
    
        //creating a GetClients method that returns the List of Client Object    
        public List<Client> GetClients()
        {
            var clients = new List<Client>();

            try
            {
                //connecting to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    //reading the clients
                    string sql = "SELECT cn.ClientID AS ClientID, cn.Name AS Name," +
                        " cd.Email AS Email," +
                        " cd.PhoneNumber AS PhoneNumber," +
                        " cd.Address AS Address," +
                        " cp.Category AS Category" +
                        " FROM clientName cn" +
                        " INNER JOIN clientDetails cd ON cn.ClientID = cd.ClientID" +
                        " INNER JOIN clientProducts cp ON cn.ClientID = cp.ClientID;";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //creating a new client object
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

        public List<Client> OrderClients()
        {
            var clients = new List<Client>();

            try
            {
                //connecting to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    //reading the clients
                    string sql = "SELECT cn.ClientID AS ClientID, cn.Name AS Name," +
                        " cd.Email AS Email," +
                        " cd.PhoneNumber AS PhoneNumber," +
                        " cd.Address AS Address," +
                        " cp.Category AS Category" +
                        " FROM clientName cn" +
                        " INNER JOIN clientDetails cd ON cn.ClientID = cd.ClientID" +
                        " INNER JOIN clientProducts cp ON cn.ClientID = cp.ClientID" +
                        " ORDER BY cn.Name;";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //creating a new client object
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

        //creating method to search for clients usint their id and retrieving that data from the database
        public Client? GetClient(int id)
        {
            try
            {
                //connecting to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    string sql = "SELECT cn.ClientID AS ClientID," +
                        " cn.Name AS Name," +
                        " cd.Email AS Email," +
                        " cd.PhoneNumber AS PhoneNumber," +
                        " cd.Address AS Address," +
                        " cp.Category AS Category" +
                        " FROM clientName cn" +
                        " INNER JOIN clientDetails cd ON cn.ClientID = cd.ClientID" +
                        " INNER JOIN clientProducts cp ON cn.ClientID = cp.ClientID" +
                        " WHERE cn.ClientID=@id;";

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
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
            return null;
        }


        //method to create a new row in the database using the values of the form
        public void CreateClient(Client client)
        {
            try
            {
                //connect to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    //query to insert client data 
                    string sql = "BEGIN TRANSACTION;" +
                                "INSERT INTO clientName (Name) VALUES (@name);" +
                                "DECLARE @ClientID INT = SCOPE_IDENTITY();" +
                                "INSERT INTO clientDetails (ClientID, Email, PhoneNumber, Address) " +
                                "VALUES (@ClientID, @email, @phonenumber, @address);" +
                                "INSERT INTO clientProducts (ClientID, Category) " +
                                "VALUES (@ClientID, @category);" +
                                "COMMIT TRANSACTION;";



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
            catch (Exception ex)
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
                    string sql = "UPDATE clientName SET Name=@name WHERE ClientID=@id;" +
                        "UPDATE clientDetails SET Email=@email, PhoneNumber=@phonenumber, Address=@address WHERE ClientID=@id;" +
                        "UPDATE clientProduts SET Category=@category WHERE ClientID=@id; ";

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

        public void DeleteClient(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();



                    //deleting from the tables with foreign key first so that it doesn't conflict with the primary table
                    string sql = "DELETE FROM clientDetails WHERE ClientID=@id;" +
                        "DELETE FROM clientProducts WHERE ClientID=@id;" +
                        "DELETE FROM clientName WHERE ClientID=@id";                        ;
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }
    }
}
