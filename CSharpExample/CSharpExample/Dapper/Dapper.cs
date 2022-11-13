using CSharpExample.Models;
using Dapper;
using System.Data.SqlClient;

namespace CSharpExample.Dapper
{
    public class Dapper
    {
        void ExecuteInsert()
        {
            string connectionString = GeneralSettings.ConnectionSeting;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine($"State : {connection.State}");
                Console.WriteLine($"ConnectionString : {connection.ConnectionString}");

                // 1. Yöntem
                connection.Execute("insert into Student (Name, LastName, BirthDate)" +
                    " values (@Name, @LastName, @BirthDate)",
                    new[] { new { Name = "Kamil", LastName = "KAPLAN", BirthDate = DateTime.Parse("03.03.1993") } });

                // 2. Yöntem
                connection.Execute("insert into Student (Name, LastName, BirthDate)" +
                    " values (@Name, @LastName, @BirthDate)",
                    new Student() { Name = "Ceylan", LastName = "Yağmur", BirthDate = DateTime.Parse("05.06.1995") });

                connection.Close();
            }
        }

        void QuerySelect()
        {
            string getconnectionString = GeneralSettings.GetConnectionString();
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = getconnectionString;
                connection.Open();
                Console.WriteLine($"State : {connection.State}");
                Console.WriteLine($"ConnectionString : {connection.ConnectionString}");

                // 1. Yöntem
                var resultData = connection.Query("SELECT * FROM Student");
                foreach (var item in resultData)
                    Console.WriteLine($"{item.Id}: {item.Name} {item.LastName}");

                // 2. Yöntem
                List<Student> students = connection.Query<Student>("SELECT * FROM Student").ToList();
                foreach (var item in students)
                    Console.WriteLine($"{item.Id}: {item.Name} {item.LastName}");

                connection.Close();
            }
        }
    }
}
