using System;
using Microsoft.Data.SqlClient;

namespace Automaten.Model.ConnectionString
{
	internal class Connection
	{
		private readonly string _connectionString = "Data Source=ZBC-S-RUNE4805;Initial Catalog=Automat;Integrated Security=True;TrustServerCertificate=True";
		internal SqlConnection ConnectionString()
		{
			SqlConnection conn = new SqlConnection(_connectionString);
			return conn;
		}
	}
}
