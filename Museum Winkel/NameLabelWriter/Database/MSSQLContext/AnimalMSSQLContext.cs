using NameLabelWriter.Database.Interfaces;
using System;
using System.Collections.Generic;
using NameLabelWriter.Domain;
using System.Data.SqlClient;

namespace NameLabelWriter.Database.MSSQLContext
{
    public class AnimalMSSQLContext : IAnimalContext
    {
        public bool deleteAnimal(int id)
        {
            string query = "DELETE FROM animal WHERE id = @id";
            try
            {
                using (SqlConnection connection = DatabaseConnection.Connection)
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                            command.Parameters.AddWithValue("@id", id);
                            command.ExecuteNonQuery();
                            return true;
                    }
                }
            }
            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return false;
        }

        public List<Animal> getAllAnimals()
        {
            List<Animal> animals = new List<Animal>();
            string query = "SELECT * FROM animal order by name";
            try
            {
                using (SqlConnection connection = DatabaseConnection.Connection)
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                animals.Add(new Animal(
                                    Convert.ToInt32(reader["id"]),
                                    Convert.ToString(reader["name"]),
                                    Convert.ToString(reader["country_of_origin"])
                                    ));
                            }
                            return animals;
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return null;
        }

        public List<Animal> getAnimalsByName(string Name)
        {
            List<Animal> animals = new List<Animal>();
            string query = "SELECT * FROM animal WHERE name LIKE @Name order by name";
            try
            {
                using (SqlConnection connection = DatabaseConnection.Connection)
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", "%" + Name + "%");
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                animals.Add(new Animal(
                                    Convert.ToInt32(reader["id"]),
                                    Convert.ToString(reader["name"]),
                                    Convert.ToString(reader["country_of_origin"])
                                    ));
                            }
                            return animals;
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return null;
        }

        public bool insertAnimals(List<Animal> animals)
        {
            string query = "INSERT INTO animal(name, country_of_origin) VALUES(@name, @countryOfOrigin)";
            try
            {
                using (SqlConnection connection = DatabaseConnection.Connection)
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        foreach (Animal animal in animals)
                        {
                            command.Parameters.AddWithValue("@name", animal.name);
                            command.Parameters.AddWithValue("@countryOfOrigin", animal.countryOfOrigin);
                            command.ExecuteNonQuery();
                            command.Parameters.Clear();
                        }
                        return true;
                    }
                }
            }
            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return false;
        }

        public bool updateAnimal(Animal animal)
        {
            string query = "UPDATE animal SET name = @name, country_of_origin = @countryOfOrigin where id = @id";
            try
            {
                using (SqlConnection connection = DatabaseConnection.Connection)
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", animal.name);
                        command.Parameters.AddWithValue("@countryOfOrigin", animal.countryOfOrigin);
                        command.Parameters.AddWithValue("@id", animal.id);
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return false;
        }
    }
}