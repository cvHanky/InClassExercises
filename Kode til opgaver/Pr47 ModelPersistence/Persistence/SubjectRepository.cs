using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Pr47_ModelPersistence.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Pr47_ModelPersistence.Persistence
{
    public class SubjectRepository
    {
        List<Subject> subjects;
        public string? ConnectionString { get; set; }

        public SubjectRepository()
        {
            subjects = new List<Subject>();

            IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            ConnectionString = config.GetConnectionString("MyDBConnection");

            RetrieveAll();
        }

        public void RetrieveAll()
        {
            subjects.Clear();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Subject", con);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Subject subject = new Subject
                        {
                            Id = int.Parse(reader["Id"].ToString()),
                            Name = reader["Name"].ToString()
                        };
                        subjects.Add(subject);
                    }
                }
            }
        }
        public void Add(Subject subject)
        {
            // First we add it to the database.
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Subject(Name)" +
                    "VALUES(@Name)" +
                    "SELECT @@IDENTITY", con);
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = subject.Name;
                subject.Id = Convert.ToInt32(cmd.ExecuteScalar());
            }

            // Then add it to the "in-memory" storage.
            subjects.Add(subject);
        }
        public void Update(Subject subject)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Subject SET Name = @Name WHERE Id = @Id", con);
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = subject.Name;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = subject.Id;
                cmd.ExecuteNonQuery();
            }
        }
        public void Delete(Subject subject)
        {
            // First deleting from database
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Subject WHERE Id = @Id", con);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = subject.Id;
                cmd.ExecuteNonQuery();
            }

            // Then deleting it from the in-memory list. 
            subjects.Remove(subject);
        }
        public Subject? RetrieveById(int id)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Subject WHERE Id = @Id", con);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Subject subject = new Subject
                        {
                            Id = int.Parse(reader["Id"].ToString()),
                            Name = reader["Name"].ToString()
                        };
                        return subject;
                    }
                }
            }
            return null;
        }
    }
}
