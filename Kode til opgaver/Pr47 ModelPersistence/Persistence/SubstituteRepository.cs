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
    public class SubstituteRepository
    {
        List<Substitute> subs;

        public string? ConnectionString { get; set; }

        public SubstituteRepository()
        {
            subs = new List<Substitute>();
            IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            ConnectionString = config.GetConnectionString("MyDBConnection");

            RetrieveAll();
        }

        public void RetrieveAll()
        {
            subs.Clear();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Substitute", con);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Substitute sub = new Substitute
                        {
                            Name = reader["Name"].ToString(),
                            Phone = reader["Phone"].ToString(),
                            CPR = reader["CPR"].ToString(),
                            CertificateDate = DateTime.Parse(reader["CertificateDate"].ToString())
                        };
                        if (reader["Status"].ToString() == "0")
                            sub.Status = false;
                        else
                            sub.Status = true;
                        subs.Add(sub);
                    }
                }
            }
        }
        public void Add(Substitute sub)
        {
            // First we add it to the database
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Substitute(Name, Phone, CPR, CertificateDate, Status)" +
                    "VALUES (@Name, @Phone, @CPR, @CertificateDate, @Status" +
                    "SELECT @@IDENTITY", con);
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = sub.Name;
                cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = sub.Phone;
                cmd.Parameters.Add("@CPR", SqlDbType.NVarChar).Value = sub.CPR;
                cmd.Parameters.Add("@CertificateDate", SqlDbType.DateTime2).Value = sub.CertificateDate;
                if (sub.Status == false)
                    cmd.Parameters.Add("@Status", SqlDbType.Bit).Value = 0;
                else
                    cmd.Parameters.Add("@Status", SqlDbType.Bit).Value = 1;
                sub.Id = Convert.ToInt32(cmd.ExecuteScalar());
            }

            // Then we add it to the in-memory storage.
            subs.Add(sub);
        }
        public void Update(Substitute sub)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Substitute SET" +
                    "Name = @Name, Phone = @Phone, CPR = @CPR, " +
                    "CertificateDate = @CertificateDate, Status = @Status" +
                    "WHERE Id = @Id", con);
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = sub.Name;
                cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = sub.Phone;
                cmd.Parameters.Add("@CPR", SqlDbType.NVarChar).Value = sub.CPR;
                cmd.Parameters.Add("@CertificateDate", SqlDbType.DateTime2).Value = sub.CertificateDate;
                if (sub.Status == false)
                    cmd.Parameters.Add("@Status", SqlDbType.Bit).Value = 0;
                else
                    cmd.Parameters.Add("@Status", SqlDbType.Bit).Value = 1;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = sub.Id;
                cmd.ExecuteNonQuery();
            }
        }
        public void Delete(Substitute sub)
        {
            // First we delete it from the database.
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Substitute WHERE Id = @Id", con);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = sub.Id;
                cmd.ExecuteNonQuery();
            }

            // Then we delete it from the in-memory storage.
            subs.Remove(sub);
        }
        public Substitute? RetrieveById(int id)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Substitute WHERE Id = @Id", con);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        Substitute sub = new Substitute
                        {
                            Name = reader["Name"].ToString(),
                            Phone = reader["Phone"].ToString(),
                            CPR = reader["CPR"].ToString(),
                            CertificateDate = DateTime.Parse(reader["CertificateDate"].ToString())
                        };
                        if (reader["Status"].ToString() == "0")
                            sub.Status = false;
                        else
                            sub.Status = true;
                        return sub;
                    }
                }
            }
            return null;
        }
    }
}
