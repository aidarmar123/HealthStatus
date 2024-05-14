using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthStatus.Models.DBModels
{
    [Table("Message")]
    public partial class Message
    {

        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }
        public string Text { get; set; }
        public bool Avtor { get; set; } // false - Minday true - User


    }
}
