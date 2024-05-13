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
        private readonly SQLiteAsyncConnection DataBase;
        public LocalDbService()
        {
            DataBase = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, DB_Name));
            DataBase.CreateTableAsync<State>();
            DataBase.CreateTableAsync<StateHealth>();
            DataBase.CreateTableAsync<Message>();
        }

        public async Task<List<Message>> GetMessage()
        {
            return await DataBase.Table<Message>().ToListAsync();
        }
        public async Task<int> SaveMessage(Message msg)
        {
            if(msg.Id == 0) 
                return await DataBase.UpdateAsync(msg);
            else
                return await DataBase.InsertAsync(msg);
        }
    }
}
