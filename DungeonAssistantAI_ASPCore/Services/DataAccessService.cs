using System.Data;
using System.Data.SqlClient;

namespace DungeonAssistantAI_ASPCore.Services
{
    public class DataAccessService : IDataAccessService
    {
        private const string KEY = "DUNGEONASSISTANT_CONNECTION_KEY";

        public DataAccessService()
        {
            DataSet data = ExecuteQuery("SELECT TOP (1000) [Id],[Name],[Created],[Deleted],[LastUpdated],[LastUpdatedBy],[LastAccessed],[LastAccessedBy],[IsActive],[IsDeleted] FROM [DB_133640_dungeondb].[dbo].[Campaign]");
            if (data != null)
            {
                Console.WriteLine("ID: " + data.Tables[0].Rows[0][0].ToString());
            }
        }

        public DataSet ExecuteQuery(string query)
        {
            return ExecuteQuery(query, new IDataParameter[0]);
        }

        public DataSet ExecuteQuery(string query, params IDataParameter[] parameters)
        {
            DataSet dt = new DataSet();

            try
            {
                using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
                {
                    using (var command = cnn.CreateCommand())
                    {
                        command.CommandText = query;

                        foreach (IDataParameter parameter in parameters)
                        {
                            command.Parameters.Add(parameter);
                        }

                        command.Connection.Open();
                        using (IDataReader reader = command.ExecuteReader())
                        {
                            while (reader.IsClosed == false)
                            {
                                dt.Tables.Add().Load(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return dt;
        }

        public bool ExecuteNonQuery(string query)
        {
            return ExecuteNonQuery(query, new IDataParameter[0]);
        }

        public bool ExecuteNonQuery(string query, params IDataParameter[] parameters)
        {
            bool success = false;

            try
            {
                using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
                {
                    using (var command = cnn.CreateCommand())
                    {
                        command.CommandText = query;

                        foreach (IDataParameter parameter in parameters)
                        {
                            command.Parameters.Add(parameter);
                        }

                        command.Connection.Open();
                        if (command.ExecuteNonQuery() == 1)
                        {
                            success = true;
                        }
                        else
                        {
                            Console.WriteLine("ExecuteNonQuery returned with a response code other than success");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return success;
        }

        private string GetConnectionString(string id = "Default")
        {
            return Environment.GetEnvironmentVariable(KEY, EnvironmentVariableTarget.User);
        }
    }
}
