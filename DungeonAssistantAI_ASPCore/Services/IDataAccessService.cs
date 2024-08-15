using System.Data;

namespace DungeonAssistantAI_ASPCore.Services
{
    public interface IDataAccessService
    {
        DataSet ExecuteQuery(string query);
        DataSet ExecuteQuery(string query, params IDataParameter[] parameters);
        bool ExecuteNonQuery(string query);
        bool ExecuteNonQuery(string query, params IDataParameter[] parameters);
    }
}
