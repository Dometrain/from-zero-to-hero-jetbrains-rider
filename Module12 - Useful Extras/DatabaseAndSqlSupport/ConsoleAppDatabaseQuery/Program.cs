using Microsoft.Data.SqlClient;

const string connectionString = "Server=localhost;Database=AdventureWorksLT2022;User ID=sa;Password=YourStrong@Passw0rd;Trust Server Certificate=true;";

const string query = "SELECT * FROM SalesLT.Product";

using var connection = new SqlConnection(connectionString);

connection.Open();

using var command = new SqlCommand(query, connection);

using var reader = command.ExecuteReader();

while (reader.Read())
{
    Console.WriteLine(reader["Name"]);
}
