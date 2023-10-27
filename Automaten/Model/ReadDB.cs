using System;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;

namespace Automaten.Model
{
	internal class ReadDB
	{
		ConnectionString.Connection Connection = new ConnectionString.Connection();
		List<string> Information = new List<string>();
		internal List<string> GetDBInfo(string Info)
		{
			SqlConnection conn = Connection.ConnectionString();
			Information.Clear();
			try
			{
				conn.Open();
				using (SqlCommand command = new SqlCommand(Info, conn))
				{
					using (SqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							Information.Add(reader.GetString(0).ToString());
						}
					}
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
			finally
			{
				conn.Close();
			}
			return Information;
		}
	}
}
