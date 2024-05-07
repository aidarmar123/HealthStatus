using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthStatus.Models.DBModels
{
    [Table("StateHealth")]
    public class StateHealth
    {
        [PrimaryKey]
        [AutoIncrement]
        [Column("Id")]
        public int Id { get; set; }
        [Column("Time")]
        public DateTime time { get; set; }
        
        [Column("StateId")]
        public int StateId { get; set; }

        public State State { get; set; }
    }
}
