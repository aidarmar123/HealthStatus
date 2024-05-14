using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthStatus.Models.DBModels
{
    public partial class Message
    {

        public string Color
        {
            get
            {
                if (Avtor)
                    return "#A2CC5A";
                else
                    return "#DCDCDC";
            }
        }
        public HorizontalAlignment Position
        {
            get
            {
                if (Avtor)
                    
                    return HorizontalAlignment.Left;
                else
                    return HorizontalAlignment.Right;
            }

        }
    }
}
