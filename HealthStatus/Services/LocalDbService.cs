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
        public const SQLite.SQLiteOpenFlags Flags =
        // open the database in read/write mode
        SQLite.SQLiteOpenFlags.ReadWrite |
        // create the database if it doesn't exist
        SQLite.SQLiteOpenFlags.Create |
        // enable multi-threaded database access
        SQLite.SQLiteOpenFlags.SharedCache;

        SQLiteAsyncConnection DataBase;
        public LocalDbService()
        {
        }
        public async Task Init()
        {
            if (DataBase is not null)
                return;
            DataBase = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, DB_Name), Flags);
            await DataBase.CreateTableAsync<State>();
            await DataBase.CreateTableAsync<StateHealth>();
            await DataBase.CreateTableAsync<Message>();
        }

        public async Task<List<Message>> GetMessage()
        {
            await Init();
            return await DataBase.Table<Message>().ToListAsync();
        }
        public async Task SaveMessage(Message msg)
        {
            await Init();
            if (msg.Id != 0)
                await DataBase.UpdateAsync(msg);
            else
                await DataBase.InsertAsync(msg);
        }
    }
}
