using HealthStatus.Models.DBModels;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthStatus.Services
{
    public class LocalDbService
    {
        private const string DB_Name = "stateHealth.db3";
        private readonly SQLiteAsyncConnection connection;
        public LocalDbService()
        {
            connection = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, DB_Name));
            connection.CreateTableAsync<State>();
            connection.CreateTableAsync<StateHealth>();
        }
    }
}
