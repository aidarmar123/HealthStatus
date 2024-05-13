using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthStatus.Models.DBModels
{
    public partial class Message
    {
        
        public Color Color
        {
            get
            {           
                if(Avtor)
                    return Colors.Green;
                else
                    return Colors.LightGray;
            }
        }
        public HorizontalAlignment Position
        {
            get
            {
                if(Avtor)
                    return HorizontalAlignment.Right;
                else
                    return HorizontalAlignment.Left;
            }
        }
    }
}
